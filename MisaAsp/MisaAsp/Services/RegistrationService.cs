using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MisaAsp.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MisaAsp.Services
{
    public interface IRegistrationService
    {
        Task<int> RegisterUserAsync(RegistrationRequest request);
        Task<string> AuthenticateUserAsync(LoginRequest request);
        Task<IEnumerable<UserRequest>> GetAllUsersAsync();
    }

    public class RegistrationService : IRegistrationService
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _dbConnection;

        public RegistrationService(IDbConnection dbConnection, IConfiguration configuration)
        {
            _dbConnection = dbConnection;
            _configuration = configuration;
        }

        public async Task<IEnumerable<UserRequest>> GetAllUsersAsync()
        {
            var sql = "SELECT Id, FirstName, LastName, Email, PhoneNumber FROM Registrations";
            return await _dbConnection.QueryAsync<UserRequest>(sql);
        }

        private string GetMd5Hash(string input)
        {
            using (var md5 = MD5.Create())
            {
                var inputBytes = Encoding.ASCII.GetBytes(input);
                var hashBytes = md5.ComputeHash(inputBytes);

                var sb = new StringBuilder();
                foreach (var t in hashBytes)
                {
                    sb.Append(t.ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public async Task<int> RegisterUserAsync(RegistrationRequest request)
        {
            var hashedPassword = GetMd5Hash(request.Password);
            var sql = "INSERT INTO Registrations (FirstName, LastName, Email, PhoneNumber, Password) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Password) RETURNING Id";

            var parameters = new
            {
                request.FirstName,
                request.LastName,
                request.Email,
                request.PhoneNumber,
                Password = hashedPassword
            };

            await using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                if (connection.State == ConnectionState.Closed)
                    await connection.OpenAsync();

                var userId = await connection.ExecuteScalarAsync<int>(sql, parameters);
                return userId;
            }
        }

        public async Task<string> AuthenticateUserAsync(LoginRequest request)
        {
            var hashedPassword = GetMd5Hash(request.Password);
            var sql = "SELECT COUNT(1) FROM Registrations WHERE (Email = @EmailOrPhoneNumber OR PhoneNumber = @EmailOrPhoneNumber) AND Password = @Password";

            var parameters = new
            {
                request.EmailOrPhoneNumber,
                Password = hashedPassword
            };

            await using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                if (connection.State == ConnectionState.Closed)
                    await connection.OpenAsync();

                var loginResult = await connection.ExecuteScalarAsync<bool>(sql, parameters);

                if (loginResult)
                {
                    var jwtTokenHandler = new JwtSecurityTokenHandler();
                    var secretKey = _configuration.GetSection("Jwt").GetSection("SecretKey").Value;
                    if (string.IsNullOrEmpty(secretKey))
                        throw new ArgumentNullException(nameof(secretKey));

                    var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
                    var tokenDescription = new SecurityTokenDescriptor
                    {
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes), SecurityAlgorithms.HmacSha256),
                        Expires = DateTime.UtcNow.AddHours(1)
                    };

                    var token = jwtTokenHandler.CreateToken(tokenDescription);
                    return jwtTokenHandler.WriteToken(token);
                }
            }
            return null;
        }
    }
}

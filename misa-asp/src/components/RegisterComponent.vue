<template>
  <div class="register-page">
    <div class="register-container">
      <div class="logo-section">
        <router-link to="/">
          <img src="/src/assets/image/logo123.jpg" alt="MISA ASP Logo" class="main-logo" />
        </router-link>
      </div>
      <h2>Đăng ký kế toán dịch vụ</h2>
      <form @submit.prevent="register">
        <div class="form-group">
          <input type="text" v-model="firstName" placeholder="Họ và đệm" required />
          <input type="text" v-model="lastName" placeholder="Tên" required />
        </div>
        <div class="form-group">
          <input type="email" v-model="email" placeholder="Email" required />
        </div>
        <div class="form-group">
          <input type="text" v-model="phone" placeholder="Số điện thoại" required />
        </div>
        <div class="form-group">
          <input type="password" v-model="password" placeholder="Mật khẩu" required />
        </div>
        <p class="terms">
          Bằng cách bấm vào nút đăng ký, bạn đã đồng ý với
          <a href="#">Điều khoản dịch vụ</a> và
          <a href="#">Chính sách quyền riêng tư</a> của MISA.
        </p>
        <button type="submit" class="register-button">Đăng ký</button>
      </form>
      <div class="extra-links">
        <p>Bạn đã có tài khoản? <router-link to="/login">Đăng nhập</router-link></p>
        <p><router-link to="#">Trợ giúp</router-link></p>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'RegisterComponent',
  data() {
    return {
      firstName: '',
      lastName: '',
      email: '',
      phone: '',
      password: ''
    };
  },
  methods: {
    async register() {
      try {
        console.log('Sending request to register user...');
        const response = await this.$axios.post('/Registration/register', {
          FirstName: this.firstName,
          LastName: this.lastName,
          Email: this.email,
          PhoneNumber: this.phone,
          Password: this.password
        });
        console.log('User registered:', response.data);
        alert('Registration successful!');
      } catch (error) {
        console.error('There was an error registering the user:', error.response ? error.response.data : error.message);
        alert('Registration failed: ' + (error.response ? error.response.data.message : error.message));
      }
    }
  }
};
</script>

<style scoped>
.register-page {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  background-color: #0A2540;
}

.register-container {
  background-color: #fff;
  padding: 40px;
  border-radius: 8px;
  box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
  text-align: center;
  width: 400px;
}

.logo-section {
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 20px;
}

.main-logo {
  height: 60px;
}

.misa-logo {
  height: 24px;
}

h2 {
  margin-bottom: 20px;
  font-size: 24px;
  color: #333;
}

.form-group {
  margin-bottom: 20px;
  display: flex;
  gap: 10px;
}

.form-group input {
  flex: 1;
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 4px;
}

.form-group input[type="email"],
.form-group input[type="text"],
.form-group input[type="password"] {
  width: 100%;
  margin: 0;
}

.terms {
  font-size: 14px;
  color: #666;
  margin-bottom: 20px;
}

.terms a {
  color: #1E90FF;
  text-decoration: none;
}

.terms a:hover {
  text-decoration: underline;
}

.register-button {
  width: 100%;
  padding: 10px;
  border: none;
  border-radius: 4px;
  background-color: #4CAF50;
  color: white;
  cursor: pointer;
  font-size: 16px;
}

.extra-links {
  margin-top: 20px;
}

.extra-links p {
  margin: 5px 0;
}

.extra-links a {
  color: #1E90FF;
  text-decoration: none;
}

.extra-links a:hover {
  text-decoration: underline;
}
</style>

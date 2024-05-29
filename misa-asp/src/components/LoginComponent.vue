<template>
  <div class="login-page">
    <div class="login-container">
      <div class="logo-section">
        <router-link to="/">
          <img src="/src/assets/image/logo123.jpg" alt="MISA ASP Logo" class="main-logo" />
        </router-link>
      </div>
      <h2>Đăng nhập</h2>
      <form @submit.prevent="login">
        <div class="form-group">
          <input type="text" v-model="emailOrPhoneNumber" placeholder="Số điện thoại/Email" required />
        </div>
        <div class="form-group">
          <input type="password" v-model="password" placeholder="Mật khẩu" required />
        </div>
        <button type="submit" class="login-button">Đăng nhập</button>
      </form>
      <div class="extra-links">
        <p>Bạn chưa có tài khoản? <router-link to="/register">Đăng ký</router-link></p>
        <p><router-link to="#">Quên mật khẩu?</router-link></p>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'LoginComponent',
  data() {
    return {
      emailOrPhoneNumber: '',
      password: ''
    };
  },
  methods: {
    async login() {
      try {
        console.log('Sending request to login user...');
        const response = await this.$axios.post('/Login/login', {
          EmailOrPhoneNumber: this.emailOrPhoneNumber,
          Password: this.password
        });
        console.log('User logged in:', response.data);
        alert('Login successful!');
      } catch (error) {
        console.error('There was an error logging in the user:', error.response ? error.response.data : error.message);
        alert('Login failed: ' + (error.response ? error.response.data.message : error.message));
      }
    }
  }
};
</script>

<style scoped>
.login-page {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  background-color: #0A2540;
}

.login-container {
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

.form-group input[type="text"],
.form-group input[type="password"] {
  width: 100%;
  margin: 0;
}

.login-button {
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

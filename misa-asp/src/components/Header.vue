<template>
  <header class="header">
    <div class="container">
      <img src="C:\Users\vdlinh\source\repos\Vuejs\Day3\misa-asp\src\assets\image\logo123.jpg" alt="MISA ASP Logo" class="logo" />
      <nav class="nav">
        <ul class="nav-list">
          <li class="nav-item"><a href="#">Tìm kế toán</a></li>
          <li class="nav-item dropdown">
            <a href="#" @click.prevent="toggleDropdown('ktdv')">Dành cho KTDV</a>
            <ul class="dropdown-menu" v-if="dropdownOpen === 'ktdv'">
              <li><a href="#">Kiến thức chuyên môn</a></li>
              <li><a href="#">Kỹ năng nghề nghiệp</a></li>
              <li><a href="#">Quản trị nội bộ</a></li>
              <li><a href="#">Câu chuyện thành công</a></li>
            </ul>
          </li>
          <li class="nav-item dropdown">
            <a href="#" @click.prevent="toggleDropdown('dn')">Dành cho DN</a>
            <ul class="dropdown-menu" v-if="dropdownOpen === 'dn'">
              <li><a href="#">Thông tin doanh nghiệp</a></li>
              <li><a href="#">Dịch vụ hỗ trợ</a></li>
              <li><a href="#">Quản lý tài chính</a></li>
            </ul>
          </li>
          <li class="nav-item dropdown">
            <a href="#" @click.prevent="toggleDropdown('news')">Tin tức</a>
            <ul class="dropdown-menu" v-if="dropdownOpen === 'news'">
              <li><a href="#">Tin mới</a></li>
              <li><a href="#">Tin tức nội bộ</a></li>
              <li><a href="#">Sự kiện</a></li>
            </ul>
          </li>
          <li class="nav-item dropdown">
            <a href="#" @click.prevent="toggleDropdown('about')">Giới thiệu MISA ASP</a>
            <ul class="dropdown-menu" v-if="dropdownOpen === 'about'">
              <li><a href="#">Về chúng tôi</a></li>
              <li><a href="#">Đội ngũ</a></li>
              <li><a href="#">Liên hệ</a></li>
            </ul>
          </li>
        </ul>
      </nav>
      <div class="auth-buttons">
        <router-link to="/login" class="btn login">Đăng nhập</router-link>
        <router-link to="/register" class="btn register">Đăng ký</router-link>
      </div>
    </div>
  </header>
</template>

<script>
export default {
  name: 'Header',
  data() {
    return {
      dropdownOpen: ''
    };
  },
  methods: {
    toggleDropdown(menu) {
      this.dropdownOpen = this.dropdownOpen === menu ? '' : menu;
    }
  }
};
</script>

<style scoped>
.header {
  background-color: #fff;
  box-shadow: 0 2px 4px rgba(0,0,0,0.1);
  padding: 15px 0;
  position: fixed;
  top: 0;
  width: 100%;
  z-index: 1000;
}

.container {
  display: flex;
  align-items: center;
  justify-content: space-between;
  max-width: 1200px;
  margin: 0 auto;
  padding: 0 20px;
}

.logo {
  height: 50px; /* Adjusted for better alignment */
}

.nav {
  flex-grow: 1;
  margin-left: 30px;
}

.nav-list {
  list-style: none;
  display: flex;
  gap: 30px;
  margin: 0;
  padding: 0;
}

.nav-item {
  position: relative;
}

.nav-item a {
  text-decoration: none;
  color: #333;
  font-weight: 600;
  padding: 10px 0;
  display: inline-block;
  font-size: 16px; /* Adjusted for better alignment */
}

.nav-item.dropdown > a::after {
  content: '\25BC';
  margin-left: 8px;
  font-size: 0.8em;
}

.dropdown-menu {
  position: absolute;
  top: 100%;
  left: 0;
  background-color: white;
  box-shadow: 0 8px 16px rgba(0,0,0,0.1);
  border-radius: 8px;
  list-style: none;
  margin: 10px 0 0;
  padding: 10px 0;
  min-width: 200px;
  z-index: 1000;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.3s ease, visibility 0.3s ease;
}

.nav-item.dropdown:hover .dropdown-menu,
.nav-item.dropdown:focus-within .dropdown-menu {
  opacity: 1;
  visibility: visible;
}

.dropdown-menu li {
  padding: 0;
}

.dropdown-menu li a {
  text-decoration: none;
  color: #333;
  padding: 10px 20px;
  display: block;
  transition: background-color 0.3s ease, color 0.3s ease;
}

.dropdown-menu li a:hover {
  background-color: #4CAF50;
  color: #fff;
}

.auth-buttons {
  display: flex;
  gap: 10px;
}

.btn {
  padding: 10px 20px;
  border: none;
  border-radius: 4px;
  cursor: pointer;
  font-size: 16px;
  text-align: center;
  width: 120px; /* Set a fixed width for both buttons */
}

.login {
  background-color: transparent;
  color: #333;
  border: 2px solid #333;
  text-decoration: none;
  display: flex;
  align-items: center;
  justify-content: center;
}

.register {
  background-color: #4CAF50;
  color: #fff;
  text-decoration: none;
  display: flex;
  align-items: center;
  justify-content: center;
}

.login:hover, .register:hover {
  opacity: 0.8;
}
</style>

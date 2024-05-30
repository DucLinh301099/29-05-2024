<template>
  <div class="admin-page">
    <div class="header">
      <a href="/" class="logo">
        <img src="C:\Users\vdlinh\source\repos\Vuejs\Day5\MisaAsp-Project\29-05-2024\misa-asp\src\assets\image\logo123.jpg" alt="Logo" />
      </a>
      <h1>Quản lý người dùng</h1>
    </div>
    <table class="user-table">
      <thead>
        <tr>
          <th>Họ Tên</th>
          <th>Email</th>
          <th>Số điện thoại</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="user in users" :key="user.id">
          <td>{{ user.firstName }} {{ user.lastName }}</td>
          <td>{{ user.email }}</td>
          <td>{{ user.phoneNumber }}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'AdminComponent',
  data() {
    return {
      users: []
    };
  },
  async created() {
    try {
      const response = await axios.get('https://localhost:7173/api/Account/users');
      this.users = response.data;
    } catch (error) {
      console.error('Error fetching users:', error.response ? error.response.data : error.message);
      alert('Failed to fetch user data: ' + (error.response ? error.response.data.message : error.message));
    }
  }
};
</script>

<style scoped>
.admin-page {
  padding: 20px;
  background-color: #f7f7f7;
  font-family: Arial, sans-serif;
}

.header {
  display: flex;
  align-items: center;
  background-color: #28a745;
  padding: 10px;
  color: #fff;
  border-radius: 5px;
}

.header .logo img {
  height: 50px;
  margin-right: 20px;
}

.header h1 {
  margin: 0;
  font-size: 24px;
}

.user-table {
  width: 100%;
  border-collapse: collapse;
  margin-top: 20px;
  background-color: #fff;
  border-radius: 5px;
  overflow: hidden;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
}

.user-table th,
.user-table td {
  border: 1px solid #ddd;
  padding: 12px;
  text-align: left;
}

.user-table th {
  background-color: #28a745;
  color: #fff;
  font-weight: bold;
}

.user-table tr:nth-child(even) {
  background-color: #f9f9f9;
}

.user-table tr:hover {
  background-color: #f1f1f1;
}
</style>

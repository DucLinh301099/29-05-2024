import { createRouter, createWebHistory } from 'vue-router';
import Home from '../views/Home.vue';
import LoginComponent from '../components/LoginComponent.vue';
import RegisterComponent from '../components/RegisterComponent.vue';

import AdminComponent from '../components/AdminComponent.vue'; // Import AdminComponent

const routes = [
  { path: '/', component: Home },
  { path: '/login', component: LoginComponent },
  { path: '/register', component: RegisterComponent },
  { path: '/admin', component: AdminComponent }  // Add route for AdminComponent
];

const router = createRouter({
  history: createWebHistory(),
  routes
});

export default router;

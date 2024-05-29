import { createApp } from 'vue';
import App from './App.vue';
import router from './router';
import './assets/styles.css';
import axios from './axios'; // Import instance Axios

const app = createApp(App);
app.config.globalProperties.$axios = axios;
createApp(App).use(router).mount('#app');

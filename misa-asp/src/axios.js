import axios from 'axios';

// Tạo một instance Axios với base URL
const instance = axios.create({
  baseURL: 'https://localhost:7173/api', // Cấu hình URL gốc cho các yêu cầu
  headers: {
    'Content-Type': 'application/json'
  }
});

export default instance;

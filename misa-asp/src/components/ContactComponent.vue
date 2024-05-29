<template>
  <div class="contact-component">
    <div class="contact-info">
      <h2>Đăng ký nhận tư vấn miễn phí từ MISA ASP</h2>
      <p>
        MISA ASP là Nền tảng kết nối dịch vụ giúp kết nối Doanh nghiệp, Hộ kinh doanh, Cá nhân kinh doanh với các Tổ chức cung ứng dịch vụ kế toán uy tín, chất lượng, chuyên nghiệp trên toàn quốc.
      </p>
    </div>
    <div class="contact-form">
      <h3>Đăng ký nhận tư vấn miễn phí từ MISA ASP</h3>
      <form @submit.prevent="submitForm">
        <div class="form-group">
          <label for="name">Họ và tên *</label>
          <input type="text" id="name" v-model="form.name" required />
        </div>
        <div class="form-group">
          <label for="phone">Số điện thoại *</label>
          <input type="tel" id="phone" v-model="form.phone" required />
        </div>
        <div class="form-group">
          <label for="email">Email</label>
          <input type="email" id="email" v-model="form.email" />
        </div>
        <div class="form-group">
          <label>Bạn là ai?</label>
          <div class="radio-group">
            <input type="radio" id="service" value="Kế toán dịch vụ" v-model="form.role" />
            <label for="service">Kế toán dịch vụ</label>
            <input type="radio" id="organization" value="Đơn vị thuê KTDV" v-model="form.role" />
            <label for="organization">Đơn vị thuê KTDV</label>
          </div>
        </div>
        <div class="form-group">
          <label for="message">Nội dung cần tư vấn</label>
          <textarea id="message" v-model="form.message" placeholder="Vui lòng nhập nội dung bạn cần tư vấn tại đây"></textarea>
        </div>
        <p class="disclaimer">
          Bằng cách bấm vào nút Nhận tư vấn miễn phí, bạn đã đồng ý với <a href="#">Chính sách quyền riêng tư</a> của MISA.
        </p>
        <button type="submit" class="submit-btn">Nhận tư vấn miễn phí</button>
      </form>
    </div>
  </div>
</template>

<script>
export default {
  name: 'ContactComponent',
  data() {
    return {
      form: {
        name: '',
        phone: '',
        email: '',
        role: 'Kế toán dịch vụ',
        message: ''
      }
    };
  },
  methods: {
    submitForm() {
      // Handle form submission
      console.log('Form submitted:', this.form);
    }
  }
};
</script>

<style scoped>
.contact-component {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 50px;
  background-color: #00a65a;
  color: white;
}

.contact-info {
  max-width: 40%;
}

.contact-info h2 {
  font-size: 24px;
  margin-bottom: 20px;
}

.contact-info p {
  font-size: 16px;
}

.contact-form {
  background-color: white;
  color: #333;
  padding: 30px;
  border-radius: 8px;
  box-shadow: 0 2px 5px rgba(0,0,0,0.1);
  max-width: 50%;
}

.contact-form h3 {
  font-size: 20px;
  margin-bottom: 20px;
}

.form-group {
  margin-bottom: 15px;
}

.form-group label {
  display: block;
  margin-bottom: 5px;
  font-weight: bold;
}

.form-group input,
.form-group textarea {
  width: 100%;
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 4px;
}

.radio-group {
  display: flex;
  align-items: center;
  margin-top: 10px;
}

.radio-group input[type="radio"] {
  display: none;
}

.radio-group label {
  position: relative;
  padding-left: 30px;
  margin-right: 20px;
  cursor: pointer;
  font-size: 14px;
  color: #333;
}

.radio-group label::before {
  content: '';
  position: absolute;
  left: 0;
  top: 50%;
  transform: translateY(-50%);
  width: 20px;
  height: 20px;
  border: 2px solid #ccc;
  border-radius: 50%;
  background: #fff;
}

.radio-group input[type="radio"]:checked + label::before {
  border-color: #00a65a;
  background-color: #00a65a;
}

.radio-group input[type="radio"]:checked + label::after {
  content: '';
  position: absolute;
  left: 5px;
  top: 50%;
  transform: translateY(-50%);
  width: 10px;
  height: 10px;
  background: #fff;
  border-radius: 50%;
}

.disclaimer {
  font-size: 12px;
  color: #666;
  margin-bottom: 20px;
}

.disclaimer a {
  color: #00a65a;
}

.submit-btn {
  display: inline-block;
  padding: 10px 20px;
  background-color: #00a65a;
  color: white;
  border: none;
  border-radius: 4px;
  cursor: pointer;
  font-size: 16px;
}

.submit-btn:hover {
  background-color: #008c4a;
}
</style>

<template>
  <footer class="footer">
    <div class="footer-container">
      <div class="footer-section">
        <h3>Tìm KTDV theo lĩnh vực của DN</h3>
        <ul>
          <li><a href="#">Thương mại</a></li>
          <li><a href="#">Dịch vụ</a></li>
          <li><a href="#">Sản xuất</a></li>
          <li><a href="#">Xây dựng - Xây lắp</a></li>
        </ul>
      </div>
      <div class="footer-section">
        <h3>Tìm KTDV theo dịch vụ cần thuê</h3>
        <ul>
          <li><a href="#">Kế toán trọn gói</a></li>
          <li><a href="#">Kê khai thuế</a></li>
          <li><a href="#">Báo cáo tài chính</a></li>
          <li><a href="#">Quyết toán thuế</a></li>
          <li><a href="#">Thành lập, giải thể DN</a></li>
          <li><a href="#">Hoàn thuế</a></li>
          <li><a href="#">Thuê kế toán trưởng</a></li>
          <li><a href="#">Thuê kế toán nội bộ</a></li>
          <li><a href="#">Hỗ trợ tìm nhân sự kế toán</a></li>
          <li><a href="#">Đào tạo kế toán</a></li>
        </ul>
      </div>
      <div class="footer-section">
        <h3>Khác</h3>
        <ul>
          <li><a href="#">Câu hỏi thường gặp</a></li>
          <li><a href="#">HDSD MISA ASP dành cho KTDV</a></li>
          <li><a href="#">Thỏa thuận sử dụng dịch vụ</a></li>
          <li><a href="#">Chính sách quyền riêng tư</a></li>
        </ul>
      </div>
      <div class="footer-section">
        <h3>Các kênh hỗ trợ sử dụng</h3>
        <ul>
          <li><a href="#">Diễn đàn</a></li>
          <li><a href="#">Chat hỗ trợ trực tuyến</a></li>
        </ul>
      </div>
      <div class="footer-section">
        <h3>Liên hệ</h3>
        <ul>
          <li>Địa chỉ: Tòa nhà Technosoft - Ngõ 15 Duy Tân, Q.Cầu giấy, Hà Nội</li>
          <li>Email: <a href="mailto:asp@misa.com.vn">asp@misa.com.vn</a></li>
          <li>Hotline: <a href="tel:0904565649">0904565649</a></li>
        </ul>
      </div>
    </div>
  </footer>
</template>

<script>
export default {
  name: 'FooterComponent',
};
</script>

<style scoped>
.footer {
  background-color: #f5f5f5;
  padding: 20px 0;
}

.footer-container {
  display: flex;
  justify-content: space-around;
  max-width: 1200px;
  margin: 0 auto;
  flex-wrap: wrap;
}

.footer-section {
  flex: 1;
  min-width: 200px;
  margin: 10px;
}

.footer-section h3 {
  font-size: 16px;
  margin-bottom: 10px;
  font-weight: bold;
}

.footer-section ul {
  list-style-type: none;
  padding: 0;
}

.footer-section li {
  margin-bottom: 8px;
  font-size: 14px;
}

.footer-section a {
  color: #333;
  text-decoration: none;
}

.footer-section a:hover {
  text-decoration: underline;
}
</style>

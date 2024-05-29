<template>
  <div class="video-section">
    <div class="video-container">
      <img src="C:\Users\vdlinh\source\repos\Vuejs\Day3\misa-asp\src\assets\image\image2.png" alt="Video Thumbnail" class="video-thumbnail" />
      <div class="play-button">
        <svg width="50" height="50" viewBox="0 0 24 24"><path fill="currentColor" d="M8 5v14l11-7z"/></svg>
      </div>
    </div>
    <div class="cta">
      <h2>Nền tảng kế toán dịch vụ</h2>
      <p>MISA ASP là nền tảng kết nối dịch vụ giúp kết nối doanh nghiệp, hộ kinh doanh, cá nhân kinh doanh có nhu cầu thuê dịch vụ kế toán với tổ chức cung ứng dịch vụ kế toán, thuế uy tín, chất lượng, chuyên nghiệp trên toàn quốc.</p>
      <button>Nhận tư vấn miễn phí</button>
    </div>
  </div>
</template>

<script>
export default {
  name: 'VideoSection'
}
</script>

<style scoped>
.video-section {
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 50px 20px;
  background-color: #fff;
  flex-wrap: wrap;
}

.video-container {
  position: relative;
  max-width: 50%;
  flex: 1;
}

.video-thumbnail {
  width: 100%;
  height: auto;
  border-radius: 8px;
}

.play-button {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  width: 80px;
  height: 80px;
  background-color: rgba(0, 0, 0, 0.5);
  border-radius: 50%;
  display: flex;
  justify-content: center;
  align-items: center;
  cursor: pointer;
}

.play-button svg {
  fill: #fff;
}

.cta {
  max-width: 50%;
  flex: 1;
  padding: 20px;
}

.cta h2 {
  font-size: 24px;
  color: #333;
  margin-bottom: 10px;
}

.cta p {
  font-size: 16px;
  color: #666;
  margin-bottom: 20px;
}

.cta button {
  padding: 10px 20px;
  border: none;
  border-radius: 4px;
  background-color: #4CAF50;
  color: #fff;
  cursor: pointer;
  font-size: 16px;
}
</style>

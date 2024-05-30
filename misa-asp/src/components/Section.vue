<template>
  <div>
    <!-- Stats Section -->
    <div class="stats-container">
      <div class="search-bar">
        <input type="text" placeholder="Dịch vụ cần tìm" v-model="searchQuery" class="search-input" />
        <select v-model="selectedLocation" class="location-select">
          <option value="">Tỉnh/Thành phố</option>
          <!-- Add options for locations here -->
        </select>
        <button @click="search">Tìm kế toán</button>
      </div>
      <div class="stats">
        <div class="stat">
          <h3>20.592</h3>
          <p>Doanh nghiệp được kết nối</p>
        </div>
        <div class="stat">
          <h3>1.836</h3>
          <p>Hộ kinh doanh được kết nối</p>
        </div>
        <div class="stat">
          <h3>1.677</h3>
          <p>Đại lý thuế, kế toán dịch vụ</p>
        </div>
        <div class="stat">
          <h3>55.571</h3>
          <p>Người dùng</p>
        </div>
      </div>
    </div>
    
    <!-- Video Section -->
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
  </div>
</template>

<script>
export default {
  name: 'Section',
  data() {
    return {
      searchQuery: '',
      selectedLocation: ''
    };
  },
  methods: {
    search() {
      // Handle the search functionality
      console.log(`Searching for: ${this.searchQuery} in ${this.selectedLocation}`);
    }
  }
}
</script>

<style scoped>
/* Stats Section Styles */
.stats-container {
  text-align: center;
  padding: 50px 20px;
  background: linear-gradient(to right, #007a5a, #00a65a);
  color: white;
}

.search-bar {
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: white;
  padding: 5px;
  border-radius: 8px;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
  margin-bottom: 30px;
  max-width: 800px;
  margin: 0 auto 30px auto;
}

.search-input {
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 4px 0 0 4px;
  outline: none;
  font-size: 14px;
  flex: 2;
}

.location-select {
  padding: 10px;
  border: 1px solid #ccc;
  border-left: none;
  border-radius: 0 4px 4px 0;
  outline: none;
  font-size: 14px;
  flex: 1;
}

.search-bar button {
  padding: 10px 20px;
  border: none;
  background-color: #4CAF50;
  color: white;
  border-radius: 4px;
  cursor: pointer;
  font-size: 16px;
  margin-left: 10px;
}

.stats {
  display: flex;
  justify-content: space-around;
  flex-wrap: wrap;
}

.stat {
  text-align: center;
  flex: 1;
  min-width: 200px;
  margin: 10px 0;
}

.stat h3 {
  font-size: 2.5em;
  margin: 0;
  color: white;
}

.stat p {
  margin: 5px 0 0;
  color: white;
}

/* Video Section Styles */
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

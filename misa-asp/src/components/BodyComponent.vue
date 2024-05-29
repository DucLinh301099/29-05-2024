<template>
  <div class="body-component">
    <h2>Kế toán dịch vụ tiêu biểu</h2>
    <div class="filters">
      <input type="text" v-model="searchQuery" placeholder="Tìm kiếm dịch vụ" class="search-input" />
      <div class="filter-buttons">
        <button v-for="filter in filters" :key="filter" :class="{ active: selectedFilter === filter }" @click="selectedFilter = filter">
          {{ filter }}
        </button>
      </div>
    </div>
    <div class="service-list">
      <div class="service-card" v-for="service in filteredServices" :key="service.id">
        <img :src="service.logo" alt="Service Logo" class="service-logo" />
        <div class="service-details">
          <h3>{{ service.name }}</h3>
          <div class="rating">
            <span v-for="star in 5" :key="star" class="star" :class="{ filled: star <= service.rating }">&#9733;</span>
            <span>{{ service.reviews }} Đánh giá</span>
          </div>
          <div class="info">
            <span>{{ service.customers }} khách hàng</span>
            <span>{{ service.location }}</span>
          </div>
          <div class="price">Từ {{ service.price }}</div>
        </div>
      </div>
    </div>
    <div class="pagination">
      <button @click="prevPage" :disabled="currentPage === 1">Trước</button>
      <button @click="nextPage" :disabled="currentPage === totalPages">Sau</button>
    </div>
  </div>
</template>

<script>
export default {
  name: 'BodyComponent',
  data() {
    return {
      searchQuery: '',
      selectedFilter: 'Tiêu biểu',
      filters: ['Tiêu biểu', 'Có ưu đãi', 'Mới nhất', 'Tổ chức', 'Cá nhân'],
      services: [
        {
          id: 1,
          logo: 'https://via.placeholder.com/50',
          name: 'CÔNG TY CỔ PHẦN TƯ VẤN THUẾ SAVITAX',
          rating: 5,
          reviews: 86,
          customers: 378,
          location: 'Hồ Chí Minh',
          price: '500.000 - 20.000.000'
        },
        {
          id: 2,
          logo: 'https://via.placeholder.com/50',
          name: 'CÔNG TY TNHH DỊCH VỤ KẾ TOÁN THUẾ VÀ CUNG ỨNG LAO ĐỘNG QUANG HUY',
          rating: 4,
          reviews: 25,
          customers: 191,
          location: 'Hồ Chí Minh',
          price: '500.000 - 100.000.000'
        },
        {
          id: 3,
          logo: 'https://via.placeholder.com/50',
          name: 'CÔNG TY TNHH THƯƠNG MẠI DỊCH VỤ DOANH NGHIỆP NHẬT MINH',
          rating: 0,
          reviews: 0,
          customers: 376,
          location: 'Hà Nội',
          price: '500.000 - 20.000.000'
        },
        {
          id: 4,
          logo: 'https://via.placeholder.com/50',
          name: 'CÔNG TY TNHH DỊCH VỤ TƯ VẤN VÀ ĐẠI LÝ THUẾ TRƯỜNG GIA',
          rating: 5,
          reviews: 16,
          customers: 168,
          location: 'Hồ Chí Minh',
          price: '500.000 - 20.000.000'
        },
        {
          id: 5,
          logo: 'https://via.placeholder.com/50',
          name: 'CÔNG TY TNHH KẾ TOÁN AN GIẢI PHÁP',
          rating: 5,
          reviews: 1,
          customers: 127,
          location: 'Hà Nội',
          price: '500.000 - 20.000.000'
        },
        {
          id: 6,
          logo: 'https://via.placeholder.com/50',
          name: 'CÔNG TY TNHH TƯ VẤN DỊCH VỤ SLF',
          rating: 4,
          reviews: 7,
          customers: 112,
          location: 'Hồ Chí Minh',
          price: '500.000 - 20.000.000'
        },
        {
          id: 7,
          logo: 'https://via.placeholder.com/50',
          name: 'CÔNG TY TNHH KẾ TOÁN TÀI CHÍNH FATA',
          rating: 5,
          reviews: 23,
          customers: 92,
          location: 'Khánh Hòa',
          price: '1.500.000 - 50.000.000'
        },
        {
          id: 8,
          logo: 'https://via.placeholder.com/50',
          name: 'CÔNG TY TNHH DỊCH VỤ KẾ TOÁN THUẾ MINH ĐỨC',
          rating: 4,
          reviews: 9,
          customers: 146,
          location: 'Hà Nội',
          price: '500.000 - 20.000.000'
        }
      ],
      currentPage: 1,
      totalPages: 1,
    };
  },
  computed: {
    filteredServices() {
      return this.services.filter(service => 
        service.name.toLowerCase().includes(this.searchQuery.toLowerCase())
      );
    }
  },
  methods: {
    prevPage() {
      if (this.currentPage > 1) this.currentPage--;
    },
    nextPage() {
      if (this.currentPage < this.totalPages) this.currentPage++;
    }
  }
};
</script>

<style scoped>
.body-component {
  padding: 20px;
  background-color: #f5f5f5;
}

h2 {
  text-align: center;
  margin-bottom: 20px;
}

.filters {
  display: flex;
  justify-content: center;
  align-items: center;
  margin-bottom: 20px;
}

.search-input {
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 4px;
  margin-right: 20px;
  width: 300px;
}

.filter-buttons {
  display: flex;
}

.filter-buttons button {
  padding: 10px 20px;
  border: none;
  border-radius: 4px;
  background-color: #e0e0e0;
  margin: 0 5px;
  cursor: pointer;
}

.filter-buttons button.active,
.filter-buttons button:hover {
  background-color: #4CAF50;
  color: white;
}

.service-list {
  display: grid;
  grid-template-columns: repeat(4, 1fr);
  gap: 20px;
  justify-content: center;
}

.service-card {
  background-color: white;
  border: 1px solid #ddd;
  border-radius: 8px;
  padding: 20px;
  display: flex;
  align-items: center;
  box-shadow: 0 2px 5px rgba(0,0,0,0.1);
}

.service-logo {
  width: 50px;
  height: 50px;
  margin-right: 20px;
  border-radius: 8px;
}

.service-details {
  flex: 1;
}

.service-details h3 {
  margin: 0 0 10px;
  font-size: 16px;
  color: #333;
}

.rating {
  display: flex;
  align-items: center;
  margin-bottom: 10px;
}

.star {
  color: #ccc;
}

.star.filled {
  color: #FFD700;
}

.info {
  display: flex;
  justify-content: space-between;
  margin-bottom: 10px;
  color: #666;
}

.price {
  font-weight: bold;
  color: #333;
}

.pagination {
  text-align: center;
  margin-top: 20px;
}

.pagination button {
  padding: 10px 20px;
  border: none;
  border-radius: 4px;
  background-color: #4CAF50;
  color: white;
  cursor: pointer;
  margin: 0 5px;
}

.pagination button:disabled {
  background-color: #e0e0e0;
  cursor: not-allowed;
}
</style>

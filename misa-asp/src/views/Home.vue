<template>
  <div>
    <div id="app" class="app-container">
      <Header />
      <div class="main-content">
        <Stats />
      </div>
    </div>
    <VideoSection />
    <BodyComponent />
    <ContactComponent />
 
    <Footer />
  </div>
</template>

<script>
import Header from '../components/Header.vue';
import Stats from '../components/Stats.vue';
import VideoSection from '../components/VideoSection.vue';
import BodyComponent from '../components/BodyComponent.vue';
import ContactComponent from '../components/ContactComponent.vue';
import Footer from '../components/Footer.vue';


export default {
  name: 'Home',
  components: {
    Header,
    Stats,
    VideoSection,
    BodyComponent,
    ContactComponent,
    Footer
  
  }
}
</script>

<style scoped>
.app-container {
  padding-top: 80px; /* Adjust this value based on the height of your header */
}

.main-content {
  padding: 20px;
}
/* Global styles for the Home view */
</style>

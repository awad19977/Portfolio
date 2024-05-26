import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import axios from 'axios'
import VueAxios from 'vue-axios'
import Toast from 'vue-toastification'
import 'vue-toastification/dist/index.css'
//var cors = require('cors')

const app = createApp(App)
//app.use(cors())
app.use(router)
app.use(VueAxios, axios)
app.use(Toast)
app.mount('#app')
import axios from 'axios'

axios.defaults.baseURL = 'https://awademad.com'
axios.defaults.headers.common['Authorization'] = 'Bearer ' + localStorage.getItem('token')

export default axios
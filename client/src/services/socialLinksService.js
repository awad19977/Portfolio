import axios from '@/axiosDefaults'

const path = '/api/social-links'

const socialLinksService = {
  async getAll() {
    return await axios.get(`${path}`)
  },
  async get(id) {
    return await axios.get(`${path}/${id}`)
  },
  async update(id, model) {
    return await axios.put(`${path}/${id}`, model)
  },
  async create(model) {
    return await axios.post(`${path}`, model)
  },
  async delete(id) {
    return await axios.delete(`${path}/${id}`)
  }
}

export default socialLinksService
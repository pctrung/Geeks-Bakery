import API from "./API.js";

const baseApiUrl = "/categories";

const categoryApi = {
  getAllAsync: async () => {
    try {
      const url = baseApiUrl;
      return await API.get(url);
    } catch (error) {
      //alert(error);
      console.error(error);
    }
  },
  getByIdAsync: async (id) => {
    try {
      const url = `${baseApiUrl}/${id}`;
      return await API.get(url);
    } catch (error) {
      //alert(error);
      console.error(error);
    }
  },
  addAsync: async (content) => {
    try {
      const url = baseApiUrl;
      return await API.post(url, content);
    } catch (error) {
      //alert(error);
      console.error(error);
    }
  },
  updateAsync: async (content) => {
    try {
      const url = baseApiUrl;
      return await API.put(url, content);
    } catch (error) {
      //alert(error);
      console.error(error);
    }
  },
  deleteAsync: async (id) => {
    try {
      const url = `${baseApiUrl}/${id}`;
      return await API.delete(url);
    } catch (error) {
      //alert(error);
      console.error(error);
    }
  },
};
export default categoryApi;

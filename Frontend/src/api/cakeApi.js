import API from "./API.js";

const baseApiUrl = "/cakes";

const cakeApi = {
  getAllAsync: async (params) => {
    const url = baseApiUrl;
    try {
      var result = await API.get(url, { params: params });
      return result;
    } catch (error) {
      //alert(error);
      console.error(error);
    }
  },
  getByIdAsync: async (id) => {
    try {
      const url = `${baseApiUrl}/${id}`;
      var result = await API.get(url);
      return result;
    } catch (error) {
      //alert(error);
      console.error(error);
    }
  },
  addAsync: async (content) => {
    try {
      const url = baseApiUrl;
      var result = await API.post(url, content);
      return result;
    } catch (error) {
      //alert(error);
      console.error(error);
    }
  },
  updateAsync: async (content) => {
    try {
      const url = baseApiUrl;
      var result = await API.put(url, content);
      return result;
    } catch (error) {
      //alert(error);
      console.error(error);
    }
  },
  deleteAsync: async (id) => {
    try {
      const url = baseApiUrl;
      var result = await API.delete(`${url}/${id}`);
      return result;
    } catch (error) {
      //alert(error);
      console.error(error);
    }
  },
};

export default cakeApi;

import API from "./API.js";

const baseApiUrl = "/images";

const imageApi = {
  addAsync: async (content) => {
    try {
      const url = baseApiUrl;
      API.interceptors.request.use(async (config) => {
        var token = window.localStorage.getItem("token");

        var newConfig = {};
        if (token) {
          newConfig = {
            ...config,
            headers: {
              "content-type": "multipart/form-data",
              Authorization: `Bearer ${token}`,
            },
          };
        }
        return newConfig;
      });
      return await API.post(url, content);
    } catch (error) {
      //alert(error);
      console.error(error);
    }
  },
  updateAsync: async (content) => {
    try {
      const url = baseApiUrl;
      API.interceptors.request.use(async (config) => {
        var token = window.localStorage.getItem("token");

        var newConfig = {};
        if (token) {
          newConfig = {
            ...config,
            headers: {
              "content-type": "multipart/form-data",
              Authorization: `Bearer ${token}`,
            },
          };
        }
        return newConfig;
      });
      return await API.put(url, content);
    } catch (error) {
      //alert(error);
      console.error(error);
    }
  },
  deleteAsync: async (id, cakeId) => {
    try {
      const url = `${baseApiUrl}/${id}`;
      return await API.delete(url, { params: { cakeId: cakeId } });
    } catch (error) {
      //alert(error);
      console.error(error);
    }
  },
};
export default imageApi;

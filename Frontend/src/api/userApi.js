import API from "./API.js";

const baseApiUrl = "/users";

const categoryApi = {
  getAllAsync: async (params) => {
    const url = baseApiUrl;
    try {
      var result = await API.get(url, { params: params });
      return result;
    } catch (error) {
      alert(error);
      //console.error(error);
    }
  },
  getByIdAsync: async (id) => {
    try {
      const url = `${baseApiUrl}/${id}`;
      var result = await API.get(url);
      return result;
    } catch (error) {
      alert(error);
      //console.error(error);
    }
  },
  // not available now
  // addAsync: (content) => {
  //   try {
  //     const url = baseApiUrl;
  //     return API.post(url, content);
  //   } catch (error) {
  //     alert(error);
  //     //console.error(error);
  //   }
  // },
  // updateAsync: (content) => {
  //   try {
  //     const url = baseApiUrl;
  //     return API.put(url, content);
  //   } catch (error) {
  //     alert(error);
  //     //console.error(error);
  //   }
  // },
  // deleteAsync: (id) => {
  //   try {
  //     const url = `${baseApiUrl}/${id}`;
  //     return API.delete(url);
  //   } catch (error) {
  //     alert(error);
  //     //console.error(error);
  //   }
  // },
};
export default categoryApi;

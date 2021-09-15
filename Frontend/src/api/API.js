import axios from "axios";
import queryString from "query-string";

const API = axios.create({
  baseURL: process.env.REACT_APP_API_URL,
  timeout: 300000,
  headers: {
    "Content-Type": "application/json",
  },
  paramsSerializer: (params) => queryString.stringify(params),
});

API.interceptors.request.use(async (config) => {
  var token = window.localStorage.getItem("token");

  var newConfig = config;
  if (token) {
    newConfig = {
      ...config,
      headers: { Authorization: `Bearer ${token}` },
    };
  }
  return newConfig;
});
API.interceptors.response.use(
  (response) => {
    if (response && response.data) {
      return response.data;
    }
  },
  (error) => {
    console.error(error);
  },
);

export default API;

import API from "./API.js";
import jwt from "jwt-decode";

const baseApiUrl = "/users";

const authApi = {
  loginAsync: async (content) => {
    try {
      const url = `${baseApiUrl}/authenticate`;
      var token = await API.post(url, content);

      if (typeof token == "undefined") {
        return "incorrect";
      }

      const user = jwt(token);

      if (user.Role === "admin") {
        setToken(token);
        return true;
      }
      return false;
    } catch (error) {
      console.error(error);
    }
  },

  currentUser: () => {
    if (isLogin()) {
      var token = getToken();
      const user = jwt(token);
      return user;
    }
    return false;
  },

  logout: () => {
    if (getToken()) {
      removeToken();
      return true;
    }
  },
};
function isLogin() {
  var token = getToken();
  if (token && typeof token !== "undefined") {
    var user = jwt(token);
    if (user.Role === "admin") {
      if (!isTokenExpired(token)) {
        return true;
      }
    }
    return false;
  }
  return false;
}
function isTokenExpired(token) {
  if (jwt(token).exp < Date.now() / 1000) {
    localStorage.clear();
    return true;
  }
}
// function refreshToken(){

// }
function getToken() {
  return window.localStorage.getItem("token");
}
function setToken(token) {
  window.localStorage.setItem("token", token);
}
function removeToken() {
  window.localStorage.removeItem("token");
}

export default authApi;

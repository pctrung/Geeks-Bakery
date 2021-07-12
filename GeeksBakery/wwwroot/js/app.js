$(document).ready(function () {
  screenLoaded(2000);
});

// function loadingScreen(){
//   var loadingScreen = document.createElement("div").id("loading-screen");
//   document.body.appendChild(loadingScreen);
// }

function screenLoaded(timeOut) {
  var loadingScreen = $("#loading-screen");
  loadingScreen.addClass("animation-loaded");
  setTimeout(() => loadingScreen.remove(), timeOut);
  document.body.classList += " fade-in";
}

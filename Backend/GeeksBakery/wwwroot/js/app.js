$(document).ready(function () {
  var image = document.querySelector("img");
  var isLoaded = image.complete && image.naturalHeight !== 0;
  if (isLoaded) {
    screenLoaded();
  }
});

function screenLoaded() {
  var loadingScreen = $("#loading-screen");
  loadingScreen.addClass("animation-loaded");

  document.body.classList += " fade-in";
  loadingScreen.remove();
}

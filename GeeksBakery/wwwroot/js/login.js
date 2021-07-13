window.onload = () => {
  var switchLoginButton = document.getElementById("switchToLogin");
  var switchRegisterButton = document.getElementById("switchToRegister");
  var switchButton = document.getElementById("switchButton");
  var formInputGroup = document.getElementById("formInputGroup");

  switchLoginButton.addEventListener("click", switchState);
  switchRegisterButton.addEventListener("click", switchState);

  function switchState() {
    switchButton.classList.toggle("switch-button__switch--switched");

    switchRegisterButton.classList.toggle("switch-button__button--active");
    switchLoginButton.classList.toggle("switch-button__button--active");

    formInputGroup.classList.toggle("form-group--switched");
  }

  if (location.href.toLowerCase().includes("register")) {
    switchState();
  }
};

$(document).ready(function () {
  if ($(".slider__item").length > 0) {
    var currentSlideIndex = 0;
    var numOfItem = $(".slider__item").length;

    function togglePageIndex(previousSlideIndex, currentSlideIndex) {
      $(`.paging-item:nth(${currentSlideIndex - 1})`).addClass(
        "paging-item--active",
      );
      $(`.paging-item:nth(${previousSlideIndex - 1})`).removeClass(
        "paging-item--active",
      );
    }

    function showSlide(nextSlideIndex) {
      if (
        nextSlideIndex > 0 &&
        nextSlideIndex <= numOfItem &&
        nextSlideIndex != currentSlideIndex
      ) {
        nextSlideIndex = nextSlideIndex - 1;
        $(".slider").css("margin-left", `-${nextSlideIndex}00%`);
        togglePageIndex(currentSlideIndex, nextSlideIndex + 1);
        currentSlideIndex = nextSlideIndex + 1;
      }
    }

    function nextSlide() {
      showSlide(currentSlideIndex + 1);
    }
    function previousSlide() {
      showSlide(currentSlideIndex - 1);
    }

    $(".best-seller__previous-arrow").click(() => previousSlide());
    $(".best-seller__next-arrow").click(() => nextSlide());

    // increase width of slider
    if (numOfItem != 3) {
      $(".slider").css("width", $(".slider__item").length + "00%");
    }

    // Add paging index
    for (var i = 1; i <= numOfItem; i++) {
      $(".paging").append(`<li class="paging-item"></li>`);
    }

    document.querySelectorAll(".paging-item").forEach((item, index) => {
      item.addEventListener("click", () => showSlide(index + 1));
    });

    showSlide(1);
  }
});

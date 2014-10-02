//load the DOM into jQuery
$(document).ready(function () {
    //functions go inside the document.ready() callback
    /*Carousel functions START*/
    $('.carousel-next').on('click', function () {
        //get the active slide
        var activeSlide = $(this).parent().find('.carousel.active');
        //get the next slide
        var nextSlide = activeSlide.next();
        //make sure it's a carousel slide
        if (!nextSlide.hasClass('carousel')) {
            nextSlide = $(this).parent().find('.carousel').first();
        }
        //remove the active class, add hide class to the active slide
        activeSlide.removeClass('active').addClass('hide');
        //remove the hide class, add the active class to the next slide
        nextSlide.remove('hide').addClass('active');
    });
    /*Carousel functions END*/


});
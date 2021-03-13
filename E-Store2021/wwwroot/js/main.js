$(function()
{
    $('.banner-section_slider').slick({
        dots: true,
        prevArrow: '<button class="banner-section_slider-btn banner-section_slider-btnprev"><img src="images/left-arrow.png" alt=""></button>',
        nextArrow: '<button class="banner-section_slider-btn banner-section_slider-btnnext"><img src="images/right-arrow.png" alt=""></button>'
    });

    $('.tab').on('click', function(e){
        e.preventDefault();

        $($(this).siblings()).removeClass('tab--active');
        $($(this).parent().siblings().find('div')).removeClass('tabs-content--active')

        $(this).addClass('tab--active');

        $($(this).attr('href')).addClass('tabs-content--active');
    });

    $('.product-item_favorite').on('click', function(){
        $($(this)).toggleClass('product-item_favorite--active');
    });

    $('.product-slider').slick({
        slidesToShow: 4,
        slidesToScroll: 1,
        prevArrow: '<button class="product-slider_slider-btn product-slider_slider-btnprev"><img src="images/left-arrow.png" alt=""></button>',
        nextArrow: '<button class="product-slider_slider-btn product-slider_slider-btnnext"><img src="images/right-arrow.png" alt=""></button>'
    });

    $('.filter-style').styler();

    $('.filter_item-drop, .filter-extra').on('click', function(){
        $(this).toggleClass('filter_item-drop--active');
        $(this).next().slideToggle(200);
    });

    $('.catalog_filter-btngrid').on('click', function(){
        $(this).addClass('catalog_filter-button--active');
        $('.catalog_filter-btnline').removeClass('catalog_filter-button--active');
        $('.product-item_wrapper').removeClass('product-item_wrapper--list');

    })

    $('.catalog_filter-btnline').on('click', function(){
        $(this).addClass('catalog_filter-button--active');
        $('.catalog_filter-btngrid').removeClass('catalog_filter-button--active');
        $('.product-item_wrapper').addClass('product-item_wrapper--list');
    })

    var slider = $('.js-range-slider');

    slider.ionRangeSlider({
        type: "double",
        prefix: '$',
        grid: true,
        sessionStorage: true
    });

    slider.on("change", function () {
        var $input = $(this);

        var from = $input.data("from");   // input data-from attribute

        var to = $input.data("to");       // input data-to attribute

        $('#startPrice').attr('value', from);

        $('#endPrice').attr('value', to);

        localStorage.setItem('startPrice', from);

        localStorage.setItem('endPrice', to);

        console.log(from, to);       // all values
    });

    $(".rate-yo").rateYo({
        spacing: "5px",
        multiColor: {
            "startColor": "#FF0000",
            "endColor": "#0065ff"
        }
    });

    $(".rateYo-review").rateYo({
        starWidth: "20px",
    });
});


$(function()
{
    $('.banner-section_slider').slick({
        dots: true,
        prevArrow: '<button class="banner-section_slider-btn banner-section_slider-btnprev"><img src="images/left-arrow.png" alt=""></button>',
        nextArrow: '<button class="banner-section_slider-btn banner-section_slider-btnnext"><img src="images/right-arrow.png" alt=""></button>',

        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    arrows: false
                }
            },
        ]

    });

    $('.tab').on('click', function (e) {
        e.preventDefault();

        $($(this).siblings()).removeClass('tab--active');
        $($(this).closest('.tabs-wrapper').siblings().find('div')).removeClass('tabs-content--active')

        $(this).addClass('tab--active');

        $($(this).attr('href')).addClass('tabs-content--active');
        $('.product-slider').slick('setPosition');
    });

    $('.product-item_favorite').on('click', function () {
        $($(this)).toggleClass('product-item_favorite--active');
    });

    $('.product-slider').slick({
        slidesToShow: 4,
        slidesToScroll: 1,
        prevArrow: '<button class="product-slider_slider-btn product-slider_slider-btnprev"><img src="images/left-arrow.png" alt=""></button>',
        nextArrow: '<button class="product-slider_slider-btn product-slider_slider-btnnext"><img src="images/right-arrow.png" alt=""></button>',

        responsive: [
            {
                breakpoint: 1301,
                settings: {
                    arrows: false,
                    dots: true,
                }
            },
            {
                breakpoint: 1201,
                settings: {
                    arrows: false,
                    slidesToShow: 3,
                    dots: true,
                }
            },
            {
                breakpoint: 870,
                settings: {
                    arrows: false,
                    slidesToShow: 2,
                    dots: true,
                }
            },
            {
                breakpoint: 590,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    dots: true,
                }
            },
        ]
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

    $('.footer_top-drop').on('click', function () {
        $(this).next().slideToggle();
        $(this).toggleClass('footer_top-drop--active');
    });

    $(".rateYo-review").rateYo({
        starWidth: "20px",
    });

    $(".menu_btn").on('click', function() {
        $('.menu-mobile_list').toggleClass('menu-mobile_list--active')
    })

});


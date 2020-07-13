$(document).ready(function () {
    $('.nav-item').on('click', function () {
        var item = $(this);
        if (item.hasClass('active')) {
            item.removeClass('active')
        } else {
            item.addClass('active')
        }
    })
});
 
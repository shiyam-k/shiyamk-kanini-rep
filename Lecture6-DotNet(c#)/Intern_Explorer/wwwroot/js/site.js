$(document).ready(function () {
    // Show the initial active tab
    $('.nav-link.active').tab('show');

    // Handle tab click event
    $('.nav-link').on('click', function (event) {
        event.preventDefault();

        // Get the target tab content ID
        var target = $(this).attr('href');

        // Hide the previous tab content with animation
        $('.tab-pane.show').removeClass('show').addClass('hide').css('z-index',100);
        
        // Show the clicked tab content with animation
        setTimeout(function () {
            $(target).removeClass('hide').addClass('show').css('z-index', 200);
        }, 300); 

        $('.nav-link').removeClass('active');
        $(this).addClass('active');
       
    });
});








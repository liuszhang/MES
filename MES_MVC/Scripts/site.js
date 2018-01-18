MVCxClientGlobalEvents.AddControlsInitializedEventHandler(adjustNavMenu);
$(document).ready(function() {
    $(window).resize(adjustNavMenu);
    $(window).scroll(function() {
        toogleFixedTopPanel();
        toogleBackToTopButton();
    });
    $("#btnBackToTop").click(function(event) {
        event.preventDefault();
        $("html, body").animate({ scrollTop: 0 }, '500');
        return false;
    });
});

function toogleFixedTopPanel(){
    if($(document).scrollTop() > 100 && !TopPanel.IsExpandable()) {
        $('header').addClass('shrink');
        $('body').css('padding-top', $('header').outerHeight());
    } else {
        $('header').removeClass('shrink');
        $('body').css('padding-top', 0);
    }
}
function toogleBackToTopButton(){
    var offset = 200;
    if($(this).scrollTop() > offset)
        $(".btnBackToTop").removeClass("hidden");
    else
        $(".btnBackToTop").addClass("hidden");
}
function adjustNavMenu(){
    var orientation = TopPanel.IsExpandable() ? 'Vertical' : 'Horizontal';
    if(orientation !== NavMenu.GetOrientation())
        NavMenu.SetOrientation(orientation);
}
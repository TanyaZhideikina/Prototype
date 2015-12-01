$(document).ready(function(){

	var $menu = $("#menu");

	$(window).scroll(function(){
		if ( $(this).scrollTop() > 100 && $menu.hasClass("default") ){
			$menu.removeClass("default").addClass("fixed");
			$("#log").css({visibility:"visible"});
			$("#log").addClass('animated fadeInLeft');
		}
		else if($(this).scrollTop() <= 100 && $menu.hasClass("fixed")) {
			$("#log").css({visibility:"hidden"});
			$menu.removeClass("fixed").addClass("default");
			
		}
	});
});
        //scroll










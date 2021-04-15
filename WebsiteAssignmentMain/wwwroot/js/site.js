

mybutton = document.getElementById("TopBtn");

// When the user scrolls down 20px from the top of the document, show the button
window.onscroll = function () {scrollFunction()};

function scrollFunction() {
        if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        mybutton.style.display = "block";
                } else {
        mybutton.style.display = "none";
                }
            }

    // When the user clicks on the button, scroll to the top of the document
function topFunction() {
document.body.scrollTop = 0; // For Safari
        document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
}


function setCookie(name, value, expires, path, domain, secure) {

    document.cookie = name + "=" + escape(value) +

        ((expires) ? "; expires=" + expires.toGMTString() : "") +

        ((path) ? "; path=" + path : "") +

        ((domain) ? "; domain=" + domain : "") +

        ((secure) ? "; secure" : "");

}




//  cookies

 function getCookie(name) {

    var dc = document.cookie;

    var prefix = name + "=";

    var begin = dc.indexOf("; " + prefix);

    if (begin == -1) {

            begin = dc.indexOf(prefix);

        if (begin != 0) return null;

    } else {

            begin += 2;

    }

    var end = document.cookie.indexOf(";", begin);

    if (end == -1) {

            end = dc.length;

    }

    return unescape(dc.substring(begin + prefix.length, end));

}

        function deleteCookie(name, path, domain) {

    if (getCookie(name)) {

            document.cookie = name + "=" +

            ((path) ? "; path=" + path : "") +

            ((domain) ? "; domain=" + domain : "") +

            "; expires=Thu, 01-Jan-70 00:00:01 GMT";
    }
}
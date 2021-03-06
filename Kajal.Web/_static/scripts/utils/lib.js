﻿function FixScrollPadding() {
    if (($(window).width() > 1024) && ($('html').height() < $(window).height()))
        $('.container').css('padding-right', '17px');
}


function $get(Id) { return document.getElementById('Id'); }

/* ---- :: Left Fonksiyonu :: ------------------------------------------------------------------------- */
/* 
str = Kelime
n = Soldan Kaç Karakter ?
*/
function Left(str, n) {
    if (n <= 0) return "";
    else if (n > String(str).length) return str;
    else return String(str).substring(0, n);
}



/* ---- :: Right Fonksiyonu :: ------------------------------------------------------------------------ */

/* 
str = Kelime
n = Sağdan Kaç Karakter ?
*/
function Right(str, n) {
    if (n <= 0) return "";
    else if (n > String(str).length) return str;
    else {
        var iLen = String(str).length;
        return String(str).substring(iLen, iLen - n);
    }
}


/* 
MaxNumber = Kaça kadar bir sayı tutsun 
*/
function RandomNumber(MaxNumber) {
    return Math.floor(Math.random() * MaxNumber + 1);
}


function trim(str, chars) {
    return lTrim(rTrim(str, chars), chars);
}

function lTrim(str, chars) {
    chars = chars || "\\s";
    return str.replace(new RegExp("^[" + chars + "]+", "g"), "");
}

function rTrim(str, chars) {
    chars = chars || "\\s";
    return str.replace(new RegExp("[" + chars + "]+$", "g"), "");
}

function rdListSelectedValue(RadiButtonListID) {
    var obj = document.forms[0][RadiButtonListID];
    for (i = 0; i < obj.length; i++) {
        if (obj[i].checked) {
            return obj[i].value;
        }
    }
    return -1;
}

function ClsChng(eID, ClassName) {
    if ($get(eID) != null)
        $get(eID).className = ClassName;
}


function txtInitial(eID, ClassName, Text) {
    $get(eID).className = ClassName;
    $get(eID).value = Text;
}

/* 
chListID = CheckBoxList ID
ItemCount = Item Sayısı
*/
function ChListRequired(chListID, ItemCount) {
    for (i = 0; i < ItemCount; i++) {
        if ($get(chListID + '_' + i).checked)
            return true;
    }
    return false;
}


function UrlAmpReplace(URL) {
    return URL.replace(/amp;/gi, '')
}


function setCookie(name, value, days) {
    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
        var expires = "; expires=" + date.toGMTString();
    }
    else var expires = "";
    document.cookie = name + "=" + value + expires + "; path=/";
}

function getCookie(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
    }
    return null;
}

function deleteCookie(name) {
    setCookie(name, "", -1);
}

function goToWww(redirectUrl) {
    url = document.location.href.toString();
    if (url.search("www") == -1)
        document.write("<meta http-equiv=\"REFRESH\" content=\"0; url=" + redirectUrl + "\">")
}

function IsTablet() {
    var uAgent = navigator.userAgent;
    return (uAgent.indexOf("iPad") != -1 && uAgent.indexOf("gt-") == -1);
}



function AddOverlay() {
    var overlayHtml = '<div id="_overlay"></div>';
    $("body").append(overlayHtml);
    $("#_overlay").css({
        position: 'absolute',
        zIndex: 9,
        top: '0px',
        left: '0px',
        width: '100%',
        height: $(document).height(),
        background: '#000',
        opacity: 0
    });
}


function lightsOff(speed, opac) {
    if (speed == null) speed = 500;
    if (opac == null) opac = 0.8;

    if ($('#_overlay').length == 0) AddOverlay();

    $('#_overlay').show().stop().delay(200).animate({ opacity: opac }, speed);
    $("#_overlay").click(lightsOn);
}

function lightsOn(speed) {
    if (speed == null) speed = 500;
    $("#_overlay").remove().animate({ opacity: .0 }, speed);
}

function go(URL) {
    location.href = URL;
}


function SelectDataBind(target, ds, liKey, liValue, selectedValue, fncCompleted) {

    var sl = $(target);
    var optInitial = $(target + ' option:first-child');
    sl.empty();
    sl.append(0, optInitial.val("").text(defaultSelectText));

    if (ds != null) {
        var lastIndex = ds.length - 1;

        $.each(ds, function (index, item) {
            sl.append($('<option/>', {
                value: item[liKey],
                text: item[liValue]
            }));

            if (index == lastIndex) {
                if (selectedValue != null)
                    sl.val(selectedValue);

                if (fncCompleted != undefined)
                    fncCompleted();
            }
        });
    }
    else {
        if (fncCompleted != undefined)
            fncCompleted();
    }
}


function SelectDataBindEmpty(target, fncCompleted) {
    SelectDataBind(target, null, null, null, null, fncCompleted);
}


function goDetailFromInnerLink(e, IsBlank) {
    if ((IsBlank == null) || (IsBlank = false))
        window.location.href = $(e).find("a").attr("href");
    else
        window.open($(e).find("a").attr("href"));
}
﻿$(function () {
    $(".table tr").mouseover(function () {
        $(this).animate({ height: '+=25', width: '+=25' })
               .animate({ height: '-=25', width: '-=25' });
    });
});
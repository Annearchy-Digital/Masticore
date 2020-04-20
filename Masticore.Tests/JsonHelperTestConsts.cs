﻿namespace Masticore
{
    public class JsonHelperTestConsts
    {
        public class RemoveMarkUpConsts
        {
            public const string A =
                "<p>Some Text lorem ipsum That I Placed Here Antarctica Giraffe</p>\n\n<p>&nbsp;</p>\n\n<p>And some more text down here</p>\n\n<p>Lorem ipsum</p>\n\n<p>&nbsp;</p>\n\n<p>&nbsp;</p>\n\n<p>Some more text lorem ipsum and more and more</p>\n\n<p>Belly text</p>\n\n<p>&nbsp;</p>\n\n<p>Monkey business blah blah</p>\n\n<p>&nbsp;</p>\n\n<p>And more!</p>\n";
            public const string AResult = " Some Text lorem ipsum That I Placed Here Antarctica Giraffe       And some more text down here   Lorem ipsum           Some more text lorem ipsum and more and more   Belly text       Monkey business blah blah       And more!  ";

        }


        public const string Original = "<style>\n\th3 {\n\t\tfont-weight: 300;\n\t\tcolor: #707070;\n\t}\n\n\th4 {\n\t\tfont-weight: 400;\n\t}\n\n\t#modalBackground {\n        position: fixed;\n        width: 100vw;\n        height: 100vh;\n        top:0;\n        left:0;\n        background-color: rgba(242, 242, 242, 0.25);\n    }\n    \n    .menuItem a {\n        color: rgb(255,51,163);\n    }\n\n    .button {\n\t\tbackground-color: rgb(255,51,163);\n\t\tcolor: white;\n\t\ttext-align: center;\n\t\ttext-decoration: none;\n\t\theight: 40px;\n\t\tpadding: 0 10px;\n\t\tborder-radius: 3px;\n\t\tline-height: 40px;\n\t\tfont-family: lato, 'Segoe UI', 'Helvetica';\n\t\tfont-size: 14px;\n\t\tcursor:pointer;\n\t\t\n\t}\n\t\n\t#startedButton {\n\t\tfloat:right;\n        margin-right: 100px;\n\t}\n\t\n\t#nextButton {\n\t\twidth: 50px;\n\t\tmargin: 0 auto;\n\t}\n\n    #readyButton {\n        width: 70px;\n\t\tmargin: 0 auto;\n    }\n\t\n\t.child {\n\t\tvertical-align: center;\n\t}\n\n\t#tipModal {\n\t\twidth: 50vw;\n\t\theight: 80vh;\n\t\tposition: fixed;\n\t\ttop: 10vh;\n\t\tleft: 25vw;\n\t\tbackground-color: white;\n\t\tfont-family: lato, 'Segoe UI', 'Helvetica Neue';\n        overflow: hidden;\n\t}\n\t\n\t#modalClose {\n\t\tfloat:right;\n\t}\n\t\n\t#modalHeading {\n\t\ttext-align:center;\n\t\tclear:both;\n\t\tfont-weight: 300 !important;\n\t}\n\t\n\t.menuItem {\n\t\tposition: absolute;\n        width: 100%;\n        top: 83px;\n        bottom: 60px;\n        text-align: center;\n        padding: 0 50px;\n        overflow-y: scroll;\n\t}\n\n\t.gifImg {\n\t\twidth:67%;\n\t}\n\n\t.menuItem::-webkit-scrollbar {\n\t\tdisplay: none;\n\t}\n\n    #modalFooter {\n        position: absolute;\n        bottom:0;\n        width: 100%;\n        background-color: white;\n        padding: 10px;\n    }\n\t\n@media (max-width: 1200px) {\n    #startedButton {\n        margin-right: 100px;\n    }\n}\n\n@media (max-width: 992px) {\n    #startedButton {\n        margin-right: 50px;\n    }\n}\n\n@media (max-width: 767px) {\n\t#tipModal {\n\t\twidth: 100vw;\n\t\theight: 100%;\n\t\tposition: fixed;\n\t\ttop: 0vh;\n\t\tleft: 0vw;\n\t\tbackground-color: white;\n\t\tfont-family: lato, 'Segoe UI', 'Helvetica Neue';\n\t}\n\n\t.menuItem {\n        padding: 0 20px;\n\t}\n\n    #startedButton {\n        margin-right: 0px;\n    }\n\n\t.gifImg {\n\t\twidth:80%;\n\t}\n}\n</style>\n\n<div id=\"startedButton\" class=\"button\" onclick=\"toggle()\">\n\t<div id=\"child\">Click Here to Get Started</div>\n</div>\n<div id=\"modalBackground\" style=\"display:none\">\n<div id=\"tipModal\">\n\t<div id=\"modalClose\" onclick=\"toggle()\">\n\t\t<span class=\"lt-close-btn\"><svg class=\"lt-close-icon svg-button\"><line class=\"close-button-line-1\" x1=\"5\" y1=\"5\" x2=\"35\" y2=\"35\" stroke-width=\"2\"></line><line class=\"close-button-line-2\" x1=\"5\" y1=\"35\" x2=\"35\" y2=\"5\" stroke-width=\"2\"></line></svg></span>\n\t</div>\n\t<div id=\"modalHeading\">\n\t\t<h2 style=\"font-weight:300\">Getting Started</h2>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu1\">\n\t\t<h3>1. Create a Space</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/create_space.gif\"/>\n\t\t<h4>Put all your awesome in one place</h4>\n\t\t<p>A space is a collection of related pages and content, along with control over who can access it</p>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu2\" style=\"display:none\">\n\t\t<h3>2. Create Your Pages</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/create_page.gif\"/>\n\t\t<h4>Design beautiful pages in minutes</h4>\n\t\t<p>The easy drag and drop canvas turns your imagination into your creations</p>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu3\" style=\"display:none\">\n\t\t<h3>3. Invite Others</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/invite_user.gif\"/>\n\t\t<h4>Get everyone on the same page</h4>\n\t\t<p>LiveTiles will help you get organized, but working together will make your team into superheroes</p>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu4\" style=\"display:none\">\n\t\t<h3>4. Get Designing Now!</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/edit_page.gif\"/>\n\t\t<h4>Just go ahead and click \"Ready!\" to start creating awesomeness</h4>\n\t\t<p>Would you like to know more? Find in-depth information in our knowledge base at <a href=\"http://support.livetiles.nyc/support/solutions/6000135694\" target=\"_blank\">support.livetiles.nyc</a></p>\n\t</div>\n\t<div id=\"modalFooter\">\n\t\t<div id=\"nextButton\" class=\"button\" onclick=\"next()\">\n\t\t\t<div class=\"child\">Next</div>\n\t\t</div>\n        <div id=\"readyButton\" class=\"button lt-code-snippet-create-page-button\" style=\"display:none\">\n            <div class=\"child\">Ready to Create!</div>\n        </div>\n\t</div>\n</div>\n</div>\n<script>\n    $('.lt-code-snippet-create-page-button').click(function() {\n        require(['Azure/modules/UI'], function(UI) {\n            UI.openCreatePageDialog();\n        });\n    });\n\n    var one = document.getElementById(\"menu1\");\n    var two = document.getElementById(\"menu2\");\n    var three = document.getElementById(\"menu3\");\n    var four = document.getElementById(\"menu4\");\n    var nb = document.getElementById(\"nextButton\");\n    var rb = document.getElementById(\"readyButton\");\n\n\n\tfunction toggle(){\n\t\t\n\t\tvar el = document.getElementById(\"modalBackground\");\n\t\t\n\t\tif ( el.style.display != 'none' ) {\n\n\t\t\tel.style.display = 'none';\n\n            one.style.display = '';\n            two.style.display = 'none';\n            three.style.display = 'none';\n            four.style.display = 'none';\n\n            nb.style.display = '';\n            rb.style.display = 'none';\n\n\t\t}\n\n\t\telse {\n\n\t\t\tel.style.display = '';\n\n\t\t}\n\t}\n\n    function next() {\n        \n\n        if ( one.style.display != 'none' ) {\n\n\t\t\tone.style.display = 'none';\n            two.style.display = '';\n\n\t\t} else {\n            if ( two.style.display != 'none' ) {\n\n\t\t\ttwo.style.display = 'none';\n            three.style.display = '';\n\n\t\t    } else {\n                if ( three.style.display != 'none' ) {\n\n\t\t\t    three.style.display = 'none';\n                four.style.display = '';\n\n                nb.style.display = 'none';\n                rb.style.display = '';\n\n\t\t        } else {\n                    if ( four.style.display != 'none' ) {\n\n\t\t\t        four.style.display = 'none';\n                    one.style.display = '';\n\n                    nb.style.display = '';\n                    rb.style.display = 'none';\n\n\t\t        }\n        }\n        }\n        }\n        \n        \n    }\n</script>";

        public const string WithoutScript = "<style>\n\th3 {\n\t\tfont-weight: 300;\n\t\tcolor: #707070;\n\t}\n\n\th4 {\n\t\tfont-weight: 400;\n\t}\n\n\t#modalBackground {\n        position: fixed;\n        width: 100vw;\n        height: 100vh;\n        top:0;\n        left:0;\n        background-color: rgba(242, 242, 242, 0.25);\n    }\n    \n    .menuItem a {\n        color: rgb(255,51,163);\n    }\n\n    .button {\n\t\tbackground-color: rgb(255,51,163);\n\t\tcolor: white;\n\t\ttext-align: center;\n\t\ttext-decoration: none;\n\t\theight: 40px;\n\t\tpadding: 0 10px;\n\t\tborder-radius: 3px;\n\t\tline-height: 40px;\n\t\tfont-family: lato, 'Segoe UI', 'Helvetica';\n\t\tfont-size: 14px;\n\t\tcursor:pointer;\n\t\t\n\t}\n\t\n\t#startedButton {\n\t\tfloat:right;\n        margin-right: 100px;\n\t}\n\t\n\t#nextButton {\n\t\twidth: 50px;\n\t\tmargin: 0 auto;\n\t}\n\n    #readyButton {\n        width: 70px;\n\t\tmargin: 0 auto;\n    }\n\t\n\t.child {\n\t\tvertical-align: center;\n\t}\n\n\t#tipModal {\n\t\twidth: 50vw;\n\t\theight: 80vh;\n\t\tposition: fixed;\n\t\ttop: 10vh;\n\t\tleft: 25vw;\n\t\tbackground-color: white;\n\t\tfont-family: lato, 'Segoe UI', 'Helvetica Neue';\n        overflow: hidden;\n\t}\n\t\n\t#modalClose {\n\t\tfloat:right;\n\t}\n\t\n\t#modalHeading {\n\t\ttext-align:center;\n\t\tclear:both;\n\t\tfont-weight: 300 !important;\n\t}\n\t\n\t.menuItem {\n\t\tposition: absolute;\n        width: 100%;\n        top: 83px;\n        bottom: 60px;\n        text-align: center;\n        padding: 0 50px;\n        overflow-y: scroll;\n\t}\n\n\t.gifImg {\n\t\twidth:67%;\n\t}\n\n\t.menuItem::-webkit-scrollbar {\n\t\tdisplay: none;\n\t}\n\n    #modalFooter {\n        position: absolute;\n        bottom:0;\n        width: 100%;\n        background-color: white;\n        padding: 10px;\n    }\n\t\n@media (max-width: 1200px) {\n    #startedButton {\n        margin-right: 100px;\n    }\n}\n\n@media (max-width: 992px) {\n    #startedButton {\n        margin-right: 50px;\n    }\n}\n\n@media (max-width: 767px) {\n\t#tipModal {\n\t\twidth: 100vw;\n\t\theight: 100%;\n\t\tposition: fixed;\n\t\ttop: 0vh;\n\t\tleft: 0vw;\n\t\tbackground-color: white;\n\t\tfont-family: lato, 'Segoe UI', 'Helvetica Neue';\n\t}\n\n\t.menuItem {\n        padding: 0 20px;\n\t}\n\n    #startedButton {\n        margin-right: 0px;\n    }\n\n\t.gifImg {\n\t\twidth:80%;\n\t}\n}\n</style>\n\n<div id=\"startedButton\" class=\"button\" onclick=\"toggle()\">\n\t<div id=\"child\">Click Here to Get Started</div>\n</div>\n<div id=\"modalBackground\" style=\"display:none\">\n<div id=\"tipModal\">\n\t<div id=\"modalClose\" onclick=\"toggle()\">\n\t\t<span class=\"lt-close-btn\"><svg class=\"lt-close-icon svg-button\"><line class=\"close-button-line-1\" x1=\"5\" y1=\"5\" x2=\"35\" y2=\"35\" stroke-width=\"2\"></line><line class=\"close-button-line-2\" x1=\"5\" y1=\"35\" x2=\"35\" y2=\"5\" stroke-width=\"2\"></line></svg></span>\n\t</div>\n\t<div id=\"modalHeading\">\n\t\t<h2 style=\"font-weight:300\">Getting Started</h2>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu1\">\n\t\t<h3>1. Create a Space</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/create_space.gif\"/>\n\t\t<h4>Put all your awesome in one place</h4>\n\t\t<p>A space is a collection of related pages and content, along with control over who can access it</p>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu2\" style=\"display:none\">\n\t\t<h3>2. Create Your Pages</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/create_page.gif\"/>\n\t\t<h4>Design beautiful pages in minutes</h4>\n\t\t<p>The easy drag and drop canvas turns your imagination into your creations</p>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu3\" style=\"display:none\">\n\t\t<h3>3. Invite Others</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/invite_user.gif\"/>\n\t\t<h4>Get everyone on the same page</h4>\n\t\t<p>LiveTiles will help you get organized, but working together will make your team into superheroes</p>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu4\" style=\"display:none\">\n\t\t<h3>4. Get Designing Now!</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/edit_page.gif\"/>\n\t\t<h4>Just go ahead and click \"Ready!\" to start creating awesomeness</h4>\n\t\t<p>Would you like to know more? Find in-depth information in our knowledge base at <a href=\"http://support.livetiles.nyc/support/solutions/6000135694\" target=\"_blank\">support.livetiles.nyc</a></p>\n\t</div>\n\t<div id=\"modalFooter\">\n\t\t<div id=\"nextButton\" class=\"button\" onclick=\"next()\">\n\t\t\t<div class=\"child\">Next</div>\n\t\t</div>\n        <div id=\"readyButton\" class=\"button lt-code-snippet-create-page-button\" style=\"display:none\">\n            <div class=\"child\">Ready to Create!</div>\n        </div>\n\t</div>\n</div>\n</div>\n";

        public const string WithoutStyle = "\n\n<div id=\"startedButton\" class=\"button\" onclick=\"toggle()\">\n\t<div id=\"child\">Click Here to Get Started</div>\n</div>\n<div id=\"modalBackground\" style=\"display:none\">\n<div id=\"tipModal\">\n\t<div id=\"modalClose\" onclick=\"toggle()\">\n\t\t<span class=\"lt-close-btn\"><svg class=\"lt-close-icon svg-button\"><line class=\"close-button-line-1\" x1=\"5\" y1=\"5\" x2=\"35\" y2=\"35\" stroke-width=\"2\"></line><line class=\"close-button-line-2\" x1=\"5\" y1=\"35\" x2=\"35\" y2=\"5\" stroke-width=\"2\"></line></svg></span>\n\t</div>\n\t<div id=\"modalHeading\">\n\t\t<h2 style=\"font-weight:300\">Getting Started</h2>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu1\">\n\t\t<h3>1. Create a Space</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/create_space.gif\"/>\n\t\t<h4>Put all your awesome in one place</h4>\n\t\t<p>A space is a collection of related pages and content, along with control over who can access it</p>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu2\" style=\"display:none\">\n\t\t<h3>2. Create Your Pages</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/create_page.gif\"/>\n\t\t<h4>Design beautiful pages in minutes</h4>\n\t\t<p>The easy drag and drop canvas turns your imagination into your creations</p>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu3\" style=\"display:none\">\n\t\t<h3>3. Invite Others</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/invite_user.gif\"/>\n\t\t<h4>Get everyone on the same page</h4>\n\t\t<p>LiveTiles will help you get organized, but working together will make your team into superheroes</p>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu4\" style=\"display:none\">\n\t\t<h3>4. Get Designing Now!</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/edit_page.gif\"/>\n\t\t<h4>Just go ahead and click \"Ready!\" to start creating awesomeness</h4>\n\t\t<p>Would you like to know more? Find in-depth information in our knowledge base at <a href=\"http://support.livetiles.nyc/support/solutions/6000135694\" target=\"_blank\">support.livetiles.nyc</a></p>\n\t</div>\n\t<div id=\"modalFooter\">\n\t\t<div id=\"nextButton\" class=\"button\" onclick=\"next()\">\n\t\t\t<div class=\"child\">Next</div>\n\t\t</div>\n        <div id=\"readyButton\" class=\"button lt-code-snippet-create-page-button\" style=\"display:none\">\n            <div class=\"child\">Ready to Create!</div>\n        </div>\n\t</div>\n</div>\n</div>\n<script>\n    $('.lt-code-snippet-create-page-button').click(function() {\n        require(['Azure/modules/UI'], function(UI) {\n            UI.openCreatePageDialog();\n        });\n    });\n\n    var one = document.getElementById(\"menu1\");\n    var two = document.getElementById(\"menu2\");\n    var three = document.getElementById(\"menu3\");\n    var four = document.getElementById(\"menu4\");\n    var nb = document.getElementById(\"nextButton\");\n    var rb = document.getElementById(\"readyButton\");\n\n\n\tfunction toggle(){\n\t\t\n\t\tvar el = document.getElementById(\"modalBackground\");\n\t\t\n\t\tif ( el.style.display != 'none' ) {\n\n\t\t\tel.style.display = 'none';\n\n            one.style.display = '';\n            two.style.display = 'none';\n            three.style.display = 'none';\n            four.style.display = 'none';\n\n            nb.style.display = '';\n            rb.style.display = 'none';\n\n\t\t}\n\n\t\telse {\n\n\t\t\tel.style.display = '';\n\n\t\t}\n\t}\n\n    function next() {\n        \n\n        if ( one.style.display != 'none' ) {\n\n\t\t\tone.style.display = 'none';\n            two.style.display = '';\n\n\t\t} else {\n            if ( two.style.display != 'none' ) {\n\n\t\t\ttwo.style.display = 'none';\n            three.style.display = '';\n\n\t\t    } else {\n                if ( three.style.display != 'none' ) {\n\n\t\t\t    three.style.display = 'none';\n                four.style.display = '';\n\n                nb.style.display = 'none';\n                rb.style.display = '';\n\n\t\t        } else {\n                    if ( four.style.display != 'none' ) {\n\n\t\t\t        four.style.display = 'none';\n                    one.style.display = '';\n\n                    nb.style.display = '';\n                    rb.style.display = 'none';\n\n\t\t        }\n        }\n        }\n        }\n        \n        \n    }\n</script>";

        public const string WithoutScriptOrStyle = "\n\n<div id=\"startedButton\" class=\"button\" onclick=\"toggle()\">\n\t<div id=\"child\">Click Here to Get Started</div>\n</div>\n<div id=\"modalBackground\" style=\"display:none\">\n<div id=\"tipModal\">\n\t<div id=\"modalClose\" onclick=\"toggle()\">\n\t\t<span class=\"lt-close-btn\"><svg class=\"lt-close-icon svg-button\"><line class=\"close-button-line-1\" x1=\"5\" y1=\"5\" x2=\"35\" y2=\"35\" stroke-width=\"2\"></line><line class=\"close-button-line-2\" x1=\"5\" y1=\"35\" x2=\"35\" y2=\"5\" stroke-width=\"2\"></line></svg></span>\n\t</div>\n\t<div id=\"modalHeading\">\n\t\t<h2 style=\"font-weight:300\">Getting Started</h2>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu1\">\n\t\t<h3>1. Create a Space</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/create_space.gif\"/>\n\t\t<h4>Put all your awesome in one place</h4>\n\t\t<p>A space is a collection of related pages and content, along with control over who can access it</p>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu2\" style=\"display:none\">\n\t\t<h3>2. Create Your Pages</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/create_page.gif\"/>\n\t\t<h4>Design beautiful pages in minutes</h4>\n\t\t<p>The easy drag and drop canvas turns your imagination into your creations</p>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu3\" style=\"display:none\">\n\t\t<h3>3. Invite Others</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/invite_user.gif\"/>\n\t\t<h4>Get everyone on the same page</h4>\n\t\t<p>LiveTiles will help you get organized, but working together will make your team into superheroes</p>\n\t</div>\n\t<div class=\"menuItem\" id=\"menu4\" style=\"display:none\">\n\t\t<h3>4. Get Designing Now!</h3>\n\t\t<img class=\"gifImg\" width=\"275px\" src=\"//ltc-teams-tenant.azureedge.net/Demo/edit_page.gif\"/>\n\t\t<h4>Just go ahead and click \"Ready!\" to start creating awesomeness</h4>\n\t\t<p>Would you like to know more? Find in-depth information in our knowledge base at <a href=\"http://support.livetiles.nyc/support/solutions/6000135694\" target=\"_blank\">support.livetiles.nyc</a></p>\n\t</div>\n\t<div id=\"modalFooter\">\n\t\t<div id=\"nextButton\" class=\"button\" onclick=\"next()\">\n\t\t\t<div class=\"child\">Next</div>\n\t\t</div>\n        <div id=\"readyButton\" class=\"button lt-code-snippet-create-page-button\" style=\"display:none\">\n            <div class=\"child\">Ready to Create!</div>\n        </div>\n\t</div>\n</div>\n</div>\n";
    }
}

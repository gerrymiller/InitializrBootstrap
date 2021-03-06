Update 2 - 2013-03-17 (vcardins)
-------------------------------------------------------------------------
- Added MvcSiteMap for navigation
- Added an error handler system with fancy custom view
- Redesigned Global.asax for better maintenance by splitting it into partial classes under Application folder 
- Minor fixes 

Update 1 - 2013-03-17 (vcardins)
-------------------------------------------------------------------------

- Added latest InitializrBootstrap version, includes
  - jQuery 1.9.1
  - Twitter Bootstrap 2.3.0
  - Modernizr 2.6.2
- Added FontAwesome
- Css files replaced by Less 
- Added RequestReduce framework for js and css compression
- Added a bootstrap modal window partial view

Obs: it is needed to install some packages:
a. Install-Package Newtonsoft.Json
b. Install-Package Microsoft.AspNet.Web.Optimization
c. Install-Package RequestReduce.SassLessCoffee

..

INTRODUCTION

Hello and welcome to the MVC4 version of Initializr Bootstrap.  Bootstrap is
a "Sleek, intuitive, and powerful front-end framework for faster and easier
web development," built by some geniuses at Twitter.

I created this project because I love Bootstrap, but there was no easy
way to integrate its coolness into Visual Studio and MVC4.

This Visual Studio 2012 project contains the complete Bootstrap code
as an MVC4 project.

LEGAL

This project is copyrighted open-source software that is released under the Apache
License, version 2.0.  For details on the license, see the LICENSE file.

SYSTEM REQUIREMENTS

This project requires Microsoft Visual Studio 2012 running on Microsoft Windows.

INSTALLATION

It's pretty easy - just open the InitializrBootstrap.csproj file, or add it into an
existing Visual Studio solution.

GOING FURTHER

To add your own stuff into the project, please note just a few things:

* For more details on some of the Bootstrap goodness check out that
project's home page at http://twitter.github.com/bootstrap/.  

* To add your own CSS, modify *only* Content/author.css.

* To modify the base view template, make your changes to Views/Shared/_Layout.cshtml.
You can change the header at Views/Shared/_Header.cshtml, and the footer at
Views/Shared/_Footer.cshtml.

* To add custom Javascript, modify Scripts/main.js.

* To add jquery plugins, modify Scripts/plugins.js.

* You can add a "PreScripts" section to your views for code that must execute BEFORE
other Javascript libraries are loaded (e.g., jquery).  Note that the modernizr
library is always loaded before anything else.

* You can add a "PostScripts" section for code that must execute AFTER other
Javascript libraries are loaded.

* Obviously, you can customize 404.html for your own 404 error page.

* Finally, if you want Google Analytics on your site, uncomment the Google Analytics
code in Views/Share/_Layout.cshtml and change UA-XXXXX-X to your Google Analytics
account number.

That's it!  Have fun, fork away, and ping me with questions if you need further help.

AUTHOR

Gerry Miller (gerry@gerrymiller.com)
Muse Holdings, LLC
Royal Oak, Michigan, USA
http://www.gerrymiller.com


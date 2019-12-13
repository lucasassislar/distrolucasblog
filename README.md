# DistroLucas.com
PERSONAL RULES:
- Nothing on the site should use non-personal source code
- Optimization is the highest priority
- Maybe? Make this be backwards-compatible (IE6)

This is my personal safe haven for re-inventing the wheel.

TO-DO:
- GZip support
- Minify CSS and JS support
- Dynamic CSS (should I just use SASS for this?)
- Dynamic points to what I''ll be doing - future streams/whatever
- Template system (HTML being re-used already)

DONE:
- Paging system (index page should have everything needed to render the entire website, then later use small requests to get content)
    - The URL is changed everytime you click a page, so your history is correctly built
    - Actually using the history is not 100% (for some reason the quotes page deletes all history before it always)
- Multi-language support through cookies
- Paging system on the server (currently I have to create a Route for each page, even though they're all the same)
    - Routing system automatically passes parameters to the Routes functions.

LEARNED SO FAR:
- JSON takes more space than just lines of text
- PNGs with compression can actually be lighter than JPEGs on low color count images
- Having all the content on the index page makes the loading of sub-pages insanely fast

EXTERNAL TOOLS ALLOWED:
- Anything I can't possibly develop in a timely manner, so:
    - Visual Studio Code
    - NGinx for HTTPS (one day might rewrite my server to support HTTPS, but NGINX would just plainly be more secure)
    - Bit.ly (no money to buy 3-letter domain name + free data without selling my soul to Google)

TOOLS USED:
- Visual Studio Code
- HTTPS by Certbot
- Reverse Proxy/HTTPS handling by NGinx
- Dynamic JS by NucleusJS: https://github.com/lucasassislar/nucleusjs
- Server by Nucleus.Gaming: https://github.com/lucasassislar/nucleusgaming
    - Initial HTTP server code by David Jeske
    - Additional attributes for Route Management and listing more akin to ASP.NET/Express
    - No caching for pages currently
	- .NET Core 3 on Ubuntu 18

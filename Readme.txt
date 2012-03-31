Usage
This tool performs simple searches using the Twitter API. Simply type search terms into the search box and click 'Search'. The results will be placed into the grid below. Results can be exported to a .csv file using the 'export' button.

System Requirements
Since this is a .NET app, usage is limited to Windows operating systems. The solution files were created using Visual Studio 2010 (but is .net 3.0 compatible). If you are on a Mac or are running linux, you could also run this using Mono. 

Limitations
The twitter API only allows you to pull back 100 results at a time. To get more results, incrment the page and click 'go to page'. Furthermore, the Twitter API only allows you to make up to 250 queries per hour. So if it stops working, do something else for a while and then come back to it later. For additional limitations, see this page. 
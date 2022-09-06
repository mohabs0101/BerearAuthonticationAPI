# BerearAuthonticationAPI
 how its work
1-creat asp.net web .net framework app +mvc and api +individual authontication
2-add ado data model +remove https from solution properties and keep only http
3-add api controller 
4-create method return a table from ado db model we created any table u want +dont forget to add using 
5-create instance of class that inhret from dbcontex class 
6-return a table
7-run the app and call the api 
8-now start applying the auth
9-add register html page that will call post request to register class +add css & jq 
10-after adding a register we can find the data in "solution app data"but u shold show hidden solution files 
11-change path of database from local to sql server database Edite on web config con string 
12-add loging page
13-add dashboard page that show data
*register page will post to register ,login page will post to token and retrive token save in browser storage ad pass it to dashboard to show data
14-add cors access
15-the problem i faces is how to pass token in login by httpclient

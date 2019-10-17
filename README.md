# Desktop application for travel agency

<p>This application was made for an employee in a travel agency for daily tasks such as records of offers, clients, contracts, hotels, tourist guides and payments.</p>

<p>Application is developed in a Microsoft Visual Studio IDE using the C# programming language, while for data storage is used SQL database.</p>

<h2>Setting up the database</h2>
	<h3>Local database</h3>
<p>By default, location of local database is "c:\Users\USER_NAME\Documetns\Travel Ageny\Database". You need to download database files (<a href="https://github.com/VojislavD/test/files/3728069/Database.files.zip" target="_blank">download here</a>) and place them on that location.<br/>
If you want to place local database at some other location, you need to make changes in file "DatabaseConnection.cs". On line 14 for value of variable "path" write location where you place database files.</p>

<b>Example:</b> string path = @"d:\MyLocalDB\"  

<img src="https://user-images.githubusercontent.com/23532087/66816317-2fc39800-ef3a-11e9-8c38-722b4f1bea9b.png" width="700" height="200" />

<h3>Database on the server</h3>
<p>If you want to place the database on a server, in the DatabaseConnection.cs file you need to comment out part of the code for local database (lines 14,15,16) and to uncomment line 20. In line 20 where is writen "YOUR_SERVER_NAME" you have to write name of your server.</p>

<img src="https://user-images.githubusercontent.com/23532087/66816261-1884aa80-ef3a-11e9-9bc9-c8a96ffa0f5b.png" width="700" height="200" />

<h2>Logging in</h2>
<p>Once the application is lunched, logging in is required to use it. For testing purposes, you can use the user with the email address "marko@gmail.com" and password "pass", while for administration section for email address you can use "admin" and for the password also "admin".</p>

<h2>Screenshots of application</h2>

<img src="https://user-images.githubusercontent.com/23532087/66809298-5deeab00-ef2d-11e9-843a-6225b4b5f86e.png" width="550" height="300" />
<img src="https://user-images.githubusercontent.com/23532087/66809339-78c11f80-ef2d-11e9-8331-bc0294e9892e.png" width="550" height="300" />
<img src="https://user-images.githubusercontent.com/23532087/66809728-3c41f380-ef2e-11e9-8e3b-2fa1c5fe3730.png" width="550" height="300" />
<img src="https://user-images.githubusercontent.com/23532087/66809765-4bc13c80-ef2e-11e9-8441-42d5f35f5020.png" width="550" height="300" />
<img src="https://user-images.githubusercontent.com/23532087/66809780-567bd180-ef2e-11e9-94ce-956144ce4910.png" width="550" height="300" />
<img src="https://user-images.githubusercontent.com/23532087/66809813-63002a00-ef2e-11e9-9d19-76a004120300.png" width="550" height="300" />
<img src="https://user-images.githubusercontent.com/23532087/66810234-2123b380-ef2f-11e9-9bdf-a4caac06c08b.png" width="550" height="300" />
<img src="https://user-images.githubusercontent.com/23532087/66809850-701d1900-ef2e-11e9-9ba1-bb47c107ba31.png" width="550" height="300" />
<img src="https://user-images.githubusercontent.com/23532087/66809878-7dd29e80-ef2e-11e9-8e06-a55a1ff37b01.png" width="550" height="300" />
<img src="https://user-images.githubusercontent.com/23532087/66809949-98a51300-ef2e-11e9-89f6-bfe79109f6c6.png" width="550" height="650" />
<img src="https://user-images.githubusercontent.com/23532087/66809969-a490d500-ef2e-11e9-91a6-f2a3142c8c4e.png" width="550" height="300" />
<img src="https://user-images.githubusercontent.com/23532087/66810017-bb372c00-ef2e-11e9-9e46-65f2cfadcd5c.png" width="550" height="300" />
<img src="https://user-images.githubusercontent.com/23532087/66810123-e3268f80-ef2e-11e9-82cf-d855729bd90d.png" width="550" height="300" />
<img src="https://user-images.githubusercontent.com/23532087/66810158-f3d70580-ef2e-11e9-830b-1dcbe356fedc.png" width="550" height="300" />
<img src="https://user-images.githubusercontent.com/23532087/66810191-05201200-ef2f-11e9-82f0-84068d8d9290.png" width="550" height="300" />

# CyberEcommerceUI

Upgraded to .net 7.0


## How to run it
1. Extract the file

2. open `appsettings.json` file and update connection string 
   "ConnectionStrings": {
  "conn": "data source=your_server_name;initial catalog=MovieStoreMvc; integrated security=true;encrypt=false"
   }
   
3. Delete `Migrations` folder
4. Open Tools > Package Manager > Package manager console
5. Run these 2 commands
    ```
     (i) add-migration init
     (ii) update-database
     ````
6. Now you can run this project

## How to register as admin and login??

7. Open the `Program.cs` file , you will find these commented lines
   
   ```//using(var scope = app.Services.CreateScope())
   //{
   //    await DbSeeder.SeedDefaultData(scope.ServiceProvider);
   //} ```

  Uncomment these line and run the project. `Now stop the project and comment these lines again.`


   
8. Open sql database and insert this data into the Genre table creted by the program
Steps
a. Open ssms and connect to Database created
b. Right click on Genre Table form database CyberEcommerce
c. Select Edit Top 200 Rows and enter the following data

     1. GenreName=Antivirus, GenreId=Null  (Press Enter)
     2. GenreName=VPN, GenreId=Null  (Press Enter)
     3. GenreName=Firewall, GenreId=Null  (Press Enter)


9. Open New Query in the ssms and  execute the following command

USE [CyberEcommerce]

INSERT INTO [dbo].[OrderStatus]
           ([StatusId]
           ,[StatusName])
     VALUES
           ('1'
           ,'Pending')


INSERT INTO [dbo].[Products]
           ([ProductName]
           ,[Price]
           ,[Image]
           ,[GenreId]
           ,[Description])
     VALUES
           ('Salafi Antivirus Software'
           ,'200'
           ,'1.jpg'
           ,'1'
           ,'Protect your digital haven with our cutting-edge antivirus solutions! Safeguard your devices from malicious threats, viruses, and cyber attacks. Browse our selection of top-tier antivirus software to fortify your online defenses and ensure a secure digital experience.')


INSERT INTO [dbo].[Products]
           ([ProductName]
           ,[Price]
           ,[Image]
           ,[GenreId]
           ,[Description])
     VALUES
           ('Salafi Premium VPN '
           ,'2500'
           ,'2.png'
           ,'2'
           ,'Navigate the online realm securely with our premium VPN services! Unlock a world of privacy as you encrypt your internet connection, shielding your data from prying eyes. Explore our range of Virtual Private Network solutions to surf the web anonymously and securely')


INSERT INTO [dbo].[Products]
           ([ProductName]
           ,[Price]
           ,[Image]
           ,[GenreId]
           ,[Description])
     VALUES
           ('BamPro Firewall Fortress'
           ,'3000'
           ,'1.jpg'
           ,'3'
           ,'Build an impregnable defense for your digital fortress! Discover our state-of-the-art firewall systems, whether in hardware or software form. Safeguard your network from unauthorized access and cyber threats, ensuring a robust shield against potential breaches.')


INSERT INTO [dbo].[Products]
           ([ProductName]
           ,[Price]
           ,[Image]
           ,[GenreId]
           ,[Description])
     VALUES
           ('Mard PassGuard Vault'
           ,'2000'
           ,'2.png'
           ,'3'
           ,'Elevate your password security game with PassGuard Vault! Bid farewell to password-related worries as you explore our advanced password management solutions. Protect your accounts with strong, unique passwords effortlessly, enhancing your online security posture.')


10. Now run the project and create new account 
                      OR
click on login and login with these credentials.
   `username:suallah87@gmail.com, password: Admin@123`


 
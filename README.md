# CMS
Clinic Management System


//Author @Rayhana
Added stored procedures in database:
1- GetAllUsers
2- RemoveUser
3- AddUser
4- EditUser
5-GetPriv
//Here are the stored procedures, just copy and paste them in you sql query tab and excute.


USE [ClinicManagementSoftware]
GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 04/21/2017 01:33:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[AddUser]
@StaffID int,
@StaffName varchar(60),
@StaffPass varchar(50),
@StaffPosition char(1),
@StaffPhone varchar(50),
@Salary int
AS 
BEGIN
insert into Staff values(@StaffID,@StaffName,@StaffPass,@StaffPosition,@StaffPhone,@Salary)
END

GO
Create Procedure [dbo].[EditUser]
@StaffID int,
@StaffName varchar(60),
@StaffPass varchar(50),
@Priv char(1),
@Phone char(12)
AS
BEGIN
UPDATE Staff
SET StaffName=@StaffName,StaffPass=@StaffPass,StaffPosition=@Priv,StaffPhone=@Phone
WHERE StaffID=@StaffID
END

GO
Create PROCEDURE [dbo].[GetAllUsers]
AS 
BEGIN
SELECT *
FROM Staff
END

GO
Create PROCEDURE [dbo].[GetPriv]
@StaffName varchar(60),
@StaffPass varchar(50)
AS 
BEGIN
SELECT StaffPosition
FROM Staff
WHERE StaffName = @StaffName and StaffPass = @StaffPass
END

GO
Create Procedure [dbo].[RemoveUser]
@StaffID int
AS
BEGIN
Delete From Staff
Where StaffID=@StaffID
END
----------------------------------------------------------------------------------------------------
And they were also added as functions in the DBManager class in c#
//Here they are, just copy and past them in your dbManager

public DataTable GetPriv(string UName, string Pass)
        {
            string StoredProcedureName = StoredProcedures.GetPriv;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@StaffName", UName);
            Parameters.Add("@StaffPass", Pass);

            return ExecuteReader(StoredProcedureName, Parameters);
        }

        public int AddUser(string Name, string password, int ID, string phone, char position )
        {
            string StoredProcedureName = StoredProcedures.AddUser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@StaffID", ID);
            Parameters.Add("@StaffName", Name);
            Parameters.Add("@StaffPass", password);
            Parameters.Add("@StaffPosition", position);
            Parameters.Add("@StaffPhone", phone);
            Parameters.Add("@Salary", 0);


            return ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetAllUsers()
        {
            string StoredProcedureName = StoredProcedures.GetAllUsers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return ExecuteReader(StoredProcedureName, Parameters);
        }

        public int EditUser(string Name, string password, int ID, string phone, char position)
        {
            string StoredProcedureName = StoredProcedures.EditUser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@StaffID", ID);
            Parameters.Add("@StaffName", Name);
            Parameters.Add("@StaffPass", password);
            Parameters.Add("@Priv", position);
            Parameters.Add("@Phone", phone);
            return ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int RemoveUser(int ID)
        {
            string StoredProcedureName = StoredProcedures.RemoveUser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@StaffID",ID);
            return ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        
        ///-------------------------------------------------------------------------------------------------------------




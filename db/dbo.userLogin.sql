CREATE TABLE [dbo].[userLogin]
(
	[userId] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [password] VARCHAR(50) NOT NULL, 
    [createdOn] DATETIME NULL, 
    [updatedOn] DATETIME NULL, 
    [updatedBy] VARCHAR(50) NULL, 
    [createdBy] VARCHAR(50) NULL, 
    [role] VARCHAR(50) NOT NULL
)

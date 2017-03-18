CREATE TABLE [dbo].[marks_details]
(
  [roll_number] NUMERIC,
  [subject_id] NUMERIC,
  [marks] NCHAR(10) NOT NULL, 
    [createdOn] DATETIME NULL, 
    [updatedOn] DATETIME NULL, 
    [createdBy] VARCHAR(50) NULL, 
    [updatedBy] VARCHAR(50) NULL, 
    PRIMARY KEY ([roll_number], [subject_id])
)


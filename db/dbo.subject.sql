CREATE TABLE [dbo].[marks_details]
(
  [roll_number] INT,
  [subject_id] INT,
  [marks] NCHAR(10) NOT NULL, 
    [createdOn] DATETIME NULL, 
    [updatedOn] DATETIME NULL, 
    [createdBy] VARCHAR(50) NULL, 
    [updatedBy] VARCHAR(50) NULL, 
    PRIMARY KEY ([roll_number], [subject_id]),
	FOREIGN KEY ([roll_number]) REFERENCES studentInfo(roll_number),
	FOREIGN KEY ([subject_id]) REFERENCES subjects(subject_id)
)


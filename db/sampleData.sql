INSERT INTO [dbo].[subjects] ([subject_id], [subjet_name], [sem], [tw_mark], [min_mark]) VALUES (1, 'ADT', 'SEM-6', 50, 20)

INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES (330, 66225, 'Pawar saurabh mahadev (vijaya)', '2014003262')


INSERT INTO [dbo].[userLogin] ([userId], [password], [createdOn], [updatedOn], [updatedBy], [createdBy], [role])
					 VALUES ('admin', 'root', NULL, NULL, NULL, NULL, 'Admin')

					 
					 INSERT INTO [dbo].[marks_details] ([roll_number], [subject_id], [marks], [createdOn], [updatedOn], [createdBy], [updatedBy]) 
                           VALUES (330, 1, 49, NULL, NULL, NULL, NULL)

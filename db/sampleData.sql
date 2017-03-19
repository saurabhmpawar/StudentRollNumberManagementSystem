INSERT INTO [dbo].[subjects] ([subject_id], [subjet_name], [sem], [tw_mark], [min_mark]) VALUES (1, 'ADT', 'SEM-6', 50, 20)

INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES (330, 66225, 'Pawar saurabh mahadev (vijaya)', '2014003262')


INSERT INTO [dbo].[userLogin] ([userId], [password], [createdOn], [updatedOn], [updatedBy], [createdBy], [role])
					 VALUES ('admin', 'root', NULL, NULL, NULL, NULL, 'Admin')

					 
					 INSERT INTO [dbo].[marks_details] ([roll_number], [subject_id], [marks], [createdOn], [updatedOn], [createdBy], [updatedBy]) 
                           VALUES (330, 1, 49, NULL, NULL, NULL, NULL)

						   
	"INSERT INTO userLogin (userId, password, role) VALUES (@Name, @password, @role)"
	
	
	select stu.roll_number ,stu.exam_seat_no,stu.prn_number,stu.name ,sub.subjet_name, m.marks from 
	marks_details m ,studentInfo stu ,subjects sub where m.roll_number = stu.roll_number and sub.subject_id =m.subject_id
	
	
	-- create view query
	CREATE VIEW [dbo].[ViewMarks]
	AS SELECT  stu.roll_number ,stu.exam_seat_no,stu.prn_number,stu.name ,sub.subjet_name, m.marks from 
	marks_details m ,studentInfo stu ,subjects sub where m.roll_number = stu.roll_number and sub.subject_id =m.subject_id ;
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
	
	
--Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudentMgt.mdf;Integrated Security=True


--- sample data

INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(301,50516  ,'Mahajan Hrishikesh Shivdas','2014003319');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(302,50517  ,'* Mali Bhagyashri Bhagvan ','2014003300');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(303,50518  ,'Mane Nikhil Bharat        ','2014003295');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(304,50519  ,'Mane Vaibhav Vilas        ','2014003299');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(305,50520  ,'Mithari Archit Nitin      ','2014003256');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(306,50521  ,'* Moholkar Aishwarya Mohan','2014003297');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(307,50522  ,'* NALAMWAR VAISHNAVI PRADI','2014003329');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(308,50523  ,'Nanavare Suraj Sanjay     ','2014003259');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(309,50524  ,'PATKY DEOVRAT VINAYAK     ','2014010612');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(310,50525  ,'* POWAR AISHWARYA MAHADEV ','2014010611');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(311,50526  ,'* Patil Aishwarya Dilip   ','2014003301');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(312,50527  ,'Patil Aniket Baburao      ','2014003219');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(313,50528  ,'* Patil Maithilee Jayram  ','2014003309');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(314,50529  ,'Pawar Saurabh Mahadev     ','2014003262');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(315,50530  ,'SANGOLE GANESH SANTRAM    ','2014003327');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(316,50531  ,'* SAPKAL SHAMAL RAVINDRA  ','2014003283');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(317,50532  ,'SHINDE RUSHIKESH RAJENDRA ','2014003281');
INSERT INTO [dbo].[studentInfo] ([roll_number], [exam_seat_no], [name], [prn_number]) VALUES(318,50533  ,'* SHINDE SAYALI ASHOK     ','2014003312');
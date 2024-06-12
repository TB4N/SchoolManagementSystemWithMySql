SELECT * FROM users
CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
)
INSERT users(username,password) VALUES('admin', 'admin1234')


SELECT * FROM students

CREATE TABLE students 
(
	id INT PRIMARY KEY IDENTITY(1,1),
	student_id VARCHAR(MAX) NULL,
	student_fname VARCHAR(MAX) NULL,
	student_mname VARCHAR(MAX) NULL,
	student_lname VARCHAR(MAX) NULL,
	student_gender VARCHAR(MAX) NULL,
	student_CsYr VARCHAR(MAX) NULL,
	student_section VARCHAR(MAX) NULL,
	student_status VARCHAR(MAX) NULL,	
	student_address VARCHAR(MAX) NULL,
	student_image VARCHAR(MAX) NULL,
	date_insert Date NULL,
	date_update Date NULL,
	date_delete Date NULL,
)

SELECT * FROM professor

CREATE TABLE professor 
(
	id INT PRIMARY KEY IDENTITY(1,1),
	professor_id VARCHAR(MAX) NULL,
	professor_fname VARCHAR(MAX) NULL,
	professor_mname VARCHAR(MAX) NULL,
	professor_lname VARCHAR(MAX) NULL,
	professor_gender VARCHAR(MAX) NULL,
	professor_address VARCHAR(MAX) NULL,
	professor_subject VARCHAR(MAX) NULL,
	professor_image VARCHAR(MAX) NULL,
	professor_status VARCHAR(MAX) NULL,
	date_insert Date NULL,
	date_update Date NULL,
	date_delete Date NULL,
)
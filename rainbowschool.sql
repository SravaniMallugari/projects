create database school

use school

create table student(student_id int primary key,student_name varchar(25),student_class int check(student_class<=12))
create table subjects(subjects_id int primary key,subjects_name varchar(25))
create table class(class_roomno int primary key,class_strength int)

create index student_index on student(student_id,student_name,student_class)
create index subjects_index on subjects(subjects_id,subjects_name)
create index class_index on class(class_roomno,class_strength)

insert into student values(1,'amreen',12)
insert into student values(2,'gousia',11)
insert into student values(3,'jasmine',8)
insert into student values(4,'mounika',9)
insert into student values(5,'noora',10)
insert into student values(6,'vijitha',3)
insert into student values(7,'mohan',5)
insert into student values(8,'mahesh',7)
insert into student values(9,'sanju',2)
insert into student values(10,'sarath',1)


insert into subjects values(100,'telugu')
insert into subjects values(101,'sanskrit')
insert into subjects values(102,'english')
insert into subjects values(103,'maths')
insert into subjects values(104,'science')
insert into subjects values(105,'social')

insert into class values(01,45)
insert into class values(02,20)
insert into class values(03,34)
insert into class values(04,44)
insert into class values(05,49)
insert into class values(05,57)
insert into class values(07,39)
insert into class values(08,56)
insert into class values(09,44)
insert into class values(10,55)
insert into class values(11,60)
insert into class values(12,60)

select*from student
select*from subjects
select*from class
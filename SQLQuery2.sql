create database BookLibrary;
use BookLibrary;

create table Book
(b_Id int Not null primary key,
b_Name varchar (30) Not null,
b_Author varchar (20) Not null,
b_Pub varchar (25) Not null,
b_Pdate varchar (15) Not null,
b_quantity int Not null,
b_Price int Not null);



b_Name,b_Author,b_Pub,b_Pdate,b_quantity,b_Price
select * from Book;
truncate table Book;
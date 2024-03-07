-- start1
use master
drop database if exists Restaurace;
CREATE DATABASE Restaurace;
-- end1

USE Restaurace;

CREATE TABLE Category(
id int primary key identity(1,1),
[name] varchar(256) not null unique,
dph int not null check(dph > 0)
)

CREATE TABLE Product(
id int primary key identity(1,1),
code varchar(10) not null,
[name] varchar(512) not null,
price int not null check (price > 0),
category_id int foreign key references Category(id)
)

--insert into Category([name], dph) values('Polévky', 12);
--insert into Category([name], dph) values('Předkrmy', 12);
--insert into Product(code, [name], price, category_id) values('01', 'Miso polévka', 119, 1);
insert into Product(code, [name], price, category_id) values('11', 'Nem - Domácí závitky', 139, (select Category.id from Category where Category.name = 'Predkrmy'));

select * from Product
select Category.id from Category where Category.name = 'Predkrmy'
select Product.code, Product.name,Category.dph as 'DPH', Product.price from Product inner join Category on Product.category_id = Category.id
where Product.code = 11;
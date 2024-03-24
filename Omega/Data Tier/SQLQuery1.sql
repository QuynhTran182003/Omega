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

CREATE TABLE Tabl(
id int primary key identity(1,1),
number_table varchar(10) unique not null
)

CREATE TABLE Orders(
id int primary key identity(1,1),
table_id int foreign key references Tabl(id) not null,
dtime_order datetime not null
)

CREATE TABLE Item(
id int primary key identity(1,1),
product_id int foreign key references product(id),
order_id int foreign key references orders(id),
quantity int default 1 check(quantity>0)
)
--drop table Tabl
--drop table Item;
--drop table Orders;

--insert into Category([name], dph) values('Polévky', 12);
--insert into Category([name], dph) values('Předkrmy', 12);
--insert into Product(code, [name], price, category_id) values('01', 'Miso polévka', 119, 1);
INSERT INTO Tabl (number_table)
VALUES 
    ('1'),
    ('2'),
    ('3'),
    ('4'),
    ('5'),
    ('6'),
    ('7'),
    ('8'),
    ('9'),
    ('10'),
    ('11'),
    ('12'),
    ('13'),
    ('14');
insert into Product(code, [name], price, category_id) values('11', 'Nem - Domácí závitky', 139, (select Category.id from Category where Category.name = 'Predkrmy'));
insert into Orders(table_id, dtime_order) values ('1', GETDATE());

select * from Product
select * from Tabl order by CAST(number_table as int)
select Category.id from Category where Category.name = 'Predkrmy'
select Product.code, Product.name,Category.dph as 'DPH', Product.price from Product inner join Category on Product.category_id = Category.id
where Product.code = 11;

select Product.id, Product.code, Product.name,Category.dph as 'DPH', Product.price from Product inner join Category on Product.category_id = Category.id where Product.code = '10a';

select * from Orders where Orders.table_id = 9
select Orders.id, tabl.number_table, Orders.dtime_order from Orders inner join Tabl on Tabl.id = Orders.table_id
select * from Item
select Item.id, Product.code, Orders.id as OrderId, Item.quantity from Item 
                                                inner join Orders on Orders.id = Item.order_id 
                                                inner join Product on Product.id = Item.product_id 
                                                where Orders.id = 6
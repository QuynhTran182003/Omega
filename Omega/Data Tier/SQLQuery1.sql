-- start1
use master
drop database if exists Restaurace;
CREATE DATABASE Restaurace;
-- end1

begin transaction;
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
number_table varchar(10) unique not null,
[status] varchar(15) not null default 'volno' check([status] in ('volno', 'rezervovan'))
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

CREATE TABLE Bill(
id int primary key identity(1,1),
total_price int not null,
table_id int not null foreign key references Tabl(id),
paymentMethod varchar(10) not null check(paymentMethod in ('Kartou', 'Hotově')),
takeaway bit not null,
date_issue datetime not null default GETDATE()
)

CREATE TABLE ItemBill(
id int primary key identity(1,1),
product_id int foreign key references Product(id),
bill_id int foreign key references Bill(id),
quantity int default 1 check(quantity>0)
)

CREATE TABLE Users(
id int primary key identity(1,1),
username varchar(32) not null check(len(username) > 3),
pwd varchar(20) not null check(len(pwd) > 4),
[name] varchar(32) not null,
surname varchar(32) not null,
[role] varchar(10) not null check([role] in ('admin',  'pokladnik', 'kuchar'))
)

commit;

--drop table Tabl
--drop table Item;
--drop table Orders;

begin transaction;
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

insert into Category([name], dph) values('Polévky', 12);
insert into Category([name], dph) values('Saláty', 12);
insert into Category([name], dph) values('Předkrmy', 12);
insert into Category([name], dph) values('Vegan Maki', 12);
insert into Category([name], dph) values('Maki', 12);
insert into Category([name], dph) values('Nápoje bez příchutí', 12);
insert into Category([name], dph) values('Nápoje s příchutí', 21);
insert into Product(code, [name], price, category_id) values('01', 'Miso polévka', 119, 1);
insert into Product(code, [name], price, category_id) values('11', 'Nem - Domácí závitky', 139, (select Category.id from Category where Category.name = 'Předkrmy'));
insert into Product(code, [name], price, category_id) values('07', 'Edamame', 139, (select Category.id from Category where Category.name = 'Saláty'));
insert into Product(code, [name], price, category_id) values('201', 'Okurkové Maki', 139, (select Category.id from Category where Category.name = 'Vegan Maki'));
insert into Product(code, [name], price, category_id) values('213', 'Lososové Maki', 139, (select Category.id from Category where Category.name = 'Maki'));
insert into Product(code, [name], price, category_id) values('NB1', 'Neperlivá Voda 0.3l', 139, (select Category.id from Category where Category.name = 'Nápoje bez příchutí'));
insert into Product(code, [name], price, category_id) values('NS1', 'Coca-Cola 0.4l', 139, (select Category.id from Category where Category.name = 'Nápoje s příchutí'));
--insert into Orders(table_id, dtime_order) values ('1', GETDATE());
commit;


select * from Tabl order by CAST(number_table as int)
select Category.id from Category where Category.name = 'Predkrmy'
select Product.code, Product.name,Category.dph as 'DPH', Product.price from Product inner join Category on Product.category_id = Category.id
where Product.code = '11';

select Product.id, Product.code, Product.name,Category.dph as 'DPH', Product.price from Product inner join Category on Product.category_id = Category.id where Product.code = '10a';

select * from Orders where Orders.table_id = 9
select Orders.id, tabl.number_table, Orders.dtime_order from Orders inner join Tabl on Tabl.id = Orders.table_id
select * from Item
select Item.id, Product.code, Orders.id as OrderId, Item.quantity from Item 
                                                inner join Orders on Orders.id = Item.order_id 
                                                inner join Product on Product.id = Item.product_id 
                                                where Orders.id = 6

--delete from Orders
--delete from Item
select * from Product;
select * from Item;
select * from Orders;
select date_issue, id, total_price from Bill where date_issue like '2024-04-04';
select sum(total_price) from Bill ;
select sum(total_price) from Bill where Bill.paymentMethod = 'Kartou';
select sum(total_price) from Bill where Bill.paymentMethod = 'Hotově';
select * from ItemBill;
select * from Product join Category on Product.category_id = Category.id

--old script OrderDAO GetListItems
select Item.id, Product.code, Item.order_id, Item.quantity from Item
inner join Product on Item.product_id = Product.id 
where order_id IN (select id from Orders where Orders.table_id = (select id from Tabl where number_table = 11))

select sum(total_price) as sum from Bill where CONVERT(date, date_issue) = '2024-04-05' and Bill.paymentMethod = 'Hotově' 

select * from Orders;

go
CREATE TRIGGER insertOrder 
ON Orders
AFTER INSERT 
AS
BEGIN
    DECLARE @tabl_id as int;
    set @tabl_id = (SELECT table_id FROM inserted);
    UPDATE Tabl 
    SET Tabl.status = 'rezervovan'
    WHERE id = @tabl_id;
END;
go

go
CREATE TRIGGER deleteOrder 
ON Orders
AFTER DELETE 
AS
BEGIN
    DECLARE @tabl_id as int;
    set @tabl_id = (SELECT table_id FROM deleted);
    UPDATE Tabl 
    SET Tabl.status = 'volno'
    WHERE id = @tabl_id;
END;
go

select date_issue, id, total_price from Bill where CONVERT(date, date_issue) between '2024-04-01' and '2024-04-08'
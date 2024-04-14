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
ALTER TABLE Product
ADD CONSTRAINT UniqueConstraintName UNIQUE (code);

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
pwd varchar(256) not null check(len(pwd) > 4),
[name] varchar(32) not null,
surname varchar(32) not null,
[role] varchar(10) not null check([role] in ('admin',  'pokladnik', 'kuchar'))
)

commit;

--drop table Tabl
--drop table Item;
--drop table Orders;
--drop table Users;

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

insert into Users(username, pwd, [name], surname, [role]) values ('admin1', '8FAFC83EA8211FABFA5632563AD835D5C73905225A7C5B01A1B003B7CB7D6C39', 'ad', 'min', 'admin')

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

commit;

begin transaction;
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
commit;

--delete from Orders
--delete from Item
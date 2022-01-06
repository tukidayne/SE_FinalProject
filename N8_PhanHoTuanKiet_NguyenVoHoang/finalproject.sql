CREATE DATABASE stock ON PRIMARY 
	( NAME = 'DB_stock', 
	FILENAME = 'F:\DB_stock.mdf' , 
	SIZE = 4096KB ,
	MAXSIZE = UNLIMITED, 
	FILEGROWTH = 1024KB )
 LOG ON 
	( NAME = 'DB_stock_log', 
	FILENAME = 'F:\DB_stock_log.ldf' , 
	SIZE = 1024KB , 
	MAXSIZE = 2048KB , 
	FILEGROWTH = 10%)

CREATE TABLE dbo.Products
(
	Product_ID varchar(10) NOT NULL,
	Product_Name varchar(30) NOT NULL,
	Brand varchar(30),
	Price money NOT NULL,
	PRIMARY KEY (Product_ID)
)

CREATE TABLE dbo.GoodsReceived
(
	Import_ID varchar(10) NOT NULL,
	Product_ID varchar(10) NOT NULL,
	Quantity int NOT NULL,
	Import_date date,
	PRIMARY KEY (Import_ID),
	CONSTRAINT FK_PROID FOREIGN KEY (Product_ID) REFERENCES Products(Product_ID)
)

SELECT * FROM GoodsReceived

CREATE TABLE dbo.Agent
(
	Agent_ID varchar(10) NOT NULL,
	Agent_name varchar(50) NOT NULL,
	Agent_address varchar(50) NOT NULL,
	phone_num varchar(15) NOT NULL,
	PRIMARY KEY (Agent_ID)
)

INSERT INTO Agent VALUES ('A01','Flower shop','London','0123456789'),
							('A02','Luxury shop','New York','0113456789'),
							('A03','Royal shop','Mexico','0122456789'),
							('A04','Perfume shop','Vietnam','0123356789'),
							('A05','Chanel shop','Japan','0123446789')


CREATE TABLE dbo.Orders
(
	Order_ID varchar(10) NOT NULL,
	Agent_ID varchar(10) NOT NULL,
	Product_ID varchar(10) NOT NULL,
	Order_date date NOT NULL,
	Total_price money NOT NULL,
	PRIMARY KEY (Order_ID),
	CONSTRAINT FK_PRODUCTID FOREIGN KEY (Product_ID) REFERENCES Products(Product_ID),
	CONSTRAINT FK_AGENTID FOREIGN KEY (Agent_ID) REFERENCES Agent(Agent_ID)
)

INSERT INTO Orders VALUES ('O01','A01','P01','01-03-2022',1700),
							('O02','A02','P02','12-21-2021',2200),
							('O03','A03','P03','01-01-2022',1950),
							('O04','A04','P04','12-31-2021',3000),
							('O05','A05','P05','01-05-2022',7000)


CREATE TABLE dbo.DeliveryNote
(
	Delivery_ID varchar(10) NOT NULL,
	Order_ID varchar(10) NOT NULL,
	Delivery_date date,
	Order_status varchar(20),
	Payment_status varchar(10),
	PRIMARY KEY (Delivery_ID),
	CONSTRAINT FK_ORDERID FOREIGN KEY (Order_ID) REFERENCES Orders(Order_ID)
)


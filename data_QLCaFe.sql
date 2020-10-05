create database QLCaFe_Winform
go
use QLCaFe_Winform
go
create table ProductType
(
	IDType varchar(10) primary key,
	TypeName nvarchar(50),
	Size nvarchar(10)
)
go
create table Product
(
	IDProduct varchar(20) primary key,
	ProductName nvarchar(100),
	IDType varchar(10) FOREIGN KEY REFERENCES ProductType(IDType),
	Price int
)
go
create table Administrator(
	Username varchar(50) Primary key,
	Password varchar(20)
)

go
create table Employee(
	Username varchar(50) Primary key,
	Password varchar(20),
	NameEmp nvarchar(50),
	Gender nvarchar(10),
	Birthday varchar(20),
	Phone varchar(20),
	Email varchar(50),
	Address nvarchar(Max),
	Hinh varchar(50)
)
go
create table Orders(
	IDOrder varchar(20) Primary key,
	DateOrder varchar(20),
	TimeOrder varchar(20),
	UsernameEmp varchar(50) foreign key REFERENCES Employee(Username)
)

go
Create Table OrderDetails(
	IDOrder varchar(20) foreign key REFERENCES Orders(IDOrder),
	IDProduct varchar(20) foreign key REFERENCES Product(IDProduct),
	Quantity int,
	Constraint PK_OrderDetails Primary key (IDOrder,IDProduct)
)

-------------Thủ tục--------------------------
go
Create proc themLoaiSP
	@ma varchar(10),
	@ten nvarchar(50),
	@kichco nvarchar(10)
as
begin
	insert into ProductType values(@ma,@ten,@kichco)
end
go

Create proc suaLoaiSP
	
	@ten nvarchar(50),
	@kichco nvarchar(10),
	@ma varchar(10)
as
begin
	update ProductType set TypeName=@ten, Size=@kichco where IDType = @ma
end
go

Create proc xoaLoaiSP
	@ma varchar(10)
as
begin
	delete from ProductType where IDType=@ma
end
go

Create proc LayTenLoaiSP
as
begin
	select DISTINCT TypeName from ProductType
end
go

Create proc LayDanhSachProduct
as
begin
	select IDProduct as [Mã],ProductName as [Tên],Product.IDType as[Loại],Price as [Giá],Size as[Kích cỡ] 
	from Product join ProductType on Product.IDType = ProductType.IDType
end
go

Create proc TenLoaiSPTheoID
	@ma varchar(10)
as
begin
	select TypeName from ProductType where IDType=@ma
end

go

Create proc layIDLoaiSP
	@ten nvarchar(50),
	@kichco nvarchar(10)
as
begin
	select IDType from ProductType where TypeName = @ten and Size=@kichco
end

go
Create proc themSP
	@ma varchar(20),
	@ten nvarchar(100),
	@maloaisp varchar(10),
	@gia int
as
begin
	insert into Product values(@ma,@ten,@maloaisp,@gia)
end
go
-------------------------------------------------
Insert into Administrator values('admin','admin')
Insert into Employee values('phamlinh','123456',N'Phạm Quang Linh',N'Nam','06/10/1998','0124566789','linh@gmail.com',N'Nam Định','2.jpg')

Insert into ProductType values('T01',N'Cà phê',N'Nhỏ')
Insert into ProductType values('T02',N'Cà phê',N'Vừa')
Insert into ProductType values('T03',N'Cà phê',N'Lớn')
Insert into ProductType values('T04',N'Nước trái cây',N'Nhỏ')
Insert into ProductType values('T05',N'Nước trái cây',N'Vừa')
Insert into ProductType values('T06',N'Nước trái cây',N'Lớn')
Insert into ProductType values('T07',N'Trà sữa',N'Nhỏ')
Insert into ProductType values('T08',N'Trà sữa',N'Vừa')
Insert into ProductType values('T09',N'Trà sữa',N'Lớn')

Insert into Product values('CF01', N'Cà phê đá', 'T01', 20000)
Insert into Product values('CF02', N'Cà phê đá', 'T02', 25000)
Insert into Product values('CF03', N'Cà phê đá', 'T03', 30000)



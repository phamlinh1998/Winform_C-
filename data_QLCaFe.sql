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
CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
go
create table Orders(
	IDOrder int identity Primary key,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	UsernameEmp varchar(50) foreign key REFERENCES Employee(Username),
	idTable INT FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id),
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán 
)
go
Create Table OrderDetails(
	IDOrder int foreign key REFERENCES Orders(IDOrder),
	IDProduct varchar(20) foreign key REFERENCES Product(IDProduct),

	Quantity int,
	Constraint PK_OrderDetails Primary key (IDOrder,IDProduct)
)

-------------Thủ tục--------------------------
go
Create proc load_bill
	@ma varchar(10),
	@ten nvarchar(50),
	@kichco nvarchar(10)
as
begin
	select * 
	from Product join ProductType on Product.IDType = ProductType.IDType
end

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

create proc IDLoaiSPTheoTen
	@TypeName nvarchar(50)
as
begin
	select DISTINCT IDType from ProductType where TypeName=N'Cà phê'@TypeName
end
go
	select Size from Product join ProductType ON Product.IDType = ProductType.IDType
	where TypeName = N'Cà Phê' and ProductName = N'Cà phê đá'
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
Create proc xoaSp
	@id varchar(20)
as
begin
	delete from Product where IDProduct = @id
end
go
Create proc suaSp
	@ten nvarchar(100),
	@maloai varchar(10),
	@gia int,
	@id varchar(20)
as
begin
	update Product set ProductName = @ten,IDType = @maloai,Price =@gia where IDProduct = @id
end
go
Create proc timkiemSPtheoTen
	@ten nvarchar(100)
as
begin
	select IDProduct as [Mã],ProductName as [Tên],p.IDType as[Loại],Price as [Giá],Size as[Kích cỡ]  
	from Product p inner join ProductType pt on p.IDType = pt.IDType where ProductName like '%'+@ten+'%'
end

go
Create proc LayDulieuBang	
as
begin
	select * from TableFood
end
------------------EMPLOYEE------------------
go
create proc load_Emp
as
begin
	select *
	from Employee order by NameEmp asc
end
go
create proc them_Emp
	@Username varchar(50),
	@Password varchar(20),
	@NameEmp nvarchar(50),
	@Gender nvarchar(10),
	@Birthday varchar(20),
	@Phone varchar(20),
	@Email varchar(50),
	@Address nvarchar(Max),
	@Hinh varchar(50)
as
begin
	insert into  Employee values (@Username,@Password,@NameEmp,@Gender,@Birthday,@Phone,@Email,@Address,@Hinh)
end

go
create proc Xoa_Emp
	@Username varchar(50)
as
begin
	delete from Employee where Username = @Username
end

go
create proc sua_Emp
	@Password varchar(20),
	@Phone varchar(20),
	@Email varchar(50),
	@Address nvarchar(Max),
	@Username varchar(50)
as
begin
	update Employee set Password=@Password,Phone=@Phone,Email=@Email,Address=@Address where Username = @Username
end
go
create proc layHoaDonTheoTableID
	@idTable INT
as
begin
	select * from Orders where idTable =@idTable and status =0
end

go
create proc layDSChiTietHoaDon
	@IDOrder int
as
begin
	select * from OrderDetails where IDOrder =@IDOrder 
end
go
create proc layDSMenuTheoBan
	@idTable INT,
	
as
begin
	select od.IDOrder,ProductName,pt.Size,odd.Quantity,p.Price,p.Price*odd.Quantity as TotaPrice 
	from OrderDetails as odd,Orders as od, Product as p,ProductType pt
	where odd.IDOrder = od.IDOrder and odd.IDProduct = p.IDProduct and od.idTable = @idTable and p.IDType = pt.IDType and od.status = 0
end
go
Create proc themOrder
	@UsernameEmp varchar(50),
	@idTable INT
	
as
begin
	insert into Orders values(GETDATE(),NULL,@UsernameEmp,@idTable,0)
end
go
Create proc themOrderDetail
	@IDOrder int,
	@IDProduct varchar(20),
	@Quantity int	
as
begin
	insert into OrderDetails values(@IDOrder,@IDProduct,@Quantity)
end
-------------------------------------------------
--------------THÊM DỮ LIỆU-----------------------
-----------THÊM BÀN ĂN--------------------------
/*DECLARE @i int =1
While @i<=14
begin
	insert into TableFood(name) values(N'Bàn' + CAST(@i as nvarchar(100)))
	set @i = @i+1
end
go 
select * from TableFood
UPDATE dbo.TableFood SET STATUS = N'Có người' WHERE id = 2
DECLARE @i int =68
While @i<=165
begin
	delete from TableFood where id =@i
	set @i = @i+1
end
*/
go
---------------------THÊM THÔNG TIN-------------------------------------
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

SELECT *FROM Orders
select * from OrderDetails
select * from product
select * from TableFood

Insert into Orders values(GETDATE(),GETDATE(),'phamlinh',1,0)

Insert into OrderDetails values(3,'CF02',2)

Insert into Orders values(GETDATE(),GETDATE(),'phamlinh',2,1)

Insert into OrderDetails values(4,'CF03',5)
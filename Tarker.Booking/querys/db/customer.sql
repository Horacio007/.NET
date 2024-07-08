create table [Customer] (
	CustomerId int primary key identity,
	FullName varchar(50) not null,
	DocumentNumber varchar(8) not null
)
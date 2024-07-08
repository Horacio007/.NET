create table [User] (
	UserId int primary key identity,
	FirstName varchar(50) not null,
	LastName varchar(50) not null,
	UserName varchar(50) not null,
	Password varchar(10) not null
)
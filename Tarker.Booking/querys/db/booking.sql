create table [Booking] (
	BookingId int primary key identity,
	RegisterDate datetime not null,
	Code varchar(50) not null,
	Type varchar(50) not null,
	UserId int not null,
	CustomerId int not null,
	foreign key (UserId) references [User](UserId),
	foreign key (CustomerId) references [Customer](CustomerId)
)
create table customer(
cid int Identity(1,1) primary key,
cname varchar (250) not null, 
mobile bigint not null,
nationality varchar (250) not null, 
gender varchar (50) not null,
dob varchar(50) not null, 
idproof varchar (250) not null,
addres varchar (350) not null,
checkin varchar (250) not null,
checkout varchar (250),
chekout varchar (250) not null default 'NO',
roomid int not null,
foreign key (roomid) references rooms (roomid)
);
select * from customer
cid,cname,mobile,nationality,gender,dob,idproof,addres,checkin,checkout,chekout,roomid

select * from rooms

create table employee(
eid int identity(1,1) primary key,
ename varchar(250) not null, 
mobile bigint not null,
gender varchar(50) not null,
emailid varchar (120) not null,
username varchar (150) not null,
pass varchar(150) not null
);

ename,mobile,gender,emailid,username,pass

select * from employee

insert into employee(ename,mobile,gender,emailid,username,pass) values ('Jenil','8200861413','Male','jenil7011@gmail.com','jazzie33','18103633');
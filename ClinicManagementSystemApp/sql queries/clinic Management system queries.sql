create database cms

use cms

create table roles
(
r_id int not null identity primary key,
r_name varchar(50) not null unique
)



create procedure st_insertRoles
@name varchar(50)
as
insert into roles values (@name)



create proc st_updateRoles
@name varchar(50),
@id int
as
update roles
set
r_name =@name
where
r_id=@id


create proc st_deleteRoles
@id int
as
delete from roles where r_id=@id


create proc st_getRoles
as
select r.r_id as 'ID', r.r_name as 'Role' 
from roles r


create table users
(
u_id int not null primary key identity,
u_name varchar(50) not null,
u_username varchar(50) not null unique,
u_password nvarchar(50) not null,
u_phone varchar(15) not null,
u_address nvarchar(150) not null,
u_roleID int not null foreign key references roles(r_id) on delete cascade on update cascade 
)


create procedure st_insertUsers
@name varchar(50),
@username varchar(50),
@password nvarchar(50),
@phone varchar(15),
@address nvarchar(150),
@roleID int
as
insert into users values (@name,@username,@password,@phone,@address,@roleID)


create procedure st_updateUsers
@name varchar(50),
@username varchar(50),
@password nvarchar(50),
@phone varchar(15),
@address nvarchar(150),
@roleID int,
@id int
as
update users
set
u_name=@name,
u_username=@username,
u_password =@password,
u_phone=@phone,
u_roleID=@roleID,
u_address=@address
where
u_id=@id


create proc st_deleteUser
@id int
as
delete from users 
where u_id=@id



create proc st_getUsers
as
select
u.u_id as 'ID',
u.u_name as 'User',
u.u_username as 'Username',
u.u_password as 'Password',
u.u_phone as 'Phone',
u.u_address as 'Address',
r.r_id as 'Role ID',
r.r_name as 'Role' from users u
inner join roles r
on r.r_id=u.u_roleID
order by u.u_name asc


create procedure st_getUsersWRTRole
@roleID int
as
select
u.u_id as 'ID',
u.u_name as 'User',
u.u_username as 'Username',
u.u_password as 'Password',
u.u_phone as 'Phone',
u.u_address as 'Address',
r.r_id as 'ID',
r.r_name as 'Role' from users u
inner join roles r
on r.r_id=u.u_roleID
where
r.r_id=@roleID
order by u.u_name asc

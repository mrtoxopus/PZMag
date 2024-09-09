CREATE TABLE cable (
                       name varchar(20) not null,
                       cableId int not null auto_increment primary key,
                       amount int not null,
                       nrTaken int not null
);

CREATE TABLE power (
                       type varchar(20) not null ,
                       powerId int not null auto_increment primary key ,
                       length int null,
                       watt int not null,
                       amount int not null
);

CREATE TABLE motherboard (
                             brand varchar(25) not null,
                             amount int not null ,
                             motherboardId int not null auto_increment primary key
);

CREATE TABLE ram (
                     type varchar(5) not null ,
                     brand varchar(15) not null ,
                     amount int not null ,
                     ramId int not null auto_increment primary key
);

CREATE TABLE tools (
                       name varchar(20) not null ,
                       complete bool not null,
                       inUse bool not null ,
                       toolId int not null auto_increment primary key
)
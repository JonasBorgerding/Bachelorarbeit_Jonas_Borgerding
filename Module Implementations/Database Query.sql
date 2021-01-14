create table Person (
    ID int primary key,
    forename varchar(20) not null,
    surname varchar(20) not null,
    city varchar(20) not null,
    zip_code varchar(5) not null,
    state varchar(20) not null
);

create table Meeting (
    ID int primary key,
    date datetime not null,
    person1 int not null,
    person2 int not null,
    foreign key (person1) references Person (ID)
    on delete cascade
    on update restrict,
    foreign key (person2) references Person (ID)
    on delete cascade
    on update restrict
);

load data local infile '/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/TablePersonData.csv' into table Person fields terminated by ',' (ID, forename, surname, city, zip_code, state);

load data local infile '/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/TableMeetingData.csv' into table Meeting fields terminated by ',' (ID, date, person1, person2);

commit;

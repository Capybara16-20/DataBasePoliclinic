Create database Поликлиника on
(Name='Поликлиника-data', FileName='D:\Поликлиника-data.mdf',
Size=5, Maxsize=10, Filegrowth=1)
Log on
(Name='Поликлиника-log', FileName='D:\Поликлиника-log.ldf',
Size=1, Maxsize=10, Filegrowth=1)
use Поликлиника

--drop database Регистратура

--1 Создание таблицы ПАЦИЕНТ
Create Table Пациент (IDПациента int identity (1,1) primary key, ФамилияПациента varchar(50),ИмяПациента varchar(50),
 ОтчествоПациента varchar(50),ПолисОМС int, ДатаРождения date, Пол varchar (10), Адрес varchar (200),
 НомерСтеллажа int, НомерПолки int,
Constraint UN_Пациент unique (ПолисОМС))

--2 Создание таблицы КАБИНЕТ
Create Table Кабинет (IDКабинета int  primary key, НомерКабинета varchar (5),
НазваниеКабинета varchar(50),ТипКабинета varchar(50))

--3 Создание таблицы Смена
Create Table Смена (НомерСмены int primary key, ВремяНачалаСмены time, ВремяОкончанияСмены time,
 ОписаниеCмены varchar(50))

 alter table Смена
 alter column ВремяНачалаСмены time(0)
  alter table Смена
 alter column ВремяОкончанияСмены time(0)

--4 Создание таблицы СПЕЦИАЛИЗАЦИЯ
Create Table Специализация (IDспециализацииВрача int primary key, Название varchar(100))

--5 Создание таблицы КатегорияПриема
Create Table КатегорияПриема (IDкатегорииПриема int primary key, Категория varchar(50))

--6 Создание таблицы ТипОбращения
Create Table ТипОбращения (IDтипаОбращения int primary key, НазваниеОбращения varchar (100),
IDкатегорииПриема int, IDспециализацииВрача int,
Constraint FK_ТипОбращения_КатегорияПриема foreign key (IDкатегорииПриема) references КатегорияПриема(IDкатегорииПриема),
Constraint FK_ТипОбращения_Специализация foreign key (IDспециализацииВрача) references Специализация(IDспециализацииВрача) )

--7 Создание таблицы Врач
Create Table Врач (IDврача int primary key, ФИОВрача varchar(200),
 IDспециализацииВрача int, НомерСмены int,  IDКабинета int,
Constraint FK_Врач_Специализация foreign key (IDспециализацииВрача) references Специализация(IDспециализацииВрача),
Constraint FK_Врач_Смена foreign key (НомерСмены) references Смена(НомерСмены),
Constraint FK_Врач_Кабинет foreign key (IDКабинета) references Кабинет(IDКабинета))

-- таблица для выбора времени талонов

Create Table ВремяТалонов (ВремяТалона time (0) primary key, НомерСмены int,
Constraint FK_ВремяТалона_НомерСмены foreign key (НомерСмены) references Смена(НомерСмены))

--8 Создание таблицы Талон
Create Table Талон (IDталона int  identity (1,1) primary key, IDПациента int, IDВрача int, IDтипаОбращения int,
ДатаПриема date, ВремяТалона time (0),
Constraint FK_Талон_Пациент foreign key (IDПациента) references Пациент(IDПациента),
Constraint FK_Талон_Врач foreign key (IDВрача) references Врач(IDВрача),
Constraint FK_Талон_ТипПриема foreign key (IDтипаОбращения) references ТипОбращения(IDтипаОбращения),
Constraint FK_Талон_ВремяТалона foreign key (ВремяТалона) references ВремяТалонов (ВремяТалона))



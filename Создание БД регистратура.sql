Create database ����������� on
(Name='�����������-data', FileName='D:\�����������-data.mdf',
Size=5, Maxsize=10, Filegrowth=1)
Log on
(Name='�����������-log', FileName='D:\�����������-log.ldf',
Size=1, Maxsize=10, Filegrowth=1)
use �����������

--drop database ������������

--1 �������� ������� �������
Create Table ������� (ID�������� int identity (1,1) primary key, ��������������� varchar(50),����������� varchar(50),
 ���������������� varchar(50),�������� int, ������������ date, ��� varchar (10), ����� varchar (200),
 ������������� int, ���������� int,
Constraint UN_������� unique (��������))

--2 �������� ������� �������
Create Table ������� (ID�������� int  primary key, ������������� varchar (5),
���������������� varchar(50),����������� varchar(50))

--3 �������� ������� �����
Create Table ����� (���������� int primary key, ���������������� time, ������������������� time,
 ��������C���� varchar(50))

 alter table �����
 alter column ���������������� time(0)
  alter table �����
 alter column ������������������� time(0)

--4 �������� ������� �������������
Create Table ������������� (ID������������������ int primary key, �������� varchar(100))

--5 �������� ������� ���������������
Create Table ��������������� (ID��������������� int primary key, ��������� varchar(50))

--6 �������� ������� ������������
Create Table ������������ (ID������������� int primary key, ����������������� varchar (100),
ID��������������� int, ID������������������ int,
Constraint FK_������������_��������������� foreign key (ID���������������) references ���������������(ID���������������),
Constraint FK_������������_������������� foreign key (ID������������������) references �������������(ID������������������) )

--7 �������� ������� ����
Create Table ���� (ID����� int primary key, �������� varchar(200),
 ID������������������ int, ���������� int,  ID�������� int,
Constraint FK_����_������������� foreign key (ID������������������) references �������������(ID������������������),
Constraint FK_����_����� foreign key (����������) references �����(����������),
Constraint FK_����_������� foreign key (ID��������) references �������(ID��������))

-- ������� ��� ������ ������� �������

Create Table ������������ (����������� time (0) primary key, ���������� int,
Constraint FK_�����������_���������� foreign key (����������) references �����(����������))

--8 �������� ������� �����
Create Table ����� (ID������ int  identity (1,1) primary key, ID�������� int, ID����� int, ID������������� int,
���������� date, ����������� time (0),
Constraint FK_�����_������� foreign key (ID��������) references �������(ID��������),
Constraint FK_�����_���� foreign key (ID�����) references ����(ID�����),
Constraint FK_�����_��������� foreign key (ID�������������) references ������������(ID�������������),
Constraint FK_�����_����������� foreign key (�����������) references ������������ (�����������))



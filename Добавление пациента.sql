CREATE PROCEDURE PatientInsert1 
 (@��������������� varchar(500),
 @����������� varchar(50),
 @���������������� varchar(50),
 @�������� int, 
 @������������ date, 
 @��� varchar (10), 
 @����� varchar (200),
 @������������� int, 
 @���������� int)
 as
 
IF  NOT EXISTS ( SELECT *
                  FROM �������
                  WHERE �������� = @��������)
 Insert Into ������� 
 VALUES(@���������������, @�����������, @����������������,@��������, 
        @������������ , @��� , @����� , @�������������, @���������� )
go
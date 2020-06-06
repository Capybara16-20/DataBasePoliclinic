CREATE PROCEDURE PatientInsert1 
 (@ФамилияПациента varchar(500),
 @ИмяПациента varchar(50),
 @ОтчествоПациента varchar(50),
 @ПолисОМС int, 
 @ДатаРождения date, 
 @Пол varchar (10), 
 @Адрес varchar (200),
 @НомерСтеллажа int, 
 @НомерПолки int)
 as
 
IF  NOT EXISTS ( SELECT *
                  FROM Пациент
                  WHERE ПолисОМС = @ПолисОМС)
 Insert Into Пациент 
 VALUES(@ФамилияПациента, @ИмяПациента, @ОтчествоПациента,@ПолисОМС, 
        @ДатаРождения , @Пол , @Адрес , @НомерСтеллажа, @НомерПолки )
go
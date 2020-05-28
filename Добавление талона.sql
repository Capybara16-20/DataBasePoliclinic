create procedure AddCoupon
 (@ПолисОМС int,
 @Категория varchar(50),
 @НазваниеОбращения varchar(100),
 @ФИОВрача varchar(200),
 @ДатаПриема date,
 @ВремяТалона time(0),
 @ID int output)
as
 Declare @Пациент int
 Declare @Врач int
 Declare @ТипОбращения int
 Select @Пациент = IDПациента
                   From Пациент
			     Where ПолисОМС = @ПолисОМС
 Select @Врач =  IDврача
              From Врач
			  Where ФИОВрача = @ФИОВрача
 Select @ТипОбращения =  IDтипаОбращения
                      From ТипОбращения
			          Where НазваниеОбращения = @НазваниеОбращения
 Insert Into Талон 
 VALUES(@Пациент, @Врач, @ТипОбращения, @ДатаПриема, @ВремяТалона)
 Select @id = (Select IDталона
                From Талон
				Where IDВрача = @Врач AND ДатаПриема = @ДатаПриема AND ВремяТалона = @ВремяТалона)
go
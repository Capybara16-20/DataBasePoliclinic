create procedure AddCoupon
 (@�������� int,
 @��������� varchar(50),
 @����������������� varchar(100),
 @�������� varchar(200),
 @���������� date,
 @����������� time(0),
 @ID int output)
as
 Declare @������� int
 Declare @���� int
 Declare @������������ int
 Select @������� = ID��������
                   From �������
			     Where �������� = @��������
 Select @���� =  ID�����
              From ����
			  Where �������� = @��������
 Select @������������ =  ID�������������
                      From ������������
			          Where ����������������� = @�����������������
 Insert Into ����� 
 VALUES(@�������, @����, @������������, @����������, @�����������)
 Select @id = (Select ID������
                From �����
				Where ID����� = @���� AND ���������� = @���������� AND ����������� = @�����������)
go
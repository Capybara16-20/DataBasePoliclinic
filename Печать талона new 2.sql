--������ ������
CREATE procedure printTalon1 
 @����������� char(150),
 @����������������� char (100),
 @�������� char (200),
 @���������� date, 
 @����������� time (0), 
 @message varchar(500) output
as 
begin
declare 
 @������������� char (5)
select 
 @������������� = �������������
  FROM ������������, �������������, ���������������, ����, �����, �������, �������
  where �������.ID�������� = ����.ID�������� AND
        ����.�������� = @��������

Set @message = '�������: ' + @����������� 
+ ',���� � ����� ������ - '+ convert(varchar, @����������,105) +' '+ convert(varchar, @�����������)
+ ',��� ������: '+ @����������������� + ',����: '+ @�������� + ',�������: ' + @�������������
end
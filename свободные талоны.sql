--��������� ������ ��������� ������� 
  alter procedure Reg1 (@��������������� varchar(50), @����������������� varchar (100),
@�������� varchar(200),@���������� date )
as
  (
  SELECT ���������, �����������������, ��������,@����������, �����������
  FROM ���������������,������������,����,�������������,������������
  where ������������.ID������������������=�������������.ID������������������
  and ������������.ID���������������=���������������.ID���������������
  and ������������.ID������������������ = ����.ID������������������
  and ����.����������=������������.����������
  and ������������.ID���������������= (select ID��������������� from ��������������� where ��������� = @���������������)
  and ������������.ID�������������= (select ID������������� from ������������ where ����������������� = @�����������������)
  and ����.ID�����= (select ID����� from ���� where �������� = @��������)
  )
  except
  (  select ���������, �����������������, ��������,���������� , �����������
  from �����, ������������, ���������������,����
  Where �����.ID�������������=������������.ID�������������
  and ������������.ID���������������=���������������.ID���������������
  and �����.ID����� = ����.ID�����)
  
  exec Reg1 '����� �����������', '����� �����-����������', '������� ����� ��������', '2020-04-21'
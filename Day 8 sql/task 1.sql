sp_help tblEmployee

create table tblEmployee
(id int identity(101,1)primary key,
name varchar(20),
age int default 18,
manager_id int)

alter table tblEmployee
add constraint fk_mgId foreign key(manager_id) references tblEmployee(id)

insert into tblEmployee(name,age) values('Ramu',35)
insert into tblEmployee(name,age) values('Somu',31)
insert into tblEmployee(name,age,manager_id) values('Sita',21,101)
insert into tblEmployee(name,age,manager_id) values('Gita',22,101)
insert into tblEmployee(name,age,manager_id) values('Anita',20,102)
select * from tblEmployee

select emp.id Employee_Id,emp.name Employee_Name,
mgr.id MAnager_Id,mgr.name Manager_Name
from tblEmployee emp join
tblEmployee mgr on emp.manager_id=mgr.id/*SELF JOIN  */

select * from employee cross join sales  /* CROSS JOIN  */


create procedure proc_example
as 
begin 
   select * from authors
end										/* creation of stored procedure*/

exec proc_example						/* execution of stored procedure */


create procedure proc_sampleinput(@un varchar(20))
as 
begin 
   select @un
end

exec proc_sampleinput 'Ramu'

select * from authors


alter procedure proc_sampleinput(@un varchar(20))
as 
begin 
   select concat('Welcome',@un)

end

exec proc_sampleinput


alter procedure proc_sampleinput(@un varchar(20),@gen varchar (6))
as 
begin 
   if(@gen ='male')
         begin
		 select concat('Welcome Mr.',@un)
		 end
   else
		 begin
		 select concat('Welcome Miss.',@un)
		 end

end
exec proc_sampleinput'Ramu','Male'


create proc proc_FetchTitleUsingAuthorsName(@an varchar (500))
as
begin
select * from titles where  title_id in
(select title_id from titleauthor where au_id in (
select au_id from authors where au_fname =@an))
end
exec proc_FetchTitleUsingAuthorsName 'Burt'


alter proc proc_FetchSalesUsingTitleName(@tn varchar (500))
as 
begin
	select * from sales where title_id in 
	(select title_id from titles where title=@tn)

end
exec proc_FetchSalesUsingTitleName 'Secrets of Silicon Valley'
select * from sales


create proc proc_CommentOnTheTitleSale(@title varchar(600))
as
begin
		declare @salecount int
		set @salecount=(select count(*) from sales where title_id=(select title_id from titles where title=@title))
		if(@salecount>1)
			begin
			select concat('More than one sale and the sale no is :',@salecount)
			end
		else
			begin
			select concat('Improve the sale to  more than one and your number is :',@salecount)
			end
end
exec proc_CommentOnTheTitleSale 'The Busy Executive''s Database Guide'
select * from titles


alter proc proc_InsertEmployee(@ename varchar (20),@eage int,@emgrid int)/* insert*/
as 
begin
		if(@emgrid =0)
			insert into tblEmployee(name,age) values (@ename,@eage)
        else
		    insert into tblEmployee(name,age,manager_id) values(@ename,@eage,@emgrid)
end
exec proc_InsertEmployee 'Reba',24,0

select * from tblEmployee

create proc proc_InsertEmployeeSonsideringempno(@ename varchar (20),@eage int,@emgrid int)
as 
begin
		if(@emgrid =0)
			insert into tblEmployee(name,age) values (@ename,@eage)
        else
			declare @empno int
			set @empno=(select count(*) from tblEmployee where manager_id=@emgrid)
			if(@empno <6)
		    insert into tblEmployee(name,age,manager_id) values(@ename,@eage,@emgrid)
			else
			select ' Manager has 6 employees'

end 
exec proc_InsertEmployeeSonsideringempno 'anitha',24,101
select * from tblEmployee

create proc proc_UnderstandingOutParameter(@dataIn int ,@dataOut int out)
as
begin
		set @dataout =@dataIn *1000;
end
declare
@mydata int
exec proc_UnderstandingOutParameter 255,@mydata out
select @mydata

create table employeedetails(
empid int identity(100,1)primary key,
Name varchar(100),
Age int ,
phone varchar(10) not null,
gender varchar(10))



--drop table employeedetails

create table salary (
sa_id int identity(1,100)primary key,
basic float,
HRA float,
DA float,
deductions float)

--drop table salary


create table employeesalary(
transaction_number  int identity(1,1) primary key,
employee_id int references employeedetails(empid) ,
salary_id int references salary(sa_id),
sal_date date,
constraint uc_empsal unique (employee_id,salary_id,sal_date))
select * from employeesalary
--drop table employeesalary

alter table employeedetails
add email varchar (100)
select * from employeedetails

insert into employeedetails (name,Age,phone,gender,email) values('Anu',23,0987654321,'Female','anu123@gmail.com')
insert into employeedetails (name,Age,phone,gender,email) values('bhima',27,0987654333,'Male','bhima123@gmail.com')
insert into employeedetails (name,Age,phone,gender,email) values('Ezhil',28,1987654321,'Male','ezhil123@gmail.com')
insert into employeedetails (name,Age,phone,gender,email) values('fathima',29,0987666321,'Female','fathima123@gmail.com')
insert into employeedetails (name,Age,phone,gender,email) values('gowarthan',24,7685666321,'Male','Gowa123@gmail.com')
select * from employeedetails

--delete from employeedetails 


insert into salary (basic,HRA,DA, deductions) values (50000,2000,1000,2500)
insert into salary (basic,HRA,DA, deductions) values (150000,2500,1250,2750)
insert into salary (basic,HRA,DA, deductions) values (210000,3000,1500,3000)
insert into salary (basic,HRA,DA, deductions) values (280000,3500,1750,3250)
insert into salary (basic,HRA,DA, deductions) values (390000,4000,2000,3500)
select * from salary
--select * from employeesalary
--select * from employeedetails
--drop table salary
--drop table employeesalary
--drop table employeedetails

insert into employeesalary(employee_id,salary_id,sal_date) values (100,1,'2021-04-26')
insert into employeesalary(employee_id,salary_id,sal_date) values (101,101,'2021-04-26')
insert into employeesalary(employee_id,salary_id,sal_date) values (102,201,'2021-04-26')
insert into employeesalary(employee_id,salary_id,sal_date) values (103,301,'2021-04-26')
insert into employeesalary(employee_id,salary_id,sal_date) values (104,401,'2021-04-26')
select * from employeesalary



select * from employeedetails
select * from salary
select * from employeesalary

create proc proc_totalsalaryFromEmployeeidandDate(@empid int,@saldate date,@total float out)
as
begin
		set @total=(select basic from salary where sa_id=(select salary_id from employeesalary where employee_id=@empid and sal_date=@saldate ))+
					(select HRA from salary where sa_id=(select salary_id from employeesalary where employee_id=@empid and sal_date=@saldate))+
					(select DA from salary where sa_id=(select salary_id from employeesalary where employee_id=@empid and sal_date=@saldate))-
					(select deductions from salary where sa_id=(select salary_id from employeesalary where employee_id=@empid and sal_date=@saldate));
end
					
declare
@mydata int
exec proc_totalsalaryFromEmployeeidandDate 105,'2021-04-26',@mydata out
select @mydata


create proc proc_AverageSalaryOfEmployeeByHisId(@empid int)
as 
begin
		declare
		@avg int
		set @avg=
end

create proc proc_TaxCalculation(@eid float,@tax int out)
as
begin
		declare
		@num int
		set @num=(select sum(basic+HRA+DA-deductions) from employeesalary es join salary s
		on es.salary_id=sa_id where es.employee_id=@eid 
		if(@num<100000)
			select 'No Tax '
		else if(@num<200000)
			select @tax=
		else if(@total<350000)
			set @num=(0.06*@total)
			select 'Your Tax amount is',@num
		else if(@total>350000)
			set @num=(0.075*@total)
			select 'Your Tax amount is',@num
end


alter function fn_calsal(@basic float,@hra float,@da float,@ded float)
returns float
as
begin
		declare
		@netsal float
		set @netsal=@basic+@hra+@da-@ded 
		return @netsal
end

select dbo.fn_calsal (basic,HRA,DA,deductions) 'Networth' from salary


create function fn_completeSalDetails(@emid int)
returns @empsal table
(Ename varchar(15),
totalsal float,
tax float)
as 
begin
declare
		@total float,
		@tax float,
		@taxpayable float,
		@ename varchar(15)
			set total = (select sum(basic+hra+da-deductions) from employeesalary es join salary s
			on es.salary_id=s.sa_id
			where es.employee_id=@emid)
			if(@total<100000)
				set @tax=0
			else if(@total<100000) and (@total<200000)
				set @tax=5
			else if(@total<100000) and (@total <350000)
				set @tax=6
			else 
				set @tax=7.5
			set @taxpayable =@total*@tax/100
			set @ename=(select name from employees where id=@eid)
			insert into @empSalTax values(@Ename,@total,@taxpayable)
			return
end
select * from dbo.fn_fn_completeSalDetails(100)


create table bbldummy
(f1 int,
f2 varchar(20))

create trigger trgInsertDummy
on bbldummy
after insert
as
begin
		select 'Hello everyone'
end

insert into bbldummy values(2,'Dhiva')
insert into bbldummy values(1,'Dhiva')
select * from bbldummy

drop trigger trgInsertDummy

create trigger trgInsertDummy
on bbldummy
after insert
as
begin
		select concat('Hello everyone',f2) from bbldummy
end

insert into bbldummy values(3,'Moni')
create table employeenetsal
(transaction_id int,
netsal float)

select * from employeenetsal
select * from salary
select * from employeesalary
select * from employeedetails

create trigger trg_InsertNetSal
on employeeSalary
after insert
as
begin
		declare
		@totalsal float
		set @totalsal=(select dbo.fn_calsal(basic,hra,da,deductions)from salary where sa_id=(select salary_id from inserted))
		insert into employeenetsal values ((select transaction_id from inserted),@totalsal)
end
insert into employeesalary values(1006,102,201,'2021-04-31')


create trigger tgr_messageEmployee
on employeedetails
after insert
as begin
        if((select gender from inserted)='male')
				select concat('Welcome Mr.',Name) from inserted
		else if((select gender from inserted)='Female')
				select concat('Welcome Miss. ',Name) from inserted
end
drop trigger tgr_messageEmployee
insert into employeedetails (name,Age,phone,gender,email) values('fazil',27,7685666321,'Male','fazil123@gmail.com')

begin transaction
		insert into employeedetails (name,Age,phone,gender,email) values('harish',24,7685666321,'Male','Gowa123@gmail.com')
		insert into employeesalary(employee_id,salary_id,sal_date) values (106,401,'2021-04-26')
		if((select max(employee_id) from employeesalary)=107)
		   commit
		else
		  rollback

declare @eid int ,@ename varchar(20)
declare cur_employeedetails cursor for
select empid ,name from employeedetails

open cur_employeedetails

fetch next from cur_employeedetails
into @eid,@ename

print 'employee data'
while @@FETCH_STATUS = 0
begin
     print 'Employee Id:' +cast(@eid as varchar(20))
	 print 'Employee Name:' +@ename
	 print '------------------------------'
	 declare
	 @sid int,@date date,@total float
	 declare cur_empsal cursor for
	 select salary_id,sal_date from employeesalary where employee_id=@eid
     open cur_empsal
	 fetch next from cur_empsal into @sid,@date
	 print '#############################'
	 print 'Salary Details'
	 while @@FETCH_STATUS = 0
	 begin
			set @total =(select basic+hra+da-deductions from salary where sa_id=@sid)
			print 'Date :' +cast(@date as varchar(20))
			print 'Net Salary:' +cast (@Total as varchar(20))
			fetch next from cur_empsal into @sid,@date
     end
	 print' Next Employee'
	 close cur_empsal
	 deallocate cur_empsal
	 fetch next from cur_employeedetails
	 into @eid,@ename
end
close cur_employeedetails
deallocate cur_employeedetails

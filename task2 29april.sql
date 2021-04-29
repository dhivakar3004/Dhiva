use pubs
select * from authors
select * from titles
select * from titleauthor
select * from sales

 /* 1 ans   */

select distinct city,count(city) no_of_times_it_is_repeated from authors group by city            





 /*   2 ans   */

select concat(au_fname,' ',au_lname) Name_of_the_Author from authors where city not  in 
(select city from publishers where pub_name ='New Moon Books');      






/*                3RD ANSWER    */

alter proc proc_UpdateThePrice(@aufn varchar(20),@auln varchar(20),@Newprice float )
as
begin
		update titles set price = @Newprice from titles where title_id in 
	(select title_id from titleauthor where au_id=
	(select au_id from authors where au_lname = @auln and au_fname = @aufn))

	select price from titles where title_id in 
	(select title_id from titleauthor where au_id=
	(select au_id from authors where au_lname = @auln and au_fname = @aufn))

end
exec proc_UpdateThePrice"Johnson","White",89






/*           4TH ANSWER   */

create function fn_calculateTaxForBook(@title_id varchar(30))
returns float
as
begin
declare
   @qty int,
   @total float,
   @price float,
   @taxPayable float,
   @tax float

   set @qty=(select qty from sales where title_id=@title_id)
   set @price=(select price from titles where title_id=@title_id )
   set @total=@price*@qty
   if(@qty<10)
      set @tax=2
   else if(@qty>10 and @qty<20)
      set @tax=5
   else if(@qty>20 and @qty<50)
      set @tax=6
   else
      set @tax=7.5
  set @taxPayable=@price*@tax/100
  return @taxPayable
end


select dbo.fn_calculateTaxForBook('PS3333') Tax



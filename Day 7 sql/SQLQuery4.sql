use pubs

select * from publishers
select au_fname ,au_lname from authors

select au_fname First_Name , au_lname Last_Name from authors

select * from authors where state != 'CA'

select * from authors where state = 'CA'

select * from employee where minit is not null

use pubs

select * from employee

select * from publishers
select pub_id, count (*) number_count from titles group by pub_id

select pub_id ,avg (advance) avg_advance from titles group by pub_id

select pub_id, count(title) agg_title ,avg(advance) average_advance from titles group by pub_id

select * from sales

select title_id ,sum(qty) addition from sales group by title_id


select * from titles
select type ,avg(royalty) average_royalty from titles group by type

select * from sales
select stor_id,count(ord_num) no_of_order from sales group by stor_id

select stor_id,count(ord_num) no_of_order from sales group by stor_id
having count(ord_num) > 2

select * from titles
select  type ,avg(royalty) average_royalty from titles group by type having avg(royalty) < 15

select * from authors
select * from authors order by au_lname
select * from authors order by city

select * from authors order by state , city

select * from authors order by phone asc
select * from authors order by phone desc

/* update authors set au_lname="paul" where au_id= '486-29-1786'*/

select * from sales where title_id=(select title_id from titles where title='The Busy Executive''s database Guide')


select * from publishers

select * from sales where title_id in (
select title_id from titles where pub_id=(
select pub_id from publishers where pub_name ='New Moon Books'))

select title_id,sum(qty) from sales where title_id in (
select title_id from titles where pub_id=(
select pub_id from publishers where pub_name ='New Moon Books'))
group by title_id
having sum(qty) < =25
order by sum(qty) desc


select title_id,sum(qty)sum_of_quantities from sales where title_id in (
select title_id from titles where pub_id=(
select pub_id from publishers where pub_name ='New Moon Books'))
group by title_id
having sum(qty) < =25
order by sum_of_quantities asc

select title_id,sum(qty) from sales where title_id in (
select title_id from titles where pub_id=(
select pub_id from publishers where pub_name ='New Moon Books'))
group by title_id
having sum(qty) < =25
order by  sum(qty) asc

select title ,qty from titles join sales
on 
titles.title_id=sales.title_id

select * from sales

select distinct title_id from sales

select title_id from titles where title_id not in (select distinct title_id from sales)



-- join
select t.title_id,title,qty from titles t join sales s
on
t.title_id=s.title_id

-- outer join
--fetch all the data from the left hand side table even if does not match the condition
select t.title_id,title,qty from titles t left outer join sales s
on
t.title_id=s.title_id

select * from publishers
select * from titles

select p.pub_name ,t.title from publishers join titles 
on 
p.pub_id = t.title_id

select * from titles

select au_fname , au_lname from authors 

select * from titles des

select * from authors
select au_lname,au_fname,sum(title) from titles group by authors /* doubt   3 */

SELECT  CONCAT(au_fname,' ', au_lname) AS FIRSTNAME FROM authors

 /*   4*/

select * from titles
select * from publishers
select pub_name,avg(advance) from publishers join titles
on
publishers.pub_id= titles.pub_id  /*doubt   5*/

select/* doubt    6*/



select * from titles
select price ,title from titles where title like '%s' /*      7*/


select * from titles where title like '%and%' /*      8*/




select * from publishers
select CONCAT(fname ,' '+lname)as name from employee 
select pub_name from publishers                    /* doubt  9*/

select * from publishers 
select * from employee
select pub_name,distinct count(pub_id) >2  from publishers join employee  /* doubt  10*/


select * from publishers
select * from authors
select * from titles

select au_fname from authors where (pub_id on publishers=1389)










--Select * from DavidDataNew  where FirstName = 'Moshe' or city = 'Rishon'; -- Shows people that their name is 'Moshe' and their city is 'Rishon'
--Select * from DavidDataNew where (id='2'); -- Shows the peple with id 2
--select * from DavidDataNew where FirstName Like 'M%'; -- Shows the people with this particular letter at the start of their name
--select * from DavidDataNew where FirstName Like '%e'; -- Shows the people with this particular letter at the end of their name
--select * from DavidDataNew where FirstName Like '%Mos%'; -- SHows the people that their name has the combination of the letters 'Mos';
--select * from DavidDataNew where avgGrade < 70; -- Shows people that their average grade is under 70
insert into DavidDataNew Values ('David','Khodorkovsky','Yud2','Rishon','89.8','Davidkh207@gmail.com','Male');
insert into DavidDataNew Values ('Ori','Serbi','Yud2','Rishon','99.79','OriSerbi2487999@gmail.com','Male');
delete from DavidDataNew where id > '71';
update DavidDataNew Set avgGrade = 79 where FirstName='Sara';
select * from DavidDataNew;
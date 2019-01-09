use Chinook

--select * 
--from Artist
--order by Name ASC;

--select top 10 Name
--from Artist
--where ArtistId <=10
--order by Name ASC;

--select *
--from Artist
--where Name LIKE 'Academy%'

--select *
--from Album
--where Title LIKE '_ar%%'

--select *
--from Album
--where Title LIKE '[aouieåäö]%'

--select top 10 count(*), Artist.Name
--from Artist
--full join Album
--on Artist.ArtistId = Album.ArtistId
--group by Artist.Name
--order by COUNT(*) desc;

--select Album.Title
--from genre
--full join Track
--on Genre.GenreId = Track.GenreId
--full join album
--on track.AlbumId = Album.AlbumId
--where Genre.Name = 'Jazz' OR Genre.Name = 'Blues'
--group by Album.Title
--select sum(total) as Summa, year(invoicedate) as Year
--from Invoice
--group by year(invoicedate)
--order by year desc;

--Select anstalld.name, chef.name
--from anstalld, chef
--Where anstalld.chefid = chef.id


--select employee.FirstName, ReportsTo
--from Employee
--order by FirstName asc;

-----------------------2--------------------------
--select top 10 Artist.Name
--from Artist
--order by Name

--select Artist.Name
--from Artist
--where Name like 'Academy%'

--select Album.Title
--from Album
--where Title like '_ar%'
--order by Title

--select Album.Title
--from Album
--where Title like '[aoeiu]%'

--select Artist.Name, Album.Title
--from Artist
--full join Album
--on Artist.ArtistId = Album.ArtistId

--select count(Album.ArtistId), Album.Title
--from Album
--full join Artist
--on Artist.ArtistId = Album.ArtistId
--group by 



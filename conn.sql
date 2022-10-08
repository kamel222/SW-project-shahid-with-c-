Drop table movies cascade constraints;
Drop table tvShows cascade constraints;
Drop table Accounts cascade constraints;
Drop table subAcc cascade constraints;

create table movies(movieID number (10) primary key ,movieTitle varchar2 (25) not null,movie_releaseDate date ,movieDuration number(3),movieCategory varchar2(20),movieDescribtion varchar2 (1000));
create table tvShows(tvShow_ID number (10) primary key ,tvShow_Title varchar2 (25),tvsShow_releaseDate date ,tvsShow_Duration number(3),tvsShow_Category varchar2(20),tvsShow_Describtion varchar2 (1000));
create Table Accounts(AccName varchar2(20) , AccID number (5) primary key);
create Table subAcc (MainAccID number (3) references Accounts(AccID) , sAccName varchar(20) , sAccType varchar(20) , saccDate date);

insert into movies (movieID, movieTitle, movie_releaseDate, movieDuration, movieCategory, movieDescribtion) values ( 1, 'clueless' , to_date('16-Nov-2012'),111,'Drama','American coming-of-age teen comedy film ');
insert into movies (movieID, movieTitle, movie_releaseDate, movieDuration, movieCategory, movieDescribtion) values ( 2, 'Spiderman' , to_date('18-Dec-2014'),150,'Action','Superhero appearing in American comic books ');
insert into movies (movieID, movieTitle, movie_releaseDate, movieDuration, movieCategory, movieDescribtion) values ( 3, 'The Notebook' , to_date('16-Nov-2012'),124,'Romance','young couple who fall in love ');
insert into movies (movieID, movieTitle, movie_releaseDate, movieDuration, movieCategory, movieDescribtion) values ( 4, 'Scream' , to_date('2-Jan-1995'),138,'Horror','A teenage girl becomes the target of a killer ');
insert into movies(movieID, movieTitle, movie_releaseDate, movieDuration, movieCategory, movieDescribtion) values ( 5, 'Date night' , to_date('6-April-2010'),88,'Comedy','Tells a story of a case of mistaken identity in NYC');
insert into movies (movieID, movieTitle, movie_releaseDate, movieDuration, movieCategory, movieDescribtion) values ( 6, 'Venom' , to_date('1-Dec-2021'),170,'Action','A failed reporter is bonded to an alien entity ');
insert into movies (movieID, movieTitle, movie_releaseDate, movieDuration, movieCategory, movieDescribtion) values ( 7, 'Joker' , to_date('8-Jan-2008'),124,'Action','American psychological thriller film  ');
insert into movies (movieID, movieTitle, movie_releaseDate, movieDuration, movieCategory, movieDescribtion) values ( 8, 'Annabelle' , to_date('21-Mar-2001'),79,'Horror','American supernatural horror film ');
insert into movies (movieID, movieTitle, movie_releaseDate, movieDuration, movieCategory, movieDescribtion) values ( 9, 'Gemini man' , to_date('4-Jun-1999'),117,'Action','retiring hitman who is targeted by a much younger clone of himself  ');
insert into movies (movieID, movieTitle, movie_releaseDate, movieDuration, movieCategory, movieDescribtion) values ( 10, 'Dr strange' , to_date('19-Oct-2020'),79,'Science fiction','man responsible for the multi universe');

insert into tvShows(tvShow_ID, tvShow_Title, tvsShow_releaseDate, tvsShow_Duration,tvsShow_Category,tvsShow_Describtion) values( 1, 'Friends' , to_date('22-Jan-2001'),30,'Comedy','revolves around six friends in their 20s who live in New York City ');
insert into tvShows(tvShow_ID, tvShow_Title, tvsShow_releaseDate, tvsShow_Duration,tvsShow_Category,tvsShow_Describtion) values( 2, 'Tvd' , to_date('2-Nov-2002'),49,'Action','Vampires in fictional town of Mystic Falls ');
insert into tvShows (tvShow_ID, tvShow_Title, tvsShow_releaseDate, tvsShow_Duration,tvsShow_Category,tvsShow_Describtion) values( 3, 'The office' , to_date('16-May-2000'),22,'Comedy','A mockumentary on a group of typical office workers ');
insert into tvShows (tvShow_ID, tvShow_Title, tvsShow_releaseDate, tvsShow_Duration,tvsShow_Category,tvsShow_Describtion)values ( 4, 'Sherlock holmes' , to_date('16-Nov-2015'),60,'Drama','Holmes is famous for his prowess at using logic and astute observation to solve cases. ');
insert into tvShows (tvShow_ID, tvShow_Title, tvsShow_releaseDate, tvsShow_Duration,tvsShow_Category,tvsShow_Describtion) values( 5, 'Peaky blinders' ,to_date('1-Feb-2018'),39,'Crime','A gangester family who sew razor blades in the peaks of their caps,and their boss tommy shelby');
insert into tvShows (tvShow_ID, tvShow_Title, tvsShow_releaseDate, tvsShow_Duration,tvsShow_Category,tvsShow_Describtion) values( 6, 'Prison break' ,to_date('14-Oct-2007'),39,'Drama','focuses on a prison designer who gets himself thrown into one of his own prisons to help his falsely accused brother escape death row');
insert into tvShows (tvShow_ID, tvShow_Title, tvsShow_releaseDate, tvsShow_Duration,tvsShow_Category,tvsShow_Describtion) values( 8, 'Brooklyn99',to_date('1-Feb-2010'),39,'Comedy','lovable colleagues as they police the NYPD 99th Precinct');
insert into tvShows (tvShow_ID, tvShow_Title, tvsShow_releaseDate, tvsShow_Duration,tvsShow_Category,tvsShow_Describtion) values( 9, 'Emily in paris',to_date('30-May-2017'),39,'Romance','Young lady who travelled to paris alone for fashion');

insert into Accounts values ('Menna',2);
insert into Accounts values ('Ziad',3);
insert into Accounts values ('Ahmed',1);

insert into subAcc values ( 1 ,'menna', 'Kids','12-nov-2019');
insert into subAcc values ( 1 ,'omnia', 'visitor','14-nov-2019');
insert into subAcc values (1,'hana', 'kids','10-nov-2019');
insert into subAcc values ( 1 ,'menna', 'Kids','12-nov-2019');
insert into subAcc values ( 1 ,'omnia', 'visitor','14-nov-2019');
insert into subAcc values (1,'hana', 'kids','10-nov-2019');
insert into subAcc values ( 2 ,'basant', 'Kids','12-nov-2020');
insert into subAcc values ( 2 ,'sarah', 'visitor','14-Dec-2020');
insert into subAcc values (2,'rana', 'kids','10-oct-2019');

commit;

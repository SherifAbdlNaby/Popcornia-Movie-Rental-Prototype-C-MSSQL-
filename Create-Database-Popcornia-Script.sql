USE Popcornia;
CREATE TABLE Users (
  [UserID] int NOT NULL PRIMARY KEY IDENTITY(1,1),
  [Username] varchar(30) NOT NULL DEFAULT '',
  [Name]    varchar(50) NOT NULL DEFAULT 'untitled',
  [Password] varchar(50) NOT NULL DEFAULT '',
  [Email] varchar(30) NOT NULL DEFAULT '',
  [BirthDate] date NOT NULL,
  [Address] varchar(50) NOT NULL DEFAULT '',
  [Telephone] varchar(20) NOT NULL DEFAULT '',
  [isAdmin] bit NOT NULL,
  UNIQUE ([Username]) , 
) ;


USE Popcornia;
CREATE TABLE Actors (
  [ActorID] int NOT NULL PRIMARY KEY IDENTITY(1,1),
  [Name] varchar(30) NOT NULL DEFAULT '',
  [BirthDate] date NOT NULL,
  [StartDate] date NOT NULL
) ;

USE Popcornia;
CREATE TABLE Composers (
  [ComposersID] int NOT NULL PRIMARY KEY IDENTITY(1,1),
  [Name] varchar(30) NOT NULL DEFAULT '',
  [BirthDate] date NOT NULL,
  [StartDate] date NOT NULL
) ;


USE Popcornia;
CREATE TABLE Directors (
  [DirectorID] int NOT NULL PRIMARY KEY IDENTITY(1,1),
  [Name] varchar(30) NOT NULL DEFAULT '',
  [BirthDate] date NOT NULL,
  [StartDate] date NOT NULL
) ;

USE Popcornia;
CREATE TABLE Producers (
  [ProducerID] int NOT NULL PRIMARY KEY IDENTITY(1,1) ,
  [Name] varchar(30) NOT NULL DEFAULT '',
  [BirthDate] date NOT NULL,
  [StartDate] date NOT NULL
) ;

USE Popcornia;
CREATE TABLE Movies (
  [MovieID] int NOT NULL PRIMARY KEY IDENTITY(1,1),
  [Name] varchar(30) NOT NULL DEFAULT '',
  [Year] date NOT NULL,
  [Genre] varchar(30) NOT NULL DEFAULT '',
  [Director_ID] int NOT NULL,
  [Producer_ID] int NOT NULL,
  [Composer_ID] int NOT NULL,
  CONSTRAINT [movies_ibfk_1] FOREIGN KEY ([Director_ID]) REFERENCES Directors ([DirectorID]) ON UPDATE CASCADE,
  CONSTRAINT [movies_ibfk_2] FOREIGN KEY ([Producer_ID]) REFERENCES Producers ([ProducerID]) ON UPDATE CASCADE,
  CONSTRAINT [movies_ibfk_3] FOREIGN KEY ([Composer_ID]) REFERENCES Composers ([ComposersID]) ON UPDATE CASCADE
) ;

USE Popcornia;
CREATE INDEX [Director_ID] ON Movies ([Director_ID]);
USE Popcornia;
CREATE INDEX [Producer_ID] ON Movies ([Producer_ID]);
USE Popcornia;
CREATE INDEX [Composer_ID] ON Movies ([Composer_ID]);




USE Popcornia;
CREATE TABLE FavActors (
  [Actor_ID] int NOT NULL,
  [User_ID] int NOT NULL,
  PRIMARY KEY ([Actor_ID],[User_ID])
 ,
  CONSTRAINT [favactors_ibfk_1] FOREIGN KEY ([Actor_ID]) REFERENCES Actors ([ActorID]) ON UPDATE CASCADE,
  CONSTRAINT [favactors_ibfk_2] FOREIGN KEY ([User_ID]) REFERENCES Users ([UserID]) ON UPDATE CASCADE
) ;

USE Popcornia;
CREATE INDEX [Actor_ID] ON FavActors ([Actor_ID]);
USE Popcornia;
CREATE INDEX [User_ID] ON FavActors ([User_ID]);

USE Popcornia;
CREATE TABLE FavMovies (
  [Movie_ID] int NOT NULL,
  [User_ID] int NOT NULL,
  PRIMARY KEY ([Movie_ID],[User_ID])
 ,
  CONSTRAINT [favmovies_ibfk_1] FOREIGN KEY ([Movie_ID]) REFERENCES Movies ([MovieID]) ON UPDATE CASCADE,
  CONSTRAINT [favmovies_ibfk_2] FOREIGN KEY ([User_ID]) REFERENCES Users ([UserID]) ON UPDATE CASCADE
) ;

USE Popcornia;
CREATE INDEX [Movie_ID] ON FavMovies ([Movie_ID]);
USE Popcornia;
CREATE INDEX [User_ID] ON FavMovies ([User_ID]);

USE Popcornia;
CREATE TABLE Rents (
  [User_ID] int NOT NULL,
  [Movie_ID] int NOT NULL,
  [StartDate] date NOT NULL,
  [ExpireDate] date NOT NULL,
  [Paid] float NOT NULL,
  PRIMARY KEY ([Movie_ID],[User_ID])
 ,
  CONSTRAINT [rents_ibfk_1] FOREIGN KEY ([Movie_ID]) REFERENCES Movies ([MovieID]) ON UPDATE CASCADE,
  CONSTRAINT [rents_ibfk_2] FOREIGN KEY ([User_ID]) REFERENCES Users ([UserID]) ON UPDATE CASCADE
) ;

USE Popcornia;
CREATE INDEX [Movie_ID] ON Rents ([Movie_ID]);
USE Popcornia;
CREATE INDEX [User_ID] ON Rents ([User_ID]);

USE Popcornia;
CREATE TABLE Roles (
  [Movie_ID] int check ([Movie_ID] > 0) NOT NULL,
  [Actor_ID] int check ([Actor_ID] > 0) NOT NULL,
  [RoleName] varchar(30) NOT NULL,
  PRIMARY KEY ([Movie_ID],[Actor_ID])
 ,
  CONSTRAINT [roles_ibfk_1] FOREIGN KEY ([Movie_ID]) REFERENCES Movies ([MovieID]) ON UPDATE CASCADE,
  CONSTRAINT [roles_ibfk_2] FOREIGN KEY ([Actor_ID]) REFERENCES Actors ([ActorID]) ON UPDATE CASCADE
) ;
USE Popcornia;
CREATE INDEX [Movie_ID] ON Roles ([Movie_ID]);
USE Popcornia;
CREATE INDEX [Actor_ID] ON Roles ([Actor_ID]);
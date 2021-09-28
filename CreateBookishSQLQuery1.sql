DROP DATABASE IF EXISTS bookish_dataBase;
CREATE DATABASE bookish_dataBase;

USE bookish_dataBase;

CREATE TABLE Books(
	BookID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	BookName VARCHAR(255) NOT NULL,
	ISBN VARCHAR(225) NOT NULL,
	Author VARCHAR(255) NOT NULL
);

CREATE TABLE Users(
	UserID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	UserName VARCHAR(255) NOT NULL

);

CREATE TABLE Copies(
	CopyID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	UserID INT,
	FOREIGN KEY (UserID) REFERENCES Users(UserID),
	BookID INT NOT NULL,
	FOREIGN KEY (BookID) REFERENCES Books(BookID),

);

CREATE TABLE Checkouts(
	CheckOutID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	UserID INT NOT NULL,
	FOREIGN KEY (UserID) REFERENCES Users(UserID),
	CopyID INT NOT NULL,
	FOREIGN KEY (CopyID) REFERENCES Copies(CopyID),
	DueDateReturn DATETIME NOT NULL
);


INSERT INTO Books(BookName,Author,ISBN) VALUES ('Object-oriented programming in Oberon-2','Hanspeter Mössenböck','3540600620');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('Java servlet programming','Jason Hunter','596000405');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('VBScript pocket reference','Matt Childs','596001266');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('Ruby in a nutshell','Yukihiro Matsumoto','596002149');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('Network Security with OpenSSL','John Viega,  Matt Messier,  Pravir Chandra','059600270X');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('TCP/IP Network Administration (3rd Edition; O''Reilly Networking)','Craig Hunt','596002971');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('Shared source CLI essentials','David Stutz','059600351X');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('sed and awk Pocket Reference','Arnold Robbins','596003528');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('sed and awk Pocket Reference','Arnold Robbins','596003528');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('Java Swing, Second Edition','James Elliott,  Marc Loy,  David Wood,  Brian Cole','596004087');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('Enterprise JavaBeans','Richard Monson-Haefel','059600530X');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('CVS Pocket Reference','Gregor Purdy,  Gregor N. Purdy','596005679');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('Essential ActionScript 3.0','Colin Moock','596006527');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('Head First design patterns','Eric Freeman, Elisabeth Robson, Bert Bates, Kathy Sierra','596007124');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('Java In A Nutshell','David Flanagan','596007736');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('Head First Object-Oriented Analysis and Design','Brett D. McLaughlin,  Gary Pollice,  Dave West','596008678');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('Switching to VoIP','Ted Wallingford','596008686');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('Enterprise JavaBeans 3.0 (5th Edition)','Bill Burke,  Richard Monson-Haefel','059600978X');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('Web Design in a Nutshell','Jennifer Niederst Robbins,  Tantek Çelik,  Derek Featherstone,  Aaron Gustafson','596009879');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('Unix in a Nutshell','Arnold Robbins','596100299');
INSERT INTO Books(BookName,Author,ISBN) VALUES ('PHP in a Nutshell','Paul Hudson,  Paul Hudson','596100671');


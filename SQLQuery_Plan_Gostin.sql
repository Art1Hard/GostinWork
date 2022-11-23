CREATE DATABASE Gostin;

CREATE TABLE ADMINS
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
    Loggin NVARCHAR(40),
    Pasword NVARCHAR(40),
    FirtName NVARCHAR(20),
    Email VARCHAR(30),
    Phone VARCHAR(20)
);

INSERT INTO ADMINS (Loggin, Pasword, FirtName, Email, Phone)
VALUES ('ArtHard','Artem500', 'Artem', '1artem1nazarov1@gmail.com', '+79967880433');
INSERT INTO ADMINS (Loggin, Pasword, FirtName, Email, Phone)
VALUES ('VladDark','Vlad500', 'Vlad', 'vladislave@gmail.com', '+79967880450');
INSERT INTO ADMINS (Loggin, Pasword, FirtName, Email, Phone)
VALUES ('admin','admin', 'admin', 'admin@gmail.com', '+5215214421');

select * from ADMINS
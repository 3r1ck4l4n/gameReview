USE MASTER

CREATE DATABASE VGAMES_REVIEW

USE VGAMES_REVIEW

CREATE TABLE VIDEO_GAMES(
ID_VIDEO_GAME INT IDENTITY(1,1) NOT NULL,
NAME_VIDEO_GAME VARCHAR(50) NOT NULL,
DESCRIPTION_VIDEO_GAME VARCHAR(150) NOT NULL,
SPECIFICATIONS_VIDEO_GAME VARCHAR(50) NOT NULL,
IMAGE_VIDEO_GAMES VARBINARY(MAX) NOT NULL);

CREATE TABLE USERS(
ID_USER INT IDENTITY(1,1) NOT NULL,
NAME_USER VARCHAR(150) NOT NULL,
PASSWORD_USER VARCHAR(50) NOT NULL,
EMAIL_USER VARCHAR(50) NOT NULL,
IMAGE_USER VARBINARY(MAX) NOT NULL);

CREATE TABLE REVIEW(
ID_REVIEW INT IDENTITY(1,1) NOT NULL,
ID_USER INT NOT NULL,
ID_VIDEO_GAME INT NOT NULL,
DESCRIPTION_REVIEW VARCHAR(150) NOT NULL,
SCORE_GAME_REVIEW INT NOT NULL
);

ALTER TABLE VIDEO_GAMES
	ADD PRIMARY KEY(ID_VIDEO_GAME);

ALTER TABLE USERS
	ADD PRIMARY KEY(ID_USER);

ALTER TABLE REVIEW
	ADD PRIMARY KEY(ID_REVIEW, ID_USER, ID_VIDEO_GAME);

ALTER TABLE REVIEW
	ADD FOREIGN KEY(ID_USER)
	REFERENCES USERS(ID_USER)
	ON UPDATE CASCADE;

ALTER TABLE REVIEW
	ADD FOREIGN KEY(ID_VIDEO_GAME)
	REFERENCES VIDEO_GAMES(ID_VIDEO_GAME)
	ON UPDATE CASCADE;
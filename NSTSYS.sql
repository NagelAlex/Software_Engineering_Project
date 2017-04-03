-- NCTSYS.sql
-- Date: 06/02/2017
-- Alexander Nagel

DROP TABLE Appointments;
DROP TABLE Registrations;
DROP TABLE Cars;
DROP TABLE Owners;
DROP TABLE Centres;
DROP TABLE MakeModels;
DROP TABLE EngineSizes;

CREATE TABLE MakeModels
(Make_Code char(2),
Make char(20),
Model char(20),
CONSTRAINT pk_Makes PRIMARY KEY (Make_Code));


INSERT INTO MakeModels
VALUES('OC','OPEL','CORSA');
INSERT INTO MakeModels
VALUES('VP','VOLKSWAGON','POLO');
INSERT INTO MakeModels
VALUES('VG','VOLKSWAGON','GOLF');
INSERT INTO MakeModels
VALUES('TC','TOYOTA','COROLLA');
INSERT INTO MakeModels
VALUES('TY','TOYOTA','YARIS');
INSERT INTO MakeModels
VALUES('B3','BMW','M3');
INSERT INTO MakeModels
VALUES('B5','BMW','M5');
INSERT INTO MakeModels
VALUES('B7','BMW','M7');
INSERT INTO MakeModels
VALUES('HC','HONDA','CIVIC');
INSERT INTO MakeModels
VALUES('HA','HONDA','ACORD');
INSERT INTO MakeModels
VALUES('FF','FORD','FIESTA');
INSERT INTO MakeModels
VALUES('FM','FORD','MONDEO');
INSERT INTO MakeModels
VALUES('OO','OPEL','OMEGA');
INSERT INTO MakeModels
VALUES('LC','LEXUS','C200');
INSERT INTO MakeModels
VALUES('LT','LEXUS','F300');

CREATE TABLE EngineSizes
(Engine_Size numeric(2,1),
CONSTRAINT pk_Engine_Size PRIMARY KEY (Engine_Size));

INSERT INTO EngineSizes
VALUES(1.0);
INSERT INTO EngineSizes
VALUES(1.1);
INSERT INTO EngineSizes
VALUES(1.2);
INSERT INTO EngineSizes
VALUES(1.3);
INSERT INTO EngineSizes
VALUES(1.4);
INSERT INTO EngineSizes
VALUES(1.5);
INSERT INTO EngineSizes
VALUES(1.6);
INSERT INTO EngineSizes
VALUES(1.8);
INSERT INTO EngineSizes
VALUES(1.9);
INSERT INTO EngineSizes
VALUES(2.0);
INSERT INTO EngineSizes
VALUES(2.2);
INSERT INTO EngineSizes
VALUES(2.4);
INSERT INTO EngineSizes
VALUES(2.5);
INSERT INTO EngineSizes
VALUES(3.0);
INSERT INTO EngineSizes
VALUES(3.5);


CREATE TABLE Cars
(Reg_No char(15) NOT NULL,
 Car_Make varchar(25) NOT NULL,
 Car_Model varchar(15) NOT NULL,
 Engine_Size numeric(2,1) NOT NULL,
 Car_Color varchar(15) NOT NULL,
 Fuel_Type varchar(15) NOT NULL,
 Car_Status char(1) NOT NULL,
 First_Reg_Date date NOT NULL,
 CurrentOwner char(8) NOT NULL,
 CONSTRAINT pk_Reg_No PRIMARY KEY (Reg_No));
 
CREATE TABLE Owners
(PPSN char(8) NOT NULL,
 Surname varchar(30) NOT NULL,
 Forename varchar(30) NOT NULL,
 DOB date NOT NULL,
 Tel_No varchar(15) NOT NULL,
 Email varchar(30) NOT NULL,
 Owner_Add1 varchar(30) NOT NULL,
 Owner_Add2 varchar(30) NOT NULL,
 Owner_County varchar(15) NOT NULL,
 CONSTRAINT pk_PPSN PRIMARY KEY (PPSN));
 
CREATE TABLE Centres
(Centre_ID numeric(2) NOT NULL,
 C_Name varchar(30) NOT NULL,
 Add1 varchar(30) NOT NULL,
 Add2 varchar(30) NOT NULL,
 Tel_No varchar(11) NOT NULL,
 Email varchar(30) NOT NULL,
 County varchar(20) NOT NULL,
 Status char (1) NOT NULL,
 CONSTRAINT pk_Centre_ID PRIMARY KEY (Centre_ID));
 
 CREATE TABLE Registrations
( Reg_No char(15) NOT NULL,
  Reg_Date date NOT NULL,
  PPSN char(8) NOT NULL,
  CONSTRAINT pk_Ownerships PRIMARY KEY (Reg_No, Reg_Date),
  CONSTRAINT fk_Ow_PPSN FOREIGN KEY (PPSN)REFERENCES Owners,
  CONSTRAINT fk_Ow_Reg_No FOREIGN KEY (Reg_No)REFERENCES Cars);
 
 CREATE TABLE Appointments
(App_ID numeric(5) NOT NULL,
 App_Time TIMESTAMP(0) NOT NULL,
 App_Date date NOT NULL,
 App_Status char(1) DEFAULT 'M' NOT NULL,--for MADE
 Reg_No char(10) NOT NULL,
 Centre_ID numeric(2) NOT NULL,
 CONSTRAINT pk_App_ID PRIMARY KEY (App_ID),
 CONSTRAINT fk_App_Reg_No FOREIGN KEY (Reg_No)REFERENCES Cars,
 CONSTRAINT fk_App_Centre_ID FOREIGN KEY (Centre_ID)REFERENCES Centres);
 
COMMIT;
 
 
INSERT INTO CARS
VALUES ('06-KY-27374','Toyota','Corolla',1399,'Black','A','21-DEC-2006');

SELECT * FROM Cars;

INSERT INTO OWNERS
VALUES ('9897778K','Alexander','Nagel','21-DEC-1980','0872251511','hgyusgd.hgdws@gmail.com','5 Ath Solas','Milltown','Co.Kerry');

SELECT * FROM Owners;

INSERT INTO Registrations
VALUES ('06-KY-27374','09-FEB-2017','9897778K');

SELECT * FROM Registrations
WHERE REG_NO = '06-KY-27374';
 
INSERT INTO CARS
VALUES ('06-KY-274','Opel','Omega',2499,'Gold','A','21-DEC-2001');

INSERT INTO OWNERS
VALUES ('9897178K','Declan','Buckley','21-DEC-1979','0872567551','hgyusgd.hgdws@gmail.com','5 Ath Solas','Milltown','Co.Kerry');

INSERT INTO Registrations
VALUES ('06-KY-27374','13-FEB-2017','9897178K');

SELECT * FROM REGISTRATIONS
ORDER BY REG_DATE DESC;

SELECT MAX(Reg_Date) FROM REGISTRATIONS
WHERE REG_NO = '00-D-00';

SELECT * from CARS;
SELECT * from Owners;

SELECT DISTINCT Make
FROM MakeModels
ORDER BY Make;

SELECT Model
FROM MakeModels
WHERE Make = 'OPEL';

SELECT *
FROM EngineSizes;


SELECT Reg_No,CAR_MAKE as MAKE,CAR_MODEL as MODEL ,First_Reg_Date, SURNAME, FORENAME, EMAIL
FROM CARS C, OWNERS O 
WHERE O.PPSN = C.CURRENTOWNER AND
      TRUNC(Add_Months(First_Reg_Date,48)) = TRUNC(Add_Months(SYSdate,1)) OR
      TRUNC(Add_Months(First_Reg_Date,72)) = TRUNC(Add_Months(SYSdate,1)) OR
      TRUNC(Add_Months(First_Reg_Date,96)) = TRUNC(Add_Months(SYSdate,1)) OR
      TRUNC(Add_Months(First_Reg_Date,120)) = TRUNC(Add_Months(SYSdate,1)) OR
      TRUNC(Add_Months(First_Reg_Date,132)) = TRUNC(Add_Months(SYSdate,1));
      
      
SELECT Reg_No,First_Reg_Date
FROM Cars
WHERE TRUNC(Add_Months(First_Reg_Date,48)) = TRUNC(Add_Months(SYSdate,1)) OR
      TRUNC(Add_Months(First_Reg_Date,72)) = TRUNC(Add_Months(SYSdate,1)) OR
      TRUNC(Add_Months(First_Reg_Date,96)) = TRUNC(Add_Months(SYSdate,1)) OR
      TRUNC(First_Reg_Date) >= TRUNC(Add_Months(SYSdate,-133)) ;
      
SELECT * FROM CARS;
SELECT * FROM REGISTRATIONS;

INSERT INTO CARS
VALUES ('07-G-35543','BMW','M5',2.2,'Petrol','Gold','A','30-APR-2007');

COMMIT;
SELECT REG_NO, FORENAME, SURNAME, EMAIL
FROM Registrations R, OWNERS O
WHERE R.PPSN = O.PPSN     
GROUP BY REG_NO, FORENAME, SURNAME, EMAIL
HAVING Add_Months((MAX(Reg_Date)),12) = (SELECT TO_CHAR(SYSDATE,'DD-MON-YY') FROM DUAL);

SELECT REG_NO, FORENAME, SURNAME, EMAIL
FROM Registrations R, OWNERS O
WHERE R.PPSN = O.PPSN  AND  (SELECT MAX(Reg_Date) = Add_Months(SYSDATE,-1);


GROUP BY REG_NO, FORENAME, SURNAME, EMAIL;


HAVING Add_Months((MAX(Reg_Date)),12) = (SELECT TO_CHAR(SYSDATE,'DD-MON-YY') FROM DUAL);



SELECT * FROM OWNERS;  

SELECT MAX(Reg_Date)
FROM Registrations;

SELECT TO_CHAR(SYSDATE,'DD-MON-YY') "NOW"
FROM DUAL;


SELECT * FROM Registrations, OWNERS
JOIN(
    SELECT REG_NO, REG_DATE FROM Registrations
    GROUP BY REG_NO, REG_DATE;
    ) OWNERS
    ON 
    
      

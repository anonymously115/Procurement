sqlplus / as sysdba

SQL> ALTER SESSION SET CONTAINER=FREEPDB1;
SQL> CREATE USER procurement IDENTIFIED BY procurement DEFAULT TABLESPACE users TEMPORARY TABLESPACE temp QUOTA UNLIMITED ON users PROFILE default;
SQL> GRANT CREATE SESSION TO procurement;
SQL> GRANT CREATE TABLE TO procurement;
SQL> GRANT CREATE SEQUENCE TO procurement;
SQL> DROP USER procurement CASCADE;

sqlplus procurement/procurement@FREEPDB1

-- makemigrations
Add-Migration InitialCreate

-- migrate
Update-Database

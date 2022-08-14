https://www.c-sharpcorner.com/article/working-with-json-in-C-Sharp/


                           SQLSERVER JSON OPERATIONS
                           ----------------------------
                           
                           
                           


TO READ COMPLEX JSON IN SQLSERVER
----------------------------------

DECLARE @json NVARCHAR(MAX) = N'[  
  {  
    "Order": {  
      "Number":"SO43659",  
      "Date":"2011-05-31T00:00:00"  
    },  
    "AccountNumber":"AW29825",  
    "Item": {  
      "Price":2024.9940,  
      "Quantity":1  
    }  
  },  
  {  
    "Order": {  
      "Number":"SO43661",  
      "Date":"2011-06-01T00:00:00"  
    },  
    "AccountNumber":"AW73565",  
    "Item": {  
      "Price":2024.9940,  
      "Quantity":3  
    }  
  }
]'  
   
SELECT *
FROM OPENJSON ( @json )  
WITH (   
              Number   VARCHAR(200)   '$.Order.Number',  
              Date     DATETIME       '$.Order.Date',  
              Customer VARCHAR(200)   '$.AccountNumber',  
              Quantity INT            '$.Item.Quantity'  
              --,[Order]  NVARCHAR(MAX)  AS JSON  
 )


                                                                            TO READ SIMPLE JSON FILES
                                                                            --------------------------
                                                                            
create table #tempjson(Firstname varchar(200),Lastname varchar(200),Gender varchar(200),AGE int) 

DECLARE @json nvarchar(max) = N'[{"Firstname": "ROMY", "Lastname": "KUMARI", "Gender": "female", "AGE" : 22 },
{"Firstname": "PUSHKAR", "Lastname": "JHA", "Gender": "male", "AGE" : 22 },
{"Firstname": "SHALINI", "Lastname": "JHA", "Gender": "female", "AGE" : 21 },
{"Firstname": "SAMBHAVI", "Lastname": "JHA", "Gender": "female", "AGE" : 18 } ]'

 insert into #tempjson

 select * from openjson(@json)
 WITH  (
   [Firstname] varchar(20),  
   [Lastname] varchar(20),  
   [Gender] varchar(20),  
   [AGE] int );                                                                    
                                                                            
                                                                           
                                                                            
                                                                            
                                                                            
                                                                            
                                                                            
                                                                            
                                                                            
                                                                            
                                                                            
                                                                            
                                                                            
                                                                            
                                                                            
                                                                            
                                                                            
                                                                            
                                                                            
                                                                            

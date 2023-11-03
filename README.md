project- shoses store  
האתר הוא חנות נעליים.   
האתר מספק לנו את רשימת הספקים, רשימת ההזמנות ורשימת המוצרים  
האתר שימושי עבור עובדי החנות ולא עבור לקוחות  
table 1: products  
מוצרי החנות : id,name,company,CountUnitsInStock  
get-          https://shosesStore/api/products                         ----מחזיר את כל המוצרים  
get(id)-    https://shosesStore/api/products/{id}                 ----מחזיר מוצר מסוים      
post-        https://shosesStore/api/products                         ----מוסיף מוצר  
put-          https://shosesStore/api/products/{id}                  ----מעדכן מוצר מסוים  
delete-    https://shosesStore/api/products/{id}                  ----מוחק מוצר מסוים  
put(cnt)   https://shosesStore/api/products/{id}/cnt          ----מעדכן את כמות במלאי של מוצר מסוים  
table 2: orders  
רשימת ההזמנות: Id,Name,Email,phone,city,Street,BuildingNumber,Product  
get-          https://shosesStore/api/orders                        ----מחזיר את כל רשימת ההזמנות  
get(id)-    https://shosesStore/api/orders/{id}                ----מחזיר הזמנה מסוימת   
post-        https://shosesStore/api/orders                        ----מוסיף הזמנה  
put-          https://shosesStore/api/orders/{id}                ----מעכן הזמנה מסוימת  
delete-    https://shosesStore/api/orders/{id}                ----מוחק הזמנה מסוימת  
get(id)-   https://shosesStore/api/orders/{id}/status  ----מחזיר מצב של הזמנה מסוימת  
table 3: pruviders  
ספקי החנות:Id,Name,Email,phone  
get-          https://shosesStore/api/pruviders                  ----מחזיר את כל הספקים  
get(id)-    https://shosesStore/api/pruviders/{id}          ----מחזיר ספק מסוים  
post-        https://shosesStore/api/pruviders                  ----- מוסיף ספק  
put-          https://shosesStore/api/pruviders/{id}          -----מעדכן ספק מסוים  
delete-    https://shosesStore/api/pruviders/{id}          -----מוחק ספק מסוים  
get-          https://shosesStore/api/products/name        ----מחזיר את שמות כל הספקים  


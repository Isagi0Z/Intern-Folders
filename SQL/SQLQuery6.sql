select * from salesman;
select * from customer;
select * from Orders;

select name,commission from salesman;

select DISTINCT salesman_id from orders;

select name,city 
from salesman 
where city='paris';


select * from customer
where grade=200;

select order_no,order_date,purch_amt 
from Orders
where salesman_id=5001;




select * from customer where customer_name LIKE '%n';



select * from Salesman
where name LIKE 'N__I%';


select SUM(purch_amt) as Total_purchase_amt 
from orders;

select COUNT(DISTINCT salesman_id) as salesman_currently_listing_for_all_of_their_customers from orders;



SELECT city, MAX(grade) as maximum_grade
FROM customer
GROUP BY city;







select customer_id, MAX(purch_amt) as Max_Purchase_amt
from orders 
group by customer_id;

select salesman_id,max(purch_amt)
from orders 
where order_date='2012-08-17'
group by salesman_id;

select count(*) as order_count
from orders
where order_date='2016-08-17';


select c.customer_name,c.city,s.name
from customer as c JOIN salesman as s
ON c.city=s.city;


select c.customer_name,s.name
from customer as c JOIN salesman as s 
ON c.salesman_id=s.salesman_id;

SELECT 
  o.order_no,
  c.customer_name,
  c.city AS customer_city,
  s.name AS salesman_name,
  s.city AS salesman_city
FROM 
  orders AS o
JOIN 
  customer AS c ON o.customer_id = c.customer_id
JOIN 
  salesman AS s ON o.salesman_id = s.salesman_id
WHERE 
  c.city <> s.city;




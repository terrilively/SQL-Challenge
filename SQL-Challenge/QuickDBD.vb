# Modify this code to update the DB schema diagram.
# To reset the sample schema, replace everything with
# two dots ('..' - without quotes).

titles
-
title_id VARCHAR PK
title VARCHAR
 
employee
-
emp_no INT PK
emp_title_id VARCHAR FK - titles.title_id
birth_date DATE
first_name VARCHAR
last_name VARCHAR
sex VARCHAR
hire_date DATE

departments
-
dept_no VARCHAR PK
dept_name VARCHAR

dept_manager
-
dept_no VARCHAR PK FK - departments.dept_no
emp_no INT PK FK - employee.emp_no

dept_emp
-
emp_no INT PK FK - employee.emp_no
dept_no VARCHAR PK FK - departments.dept_no

salaries
-
emp_no INT PK FK - employee.emp_no
salary INT




SELECT * FROM departments;
SELECT * FROM employee_details;
SELECT * FROM employees;

SELECT employees.name AS name, departments.name AS departments
FROM employees
JOIN departments
WHERE department_id = departments.id;

SELECT employees.name AS name, departments.name AS departments
FROM employees
LEFT JOIN departments
WHERE department_id = departments.id;

SELECT employees.name AS name, departments.name AS departments
FROM employees
CROSS JOIN departments;
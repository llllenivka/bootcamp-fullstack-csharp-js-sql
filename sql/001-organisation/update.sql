SELECT * FROM employees;

UPDATE employees 
SET position='Тестировщик', salary = ROUND(salary * 1.15) + 100000
WHERE id=5;
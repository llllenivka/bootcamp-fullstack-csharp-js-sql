SELECT department_id, name
FROM employees
WHERE department_id = 
    (SELECT id FROM departments
        WHERE name = 'Отдел разработки');

SELECT * FROM departments;
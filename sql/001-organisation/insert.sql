INSERT INTO employees (id,name, position,salary, email)
VALUES (1,'Иван Иванов','Менеджер',50000.0,'ivan.ivanov@gmail.com');

INSERT INTO employees (id,name,position,salary,email)
VALUES (2,'Анна Смирнова','Разработчик',60000.0,'anna.smirnova@example.com'),(3,'Петр Петров','Аналитик',55000.0,'petr.petrov@example.com');

INSERT INTO employees (name,position,salary,email)
VALUES ('Елена Кузнецова','Тестировщик',48000.0,'elena.kuznetsova@example.com');

INSERT INTO employees (name,salary,email)
VALUES ('Максим Соколов',52000.0,'maxim.sokolov@example.com');

SELECT * FROM employees;

INSERT INTO employee_details (id, employee_id, address, phone, age) VALUES 
(1, 3, 'ул. Ленина, д. 1, кв. 101, Москва', '+7-999-123-4567', 35),
(2, 5, 'ул. Пушкина, д. 2, кв. 202, Санкт-Петербург', '+7-999-234-5678', 29),
(3, 4, 'ул. Чехова, д. 3, кв. 303, Новосибирск', '+7-999-345-6789', 40),
(4, 1, 'ул. Толстого, д. 4, кв. 404, Екатеринбург', '+7-999-456-7890', 25),
(5, 2, 'ул. Тургенева, д. 5, кв. 505, Смоленск', '+7-999-567-8901', 32);

SELECT * FROM employee_details;

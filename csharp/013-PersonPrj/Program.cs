Student student1 = new Student("Мира Д.", 15, "№121");
Teacher teacher1 = new Teacher("Анна П.", 26, "math");
Employer employer1 = new Employer("Лада З.", 33, 23000);

Repository repository = new Repository(10);

repository.Append(student1, teacher1, employer1);


Printer printer = new();

printer.Print(repository);

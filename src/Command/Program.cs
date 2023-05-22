﻿using Command;

Console.Title = "Command";

CommandManager commandManager = new();
IEmployeeManagerRepository repository = new EmployeeManagerRepository();

commandManager.Invoke(
    new AddEmployeeToManagerList(repository, 1, new Employee(111, "Roberta")));
repository.WriteDataStore();

commandManager.Undo();
repository.WriteDataStore();

commandManager.Invoke(
    new AddEmployeeToManagerList(repository, 1, new Employee(222, "Clara")));
repository.WriteDataStore();

commandManager.Invoke(
    new AddEmployeeToManagerList(repository, 2, new Employee(333, "Tammy")));
repository.WriteDataStore();

// try adding the same employee again
commandManager.Invoke(
    new AddEmployeeToManagerList(repository, 2, new Employee(333, "Tammy")));
repository.WriteDataStore();

commandManager.UndoAll();
repository.WriteDataStore();

Console.ReadKey();
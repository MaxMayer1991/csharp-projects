﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FirstRazorApp.Models;

namespace FirstRazorApp.AppRepository
{
    public class MockEmploeeRepository : IEmpoyeeRepository
    {
        private List<Employee> _peopleList;

        public MockEmploeeRepository()
        {
            _peopleList = new List<Employee>()
            {
                new Employee()
                    {Id = 0, Name = "Mary", Email = "example@example.com", PotoPath = "avatar2.png", Stan = Dept.Student},
                new Employee()
                    {Id = 1, Name = "Mark", Email = "example1@example.com", PotoPath = "avatar.png", Stan = Dept.It},
                new Employee()
                    {Id = 2, Name = "Kolyan", Email = "demonick@example.com", PotoPath = "avatar4.png", Stan = Dept.It},
                new Employee()
                    {Id = 3, Name = "Shawn", Email = "example2@example.com", PotoPath = "avatar5.png", Stan = Dept.Staly},
                new Employee()
                    {Id = 4, Name = "Jeniffer", Email = "example3@example.com", PotoPath = "avatar3.png", Stan = Dept.Student},
                new Employee()
                    {Id = 5, Name = "Sten", Email = "example4@example.com", Stan = Dept.Staly}
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _peopleList;
        }

        public Employee GetEmployee(int id)
        {
            return _peopleList.FirstOrDefault(x => x.Id == id);
        }

        public Employee Update(Employee updatedEmployee)
        {
            // Получаем из списка нужного работника для обновления
            Employee employee = _peopleList.FirstOrDefault(x => x.Id == updatedEmployee.Id);

            // Проверяем результат на NULL
            if (employee != null)
            {
                employee.Name = updatedEmployee.Name;
                employee.Email = updatedEmployee.Email;
                employee.Stan = updatedEmployee.Stan;
                employee.PotoPath = updatedEmployee.PotoPath;
            }

            return employee;
        }

        // Метод добавления нового работника
        public Employee Add(Employee newEmployee)
        {
            // Присваиваем ID новому работнику
            if (_peopleList.Count > 0)
                newEmployee.Id = _peopleList.Max(x => x.Id) + 1;
            else
                newEmployee.Id = 1;

            // Добавляем нового работника в лист
            _peopleList.Add(newEmployee);

            // Возвращаем нового работника
            return newEmployee;
        }

        // Удаляем работника
        public Employee Delete(int id)
        {
            Employee employeeToDelete = _peopleList.FirstOrDefault(x => x.Id == id);

            if (employeeToDelete != null)
                _peopleList.Remove(employeeToDelete);

            return employeeToDelete;
        }

        public IEnumerable<DeptHeadCount> EmployeeCountByDept(Dept? dept)
        {
            IEnumerable<Employee> query = _peopleList;

            if (dept.HasValue)
            {
                query = query.Where(e => e.Stan == dept.Value);
            }

            return query.GroupBy(x => x.Stan)
                .Select(p => new DeptHeadCount()
                {
                    Stan = p.Key.Value,
                    Count = p.Count()
                }).ToList();
        }

        // Метод поиска пользователей
        public IEnumerable<Employee> Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return _peopleList;
            }
            return _peopleList.Where(x => x.Name.Contains(searchTerm) || 
                                          x.Email.Contains(searchTerm));
        }
    }
}

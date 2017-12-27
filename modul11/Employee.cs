using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace modul11
{
    public struct Employee
    {
        public string Name { get; set; }
        public Vacancies Vacancie { get; set; }
        public int Payment { get; set; }
        public DateTime dateOfGettingTheJob { get; set; }


        public Employee(string name, int payment, Vacancies vacancie, DateTime _dateOfGettingTheJob)
        {
            Name = name;
            Payment = payment;
            Vacancie = vacancie;
            dateOfGettingTheJob = _dateOfGettingTheJob;
        }
        public void show(int numberOfEmployee)
        {
            Write(numberOfEmployee+":");
            WriteLine("Имя"+Name);
            WriteLine("Зарплата"+Payment);
            WriteLine("Вакансия"+Vacancie);
            WriteLine("Дата приема на работу"+dateOfGettingTheJob);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace modul11
{

        class Program
        {          
           static void Main(string[] args)
        { 
                int mainPayment = 0;
                int length = 0;
                string nameOfEmployee;
                int paymentOfEmployee;
                string vacancie;
                int counterOfBosses = 0;
                int countOfClerks = 0;
                DateTime dateOfGettingTheJob;
                DateTime dateOfGettingTheJobByBoss=DateTime.Now;
                
            /////////////////////////////////////////////////
            WriteLine("Введите кол-во сотрудников ");
                while (!int.TryParse(ReadLine(), out length))
                {
                    Clear();
                    Write("Ошибка, введите целое число: ");
                }
                int[] ArrayOfEmployees = new int[length];
                Employee[] employeers = new Employee[length];
                WriteLine("Заполните поля для получения информации о сотруднике.");
                for (int i = 0; i < ArrayOfEmployees.Length; i++)
                {
                   
                    WriteLine("Введите имя сотрудника.");
                    nameOfEmployee = ReadLine();
                    WriteLine("Введите зарплату сотрудника.");
                    while (!int.TryParse(ReadLine(), out paymentOfEmployee))
                    {
                        Clear();
                        Write("Ошибка, введите целое число: ");
                    }
                WriteLine("Введите дату получения работы этим сотрудником");
                while (!DateTime.TryParse(ReadLine(), out dateOfGettingTheJob))
                {
                    Clear();
                    Write("Ошибка, введите дату: ");
                }
                WriteLine("Введите вакансию сотрудника.");
                    vacancie = ReadLine();
                    if (vacancie == "Boss")
                    {
                        if (counterOfBosses >= 1)
                        {
                            WriteLine("Error(Босс только один.)");
                            break;
                        }
                        else
                        {
                        
                            employeers[i] = new Employee(nameOfEmployee, paymentOfEmployee, Vacancies.Boss,dateOfGettingTheJobByBoss);
                        
                            counterOfBosses++;
                        }
                    }
                    else if (vacancie == "Clerk")
                    {
                        employeers[i] = new Employee(nameOfEmployee, paymentOfEmployee, Vacancies.Clerk, dateOfGettingTheJob);
                    }
                    else if (vacancie == "Manager")
                    {
                        employeers[i] = new Employee(nameOfEmployee, paymentOfEmployee, Vacancies.Manager, dateOfGettingTheJob);
                    }
                Clear();
                }
            
                //Вывод сотрудников
                ///////////////////////////
                for (int j = 0; j < employeers.Length; j++)
                {
                    employeers[j].show(j);
                }
                //////////////////////////
                for (int i = 0; i < employeers.Length; i++)
                {

                    if (employeers[i].Vacancie == Vacancies.Clerk)
                    {
                        mainPayment = mainPayment + employeers[i].Payment;
                    countOfClerks++;
                    }


                }
                mainPayment = mainPayment / countOfClerks;//Средняя зарплата
            ////////////////////////////////////////////////////
                Write("Средняя зарплата клерков:" + mainPayment);
                for (int i = 0; i < employeers.Length; i++)
                {
                    if (employeers[i].Vacancie == Vacancies.Manager)
                    {
                        if (employeers[i].Payment > mainPayment)
                        {
                            employeers[i].show(i);
                        }
                    }

                }
            WriteLine(dateOfGettingTheJobByBoss);
                ///////////////////////////////////////////////////////
                for(int i=0;i<employeers.Length;i++)
                {
                if(employeers[i].dateOfGettingTheJob<dateOfGettingTheJobByBoss)
                {
                    employeers[i].show(i);
                }
                }
                ReadLine();

            }
        }
    }

  


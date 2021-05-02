using System;
using System.Collections.Generic;
namespace EXERCISE__03___LIST_M._06{
    //-----> START
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program{
        static void Main(string[] args){
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine()); //-----------> ADD o TAMANHO DA LISTA
            List<Employee> list = new List<Employee>(); //-----------> Chamada do CONSTRUTOR na LISTA
            for (int i = 1; i <= n; i++){
                Console.WriteLine("Employee #"+i+ ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employee(id, name, salary)); //-----------> ADD os ELEMENTOS do construtor na LISTA 
                Console.WriteLine();
            }
            Console.WriteLine("Enter the employee Id that will have salary increase : ");
                int searchId = int.Parse(Console.ReadLine());
            Employee emp = list.Find(x => x.Id == searchId);
                if (emp != null){
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentage); //-----------> Chamada do METODO DO CONSTRUTOR 
                }              
            else{
                Console.WriteLine("This Id does not existe!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
                foreach (Employee obj in list){  //-----------> PRINTA a LISTA no console
                Console.WriteLine(obj);
                }         
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}

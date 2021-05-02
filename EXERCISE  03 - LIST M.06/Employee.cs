using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE__03___LIST_M._06{
    //------------------------------- START -------------------------------//
    class Employee{
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }
        //------------------------- CONSTRUCTORS ------------------------- //
        public Employee(int id, string name, double salary){
            Id = id;
            Name = name;
            Salary = salary;
        }
        //------------------------- CLASS |  MET --------------------------//
        public void IncreaseSalary(double percentage){
            Salary += Salary * percentage / 100.0;
        }
        public override string ToString(){
            return Id
                + ", " + Name + ", " + Salary.ToString("F2");
        }
        //-------------------------------- END -------------------------------//
    }
}






//using Dll_Methods.AccessModifiers;
//using Dll_Methods.Praktika;

////2)Calculator adinda class yaradirsiz,
////    hemin classin icinde Calculation metodunuz olur. 
////    Method 2 parametr qebul edir. 4 emeliyyati (+,-,*,/)hesablayan calculator olacaq.

//Calculation calculation = new Calculation() 
////{ 
////    n=9,
//      m=10
////};





















//using Dll_Methods.AccessModifiers;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Dll_Methods.AccessModifiers;
//using Dll_Methods.Praktika;
//using System.Numerics;
//using System.Runtime.InteropServices;


//task(3.Employee)


//3)  Employee tipinden array olacaq. Employee clasinda name, surname, age, salary propertileri olmalidir. 
//    Maashi 1000 - 2000 arasinda olan employee-lerin melumatlarini ekranda gosteren method yazin.
//    (1000 ve 2000 deyerleri methoda argument kimi gondermelidir)

//Employee emp1 = new Employee()
//{
//    Name = "Ali",
//    Surname = "Aliyev",
//    Age = 45,
//    Salary = 1500
//};

//Employee emp2 = new Employee()
//{
//    Name = "Nicat",
//    Surname = "Qasanov",
//    Age = 25,
//    Salary = 1200
//};

//Employee emp3 = new Employee()
//{
//    Name = "Qadir",
//    Surname = "Qadirov",
//    Age = 22,
//    Salary = 5
//};

//Employee emp4 = new Employee()
//{
//    Name = "Hesen",
//    Surname = "Hesenov",
//    Age = 35,
//    Salary = 1800
//};



//Employee[] people = { emp1, emp2, emp3, emp4 };


//GetEpmloyeeBySalary(people);



//static void GetEpmloyeeBySalary(Employee[] people)
//{

//    foreach (var item in people)
//    {
//        if (item.Salary > 1000) ;
//        {
//            Console.WriteLine($" {item.Name} - {item.Surname} - {item.Age} - {item.Salary} ");

//        }


//    }

//}







///////////////////////////////////////////////////////////



//4) Doctor adinda class olacaq, Doctor clasinin name, surname, address, birthday propertileri olacaq. 
////    Dogum tarixi 25.05.1993 - 15.12.2002 arasinda olan doctor-larin siyahisini ekranda gosteren method yazin.
////    (25.05.1993  ve 15.12.2002 deyerleri methoda argument kimi gonderilecek)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

using Dll_Methods.AccessModifiers;



Doctor doctor = new Doctor()
{

    Name="Nadir",
    Surname= "Hemidov",
    Age = 25,
    Birthday=1995

};





//task (1Person Practik)...............




//Person person1 = new Person()
//{
//    Name = "Hesen",
//    Surname = "Hesenov",
//    Age = 26,


//};

//Person person2 = new Person()
//{
//    Name = "Talib",
//    Surname = "Talibov",
//    Age = 25,


//};

//Person person3 = new Person()
//{
//    Name = "Samir",
//    Surname = "Hesenov",
//    Age = 18,


//};

//Person person4 = new Person()
//{
//    Name = "Qadir",
//    Surname = "Hesenov",
//    Age = 22,


//};

//Person[] people = { person1, person2, person3, person4 };

//GetPersonByAge(people);

//static void GetPersonByAge(Person[] people)
//{
//    foreach (var item in people)
//    {
//        if (item.Age > 20)
//        {
//            Console.WriteLine($"{item.Name} - {item.Surname} - {item.Age} ");
//        }
//    }
//}

///////////////////////////////////////////////////////////////////////

//using Dll_Methods.Praktika;
/////
//Student student = new Student()
//{
//    Name = "Cavid",
//    Surname = "Ismayilzade",
//    Address = "Sulutepe",
//    Age = 30




//};


//Student student2 = new Student()
//{
//    Name = "Hesen",
//    Surname = "Ismayilzade",
//    Address = "Sulutepe",
//    Age = 30

//};

//Student student3 = new Student()
//{
//    Name = "Celil",
//    Surname = "Ismayilzade",
//    Address = "Sulutepe",
//    Age = 22

//};


//Student student4 = new Student()
//{
//    Name = "Qadir",
//    Surname = "Ismayilzade",
//    Address = "Sulutepe",
//    Age = 19

//};

//Student[] students = { student, student2, student3, student4 };
//Search(students);
   


//static void Search(Student[] students)
//{
//    string searchText = "C";

//    foreach (var item in students)
//    {

//        if (item.Name.ToLower().Contains(searchText.ToLower()) || item.Surname.ToLower().Contains(searchText.ToLower()))
//        {
//            Console.WriteLine(item.Name + " " + item.Surname);
//        }
//    }



//}

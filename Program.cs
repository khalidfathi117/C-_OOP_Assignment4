using Assignment_9.Demo.ICloneable_and_IComparable_Example;
using Assignment_9.Demo.ISeries_Example;
using Assignment_9.Demo.Vehicles_Example;
using Assignment_9.Question_1;
using Assignment_9.Question_2;
using Assignment_9.Question_3;

namespace Assignment_9
{
    internal class Program
    {
        public static void Print10NumbersFromSeries(ISeries series)
        {
            if (series == null)
                return;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Current}\t");
                series.getNext();
            }
            series.Reset();
        }
        static void Main(string[] args)
        {

            #region Part 1 (Demo)

            #region ISeries Example
            //ISeries seriesByTwo = new SeriesByTwo();
            //ISeries seriesByThree = new SeriesByThree();
            //ISeries seriesByFour = new SeriesByFour();
            //Print10NumbersFromSeries(seriesByFour);
            #endregion

            #region (Implicit vs Explicit) Interface Methods Implementation
            //// Implicit (Won't work as I defined the methods explicitly
            ////Airplane airplane = new Airplane();
            ////airplane.Forward();

            //IMovable airplaneMoving = new Airplane();
            //IFlyable airplaneFlying = new Airplane();

            //airplaneMoving.Forward();
            //airplaneFlying.Forward();
            #endregion

            #region (Shallow Copy vs Deep Copy) in Array of Value Type
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //Console.WriteLine($"HashCode Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HashCode Arr02 = {Arr02.GetHashCode()}");

            #region Shallow Copy
            //Arr02 = Arr01;
            //// object {1,2,3} has now 2 references pointing towards it
            //// object {4,5,6} is an unreachable object
            //Console.WriteLine("After Shallow Copy");

            //Console.WriteLine($"HashCode Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HashCode Arr02 = {Arr02.GetHashCode()}");

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]);
            #endregion

            #region Deep Copy
            //Arr02 = (int[])Arr01.Clone();
            //// object {1,2,3} has now two different copies with two different references but with the same value
            //// object {4,5,6} is an unreachable object
            //Console.WriteLine("After Deep Copy");

            //Console.WriteLine($"HashCode Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HashCode Arr02 = {Arr02.GetHashCode()}");

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);
            #endregion

            #endregion

            #region (Shallow Copy vs Deep Copy) in Array of (Immutable) Ref Type
            //string[] Name01 = new string[] { "Omar" };
            //string[] Name02 = new string[1];

            //Console.WriteLine($"HashCode Name01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HashCode Name02 = {Name02.GetHashCode()}");

            #region Shallow Copy
            //Name02 = Name01;
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"HashCode Name01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HashCode Name02 = {Name02.GetHashCode()}");

            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            //Name02[0] = "Mona";

            //Console.WriteLine("After Change");
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);
            #endregion

            #region Deep Copy
            //Name02 = (string[])Name01.Clone();
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HashCode Name01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HashCode Name02 = {Name02.GetHashCode()}");

            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            //Name02[0] = "Mona";

            //Console.WriteLine("After Change");
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);
            #endregion

            #endregion

            #region (Shallow Copy vs Deep Copy) in Array of (Mutable) Ref Type
            //StringBuilder[] Name01 = new StringBuilder[1];
            //Name01[0] = new StringBuilder("Omar");
            //StringBuilder[] Name02 = new StringBuilder[1];

            //Console.WriteLine($"HashCode Name01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HashCode Name02 = {Name02.GetHashCode()}");

            #region Shallow Copy
            //Name02 = Name01;
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"HashCode Name01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HashCode Name02 = {Name02.GetHashCode()}");

            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            //Name02[0].Append(" Ahmed");

            //Console.WriteLine("After change");
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);
            #endregion

            #region Deep Copy
            //Name02 = (StringBuilder[])Name01.Clone();
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HashCode Name01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HashCode Name02 = {Name02.GetHashCode()}");

            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            //Name02[0].Append(" Ahmed");
            //Console.WriteLine("After Change");
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);
            #endregion

            #endregion

            #region ICloneable Example
            //Employee emp01 = new Employee()
            //{
            //    Id = 1,
            //    Name = "Ali",
            //    Salary = 2000,
            //    Department = new Department() { Id = 100, Name = "HR" },
            //};
            //Employee emp02 = new Employee()
            //{
            //    Id = 2,
            //    Name = "Khalid",
            //    Salary = 7000
            //};
            //Console.WriteLine($"Hashcode of emp01 = {emp01.GetHashCode()}");
            //Console.WriteLine($"Hashcode of emp02 = {emp02.GetHashCode()}");

            //Employee emp03 = emp01; //Shallow Copy 

            //emp03 = (Employee)emp01.Clone(); // Deep Copy

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Hashcode of emp01 = {emp01.GetHashCode()}");
            //Console.WriteLine($"Hashcode of emp02 = {emp03.GetHashCode()}");

            //emp03.Department.Name = "Sales";

            //Console.WriteLine(emp01);
            //Console.WriteLine(emp03);
            #endregion

            #region IComparable Example
            //int[] Numbers = { 7, 2, 1, 6, 9, 8, 4, 3 };

            //Array.Sort(Numbers);

            //Employee[] employees =
            //{
            //    new Employee() { Id = 10, Name = "Khalid", Salary = 1000, Department = new Department { Id = 1, Name = "HR" } },
            //    new Employee() { Id = 20, Name = "Mohammed", Salary = 5000, Department = new Department { Id = 1, Name = "IT" } },
            //    new Employee() { Id = 30, Name = "Fathi", Salary = 2000, Department = new Department { Id = 1, Name = "HR" } },
            //    new Employee() { Id = 50, Name = "Hamada", Salary = 3000, Department = new Department { Id = 1, Name = "IT" } }
            //};

            //Array.Sort(employees);

            //foreach (int num in Numbers)
            //{
            //    Console.Write($"{num} ");
            //}

            //Console.WriteLine();

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion

            #endregion

            #region Part 2 (MCQ)
            // (1)
            // answer : b (To define a blueprint for a class)
            // (2)
            // answer : b (private)
            // (3)
            // answer : b (No)
            // (4)
            // answer : b (Yes, interfaces can inherit from multiple interfaces)
            // (5)
            // answer : d (implements)
            // (6)
            // answer : a (Yes)
            // (7)
            // answer : a (Yes, for all members)
            // (8)
            // answer : b (To provide a clear separation between interface and class members)
            // (9)
            // answer : b (No, interfaces cannot have constructors)
            // (10)
            // answer : c (By separating interface names with commas)
            #endregion

            #region Part 3

            #region Question 1
            //IShape rectangle = new Rectangle();
            //rectangle.Area = 50.56;
            //rectangle.DisplayShapeInfo();

            //IShape circle = new Circle();
            //circle.Area = 30.4;
            //circle.DisplayShapeInfo();
            #endregion

            #region Question 2
            //IAuthenticationService authService = new BasicAuthenticationService();
            //// Authenticated User
            //Console.WriteLine(authService.AuthenticateUser("Khalid", "khalid123"));
            //// Non-Authenticated User
            //Console.WriteLine(authService.AuthenticateUser("mohammed", "1234"));
            //// --------------------------------------------------------------------
            //// Authorized User
            //Console.WriteLine(authService.AuthorizeUser("Khalid" , "Admin"));
            //// Non-Authenticated User
            //Console.WriteLine(authService.AuthorizeUser("Mohammed", "Admin"));
            #endregion

            #region Question 3
            //INotificationService SMS = new SmsNotificationService();
            //INotificationService PushNotification = new PushNotificationService();
            //INotificationService Email = new EmailNotificationService();

            //SMS.SendNotification("Khalid", "I love C#");
            //Console.WriteLine();
            //Email.SendNotification("Mohammed", "I am an Engineer");
            //Console.WriteLine();
            //PushNotification.SendNotification("Fathi", "I am a Backend Developer");
            #endregion

            #endregion

        }
    }
}

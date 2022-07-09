using Classes_Exercise_01;
using System;

namespace Classes_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region// TODO: Create a public Employee class

            // Inside of the Employee class:
            // TODO: Create a private field _password of type string

            // TODO: Create a public FirstName property of type string
            // TODO: Create a public MiddleInitial property of type char
            // TODO: Create a public LastName property of type string
            // TODO: Create a public EmailAddress property of type string
            // TODO: Create a public PhoneNumber property of type string
            // TODO: Create a public Title property of type string
            // TODO: Create a public DateOfBirth property of type DateTime

            // TODO: Create a parameterized constructor that sets all of the properties correctly
            // Thought experiment: (True or False) We can instantiate this class with a default constructor
            // TODO: false (bc we created a parameterized constructor we overrided the default. So, if we want to be able to use the default we must explicitly type it out)

            // TODO: Create a method that sets the employee's password
            // TODO: Create a method to display the employee's password
            // TODO: Create an EmployeeReport() method that takes in an employee and returns all of the props creatively displayed to the console
            
            var employee1 = new Employee("password1234", "John", 'J', "Cole", "234-456-8790", "Mr.", "12/22/1989");

           employee1.EmployeeReport();

            #endregion

            #region// TODO: Create a public Product class 

            // TODO: Create a public Product class

            // TODO: Create a private field _productID of type long
            // TODO: Create a private field _productCount of type int

            // TODO: Create a public Name property of type string
            // TODO: Create a public Price property of type double
            // TODO: Create a public CategoryID property of type int
            // TODO: Create a public OnSale property of type bool
            // TODO: Create a public StockLevel property of type int

            // TODO: Create a default constructor that increments the _productCount every time a new product is created
            // TODO: Create a parameterized constructor that does the same thing and initializes all of the properties

            // TODO: Create a method that gets the _productID and displays it creatively
            // TODO: Create a method that sets the _productID
            // TODO: Create a method that shows the current product count


            #endregion

            // TODO: Create a new employee and give all of its properties values

            var employee2 = new Employee("4321drowssap", "Fred", 'P', "Fittle", "564-408-9432", "Mr.", "01/12/1956");


            // TODO: Call all of the methods you created inside of that class
            employee2.DisplayPassword();
            employee2.EmployeeReport();

            // TODO: Create a new product and give all of its properties values

            var product1 = new Product(2345678,"Corn Flakes", 3.99, 1, false, 5);

            // TODO: Call all of the methods you created inside of that class

            product1.GetProductCount();
            product1.GetProductId();


        }
    }
}

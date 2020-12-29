namespace Csharp1
{
    public class SOLID
    {
        //   
        //The SOLID principles of Object Oriented Design include these five principles:
        //1. SRP – Single Responsibility Principle.
        //2. OCP – Open/Closed Principle.
        //3. LSP – Liskov Substitution Principle.
        //4. ISP – Interface Segregation Principle.
        //5. DIP – Dependency Inversion Principle.
        public SOLID()
        {

        }
        public void S()
        {
            //1.SRP – Single Responsibility Principle.
            // This means that every class, or similar structure, in your code should have only one job to do.
            //The Single Responsibility Principle is one of the SOLID design principles.We can define it in the following ways,

            //1. A reason to change
            //A class or method should have only one reason to change.

            //2. Single Responsibility
            //A class or method should have only a single responsibility.

            //SRP Benefits

            //The SRP has many benefits to improve code complexity and maintenance.Some benefits of SRP are following,

            //1. Reduction in complexity of a code
            //A code is based on its functionality.A method holds logic for a single functionality or task.
            //So, it reduces the code complexity.

            //2.Increased readability, extensibility, and maintenance
            //As each method has a single functionality so it is easy to read and maintain.

            //3.Reusability and reduced error
            //As code separates based functionality so if the same functionality uses somewhere else in an application
            //then don’t write it again.

            //4.Better testability
            //In the maintenance, when a functionality changes then we don’t need to test the entire model.

            //5.Reduced coupling
            //It reduced the dependency code.A method’s code doesn’t depend on other methods.
        }

        public void O()
        {
            //2.OCP – Open / Closed Principle.
            //The principle says “A software module /class should be open for extension, but closed for modification”. 
            //1. One should not modify an implementation(of a class or function) of logic and/or functionality.
            //2. but the implementation(of a class or function) is open for extension, 
            //in other words one can extend the implementation(of a class or function) of logic and/or functionality.
        }
        public void L()
        {
            //3.LSP – Liskov Substitution Principle.
            //The Liskov Substitution Principle(LSP) states that "you should be able to use any derived class instead of a parent 
            //class and have it behave in the same manner without modification".

            //it means, when we have a base class and child class relationship, then, if we can successfully replace
            //the object/instance of a parent class with an object/instance of the child class, without affecting the results
            //that we get with the base class instance, then the two classes conform to this principle.
        }
        public void I()
        {
            //4.ISP – Interface Segregation Principle.(Segregation = Separation, disconnection)
            //The Interface Segregation Principle states "that clients should not be forced to implement interfaces they don't use.
            //Instead of one fat interface many small interfaces are preferred based on groups of methods, each one serving one sub module.".

        }
        public void D()
        {
           // 5.DIP – Dependency Inversion Principle.

           // 1.The Dependency Inversion Principle(DIP) states that high - level modules / classes should not depend on low -
           //level modules / classes.Both should depend upon abstractions.
           // 2.Secondly, abstractions should not depend upon details. Details should depend upon abstractions.

           // Inversion of Control
           // Inversion of control is the actual mechanism using which we can make the higher level modules to depend on
           // abstractions rather than concrete implementation of lower level modules.
        }
    }
}

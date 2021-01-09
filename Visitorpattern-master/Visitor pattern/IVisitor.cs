using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_pattern
{
    /// <summary>
    /// The Visitor interface, which declares a Visit operation for each Concrete Visitor to implement.
    /// </summary>
    interface IVisitor
    {
        void Visit(Element element);
    }

    /// <summary>
    /// A Concrete Visitor class.
    /// </summary>
    class IncomeVisitor : IVisitor
    {
        /// <summary>
        /// doing the logic we want to do outside of the class
        /// </summary>
        /// <param name="element"></param>
        public void Visit(Element element)
        {
            // employee is inheriting from Element
            Employee employee = element as Employee;

            // We've had a great year, so 10% pay raises for everyone!
            employee.AnnualSalary *= 1.10;
            Console.WriteLine($"{employee.GetType().Name} { employee.Name}'s new income: {employee.AnnualSalary}");
        }
    }

    /// <summary>
    /// A Concrete Visitor class
    /// </summary>
    class PaidTimeOffVisitor : IVisitor
    {
        /// <summary>
        /// doing the logic we want to do outside of the class
        /// </summary>
        /// <param name="element"></param>
        public void Visit(Element element)
        {
            // employee is inheriting from Element
            Employee employee = element as Employee;

            // And because you all helped have such a great year, all my employees get three extra paid time off days each!
            employee.PaidTimeOffDays += 3;
            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new vacation days: {employee.PaidTimeOffDays}");
        }
    }

    /// <summary>
    /// The Element abstract class.  All this does is define an Accept operation, which needs to be implemented by any class that can be visited.
    /// </summary>
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }

    /// <summary>
    /// The Concrete Element class, which implements all operations defined by the Element.
    /// </summary>
    class Employee : Element
    {
        public string Name { get; set; }
        public double AnnualSalary { get; set; }
        public int PaidTimeOffDays { get; set; }

        public Employee(string name, double annualSalary, int paidTimeOffDays)
        {
            Name = name;
            AnnualSalary = annualSalary;
            PaidTimeOffDays = paidTimeOffDays;
        }

        /// <summary>
        /// passing the visitor this instance of employee so it can continue and doing the behavior which is outside of the class  
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(IVisitor visitor)
        {
            // letting the visitor do what we want on this object
            visitor.Visit(this);
        }
    }

    /// <summary>
    /// The Object Structure class, which is a collection of Concrete Elements.  This could be implemented using another pattern such as Composite.
    /// </summary>
    class Employees
    {
        private List<Employee> _employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }

        /// <summary>
        /// for each employee we are accepting a visit of type IVisitor
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IVisitor visitor)
        {
            foreach (Employee employee in _employees)
            {
                employee.Accept(visitor);
            }
            Console.WriteLine();
        }
    }


    class LineCook : Employee
    {
        public LineCook() : base("Dmitri", 32000, 7)
        {
        }
    }

    class HeadChef : Employee
    {
        public HeadChef() : base("Jackson", 69015, 21)
        {
        }
    }

    class GeneralManager : Employee
    {
        public GeneralManager() : base("Amanda", 78000, 24)
        {
        }
    }
}

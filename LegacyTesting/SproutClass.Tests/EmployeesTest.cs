using Moq;
using System.Collections.Generic;
using Xunit;

namespace SproutClass.Tests
{
    public class EmployeesTest
    {
        [Fact]
        public void GetEmployeesData_ReturnsSalariesBasic()
        {
            //calling directly to the implementation is ok,
            //but using interfaces is better because it allows us to use best practices 
            var currentDataObject = new EmployeeSalaryService();
            var salaryData = currentDataObject.GetEmployeesData();
            Assert.Contains(salaryData, x => x.Salary > 0);
        }

        [Fact]
        public void GetEmployeesData_ReturnsSalaries()
        {
            var currentDataObject = new Mock<IEmployeeService>();
            //config what data must to be returned using the interface,
            //gives more scalability to our solution
            currentDataObject.Setup(x => x.GetEmployeesData()).Returns(new List<Employee>() { new Employee { UniqueId = 1, Salary = 100 } });
            var salaryData = currentDataObject.Object.GetEmployeesData();

            Assert.Contains(salaryData, x => x.Salary > 0);
        }
    }
}

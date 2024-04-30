using Microsoft.AspNetCore.Mvc;
using StoredProcedure_Demo.Data;
using StoredProcedure_Demo.Models;

namespace StoredProcedure_Demo.Controllers
{
	public class EmployeeController : Controller
	{
		private readonly EmployeeDAL employeeDAL;
        public EmployeeController(EmployeeDAL employeeDAL)
        {
			this.employeeDAL = employeeDAL;  
        }
        public IActionResult Index()
		{
			var employees = employeeDAL.GetEmployees();
			return View(employees);
		}
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                
                employeeDAL.CreateEmployee(employee.FirstName, employee.LastName, employee.Department);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = employeeDAL.GetEmployeeById(id.Value);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
              
                if (id == 0)
                {
                    return NotFound();
                }

                employeeDAL.UpdateEmployee(employee.EmployeeId, employee.FirstName, employee.LastName, employee.Department);
                return RedirectToAction(nameof(Index));
            }

            return View(employee);
        }



        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = employeeDAL.GetEmployeeById(id.Value);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

      
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            employeeDAL.DeleteEmployee(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

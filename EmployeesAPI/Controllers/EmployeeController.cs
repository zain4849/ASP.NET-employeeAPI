using EmployeesAPI.Data;
using EmployeesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace EmployeesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly DataContext _context;

        public EmployeeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllEmployees")]
        public async Task<ActionResult<List<Employee>>> GetAllEmployees()
        {
            var employees = await _context.Employees.ToListAsync();
            return Ok(employees);
        }

        [HttpGet("GetEmployeeById/{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = await _context.Employees.Where(Employee => Employee.Id == id).FirstOrDefaultAsync();
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost ("AddEmployee")]
        public async Task<ActionResult> AddEmployee(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return Ok(employee);
        }

        [HttpDelete("DeleteEmployee/{id}")]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            var employee = await _context.Employees.Where(Employee => Employee.Id == id).FirstOrDefaultAsync();
            if (employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("UpdateEmployee")]
        public async Task<ActionResult<Employee>> UpdateEmployee(Employee updateEmployee)
        {
            var dbEmployee = await _context.Employees.FindAsync(updateEmployee.Id);
            if (dbEmployee == null)
            {
                return NotFound();
            }
            dbEmployee.FirstName = updateEmployee.FirstName;
            dbEmployee.LastName = updateEmployee.LastName;
            dbEmployee.Email= updateEmployee.Email;
            dbEmployee.DateOfBirth= updateEmployee.DateOfBirth;
            dbEmployee.JobTitle= updateEmployee.JobTitle;
            dbEmployee.Salary= updateEmployee.Salary;
            

            return Ok(dbEmployee);

        }

    }
}

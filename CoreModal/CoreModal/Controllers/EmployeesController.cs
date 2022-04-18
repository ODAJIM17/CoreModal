using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreModal.Data;
using CoreModal.Data.Entities;
using CoreModal.Helpers;
using static CoreModal.Helpers.ModalHelper;

namespace CoreModal.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly DataContext _context;

        public EmployeesController(DataContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.EmployeeID == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

       

        // GET: Employees/Edit/
        // GET: Customers/Edit/5
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Employee());
            }
            else
            {
                Employee employee = await _context.Employees.FindAsync(id);
                if (employee == null)
                {
                    return NotFound();
                }
                return View(employee);
            }

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, Employee employee)
        {
            if (ModelState.IsValid)
            {
                //Insert
                if (id == 0)
                {
                    employee.InputDate = DateTime.Now;
                    employee.InputBy ="Admin";
                    _context.Add(employee);
                    await _context.SaveChangesAsync();


                }
                //Update
                else
                {
                    try
                    {
                        employee.ModifiedBy = "Admin";
                        employee.ModifiedDate = DateTime.Now;
                        _context.Update(employee);
                        await _context.SaveChangesAsync();

                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!EmployeeExists(employee.EmployeeID))
                        { return NotFound(); }
                        else
                        { throw; }
                    }
                }
                return Json(new { isValid = true, html = ModalHelper.RenderRazorViewToString(this, "_ViewAll", _context.Employees.ToList()) });

            }
            return Json(new { isValid = false, html = ModalHelper.RenderRazorViewToString(this, "AddOrEdit", employee) });
        }


        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Employee employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.EmployeeID == id);
            if (employee == null)
            {
                return NotFound();
            }

            try
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
               // Alert(employee.FullName + " was deleted successfully.", NotificationType.success);


            }
            catch (Exception ex)
            {

                // Alert("This category can not be deleted because it has related records.", NotificationType.error);
                ModelState.AddModelError(string.Empty, "The employee can't be deleted because it has related records." + ex.ToString());
                // ModelState.AddModelError(string.Empty, ex.Message);
            }

            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeID == id);
        }
    }
}

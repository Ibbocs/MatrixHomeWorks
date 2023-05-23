using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentMVC.Models.DTO;
using StudentMVC.Models.Entity;
using StudentMVC.Service.Abstract;

namespace StudentMVC.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentMVCContext _context;
        private readonly IStudentService studentService;

        public StudentsController(StudentMVCContext context, IStudentService _studentService)
        {
            _context = context;
            studentService = _studentService;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            var data = await studentService.GetAllStudent();
            return View(data);
            //return _context.Student != null ?
            //            View(await _context.Student.ToListAsync()) :
            //            Problem("Entity set 'StudentMVCContext.Student'  is null.");
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var data = await studentService.GetStudentById(id);

            //if (id == null || data== null)
            //{
            //    return NotFound();
            //}


            if (data == null)
            {
                return NotFound();
            }

            return View(data);
        }

        // GET: Students/Create
        public async Task<IActionResult> Create(Student student)
        {
            return View(student);
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Age,Name")] StudentDTO student)
        {
            if (ModelState.IsValid)
            {
                await studentService.AddStudent(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            //if (id == null || _context.Student == null)
            //{
            //    return NotFound();
            //}

            List<Student> student = await studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }



            try
            {
                await studentService.UpdateStudent(student, id);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(student.Id))
                {
                    return NotFound();
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }


            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || await studentService.GetStudentById(id ?? 0) == null)
            {
                return NotFound();
            }

            var student = await studentService.GetStudentById(id ?? 0);
            if (student == null)
            {
                return NotFound();
            }

            ViewBag.Student = student;

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await studentService.GetStudentById(id);
            if (student == null)
            {
                return Problem("Entity set 'StudentMVCContext.Student'  is null.");
            }

            if (student != null)
            {
                await studentService.DeleteStudent(id);
            }

            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return (_context.Student?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

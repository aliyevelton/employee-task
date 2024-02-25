﻿using Microsoft.AspNetCore.Mvc;
using NetTask.Contexts;
using NetTask.Models;

namespace NetTask.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Employee> employees = _context.Employees.ToList();
            return View(employees);
        }
    }
}

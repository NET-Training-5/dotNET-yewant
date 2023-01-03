﻿using HumanResources.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;

namespace HumanResources.Web.Controllers
{
    public class EmployeeController : Controller
    {
        HRDbContext db = new HRDbContext();
        public IActionResult Index()
        {
          
            var employees = db.Employees.ToList();

            return View(employees);
        }
        public IActionResult Add()
            {
            var departments = db.Departments.Select(x => new SelectListItem { Text = x.Name, Value = x.Name }).ToList();
            ViewData["departments"] = departments;
            var designations = db.Designations.Select(x => new SelectListItem { Text = x.Name, Value = x.Name }).ToList();
            ViewData["designations"] = designations;
            return View();
            }

        [HttpPost]
        public IActionResult Add(Employee employee)
            {
            db.Employees.Add(employee);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
            }

        public IActionResult Edit(int Id)
            {
            var employee = db.Employees.Find(Id);
            return View(employee);

            }

        [HttpPost]
        public IActionResult Edit(Employee employee)
            {
            db.Employees.Update(employee);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
            }

        public IActionResult Delete(int Id)
            {
            var employee = db.Employees.Find(Id);
            return View(employee);

            }

        [HttpPost]
        public IActionResult Delete(Employee employee)
            {

            db.Employees.Remove(employee);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
            }

        }





    }


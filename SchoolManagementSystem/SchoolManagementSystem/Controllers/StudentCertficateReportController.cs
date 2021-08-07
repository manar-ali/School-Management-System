﻿using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class StudentCertficateReportController : Controller
    {
        private SchoolMgtSysDbEntities db = new SchoolMgtSysDbEntities();
        // GET: StudentCertficateReport
        public ActionResult LeavingC(int? id)
        {
            ViewBag.Message = "Ready to Print";
            var student = db.StudentPromoteTables.Where(std => std.StudentID == id && std.IsActive == true).FirstOrDefault();
            if (student == null)
            {
                ViewBag.Message = "Already Printed";
                student = db.StudentPromoteTables.Where(std => std.StudentID == id ).OrderByDescending(e => e.StudentPromotedID).FirstOrDefault();
                return View(student);
            }
            return View(student);
        }
        [HttpPost]
        public ActionResult PrintLeavingC(int? id)
        {
            //StudentPromoteTable student = new StudentPromoteTable();
            var student = db.StudentPromoteTables.Where(std => std.StudentID == id && std.IsActive == true).FirstOrDefault();

            if (student == null)
            {
                ViewBag.Message = "Already Print! Please Contact to Adminstration Department.";
                student = db.StudentPromoteTables.Where(std => std.StudentID == id).OrderByDescending(e => e.StudentPromotedID).FirstOrDefault();

                return View("LeavingC", student);
            }
          //  student.IsActive = false;
            db.Entry(student).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            ViewBag.Message = " Print Successfully.";
            return View("LeavingC",student);
        }

        public ActionResult CharacterC(int? id)
        {
            ViewBag.Message = "Ready to Print";
             var student = db.StudentPromoteTables.Where(std => std.StudentID == id && std.IsActive == true).FirstOrDefault();

            if (student == null)
            {
                ViewBag.Message = "Already Printed";
                  student = db.StudentPromoteTables.Where(std => std.StudentID == id).OrderByDescending(e => e.StudentPromotedID).FirstOrDefault();

                return View(student);
            }
            return View(student);
        }

        public ActionResult ProvisionalC()
        {
            return View();
        }
        

    }
}
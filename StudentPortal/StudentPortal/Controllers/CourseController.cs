﻿using StudentPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace StudentPortal.Controllers
{
    public class CourseController : ApiController
    {
        //
        // GET: /Employee/
        //    public ActionResult Index()
        //    {
        //        IEnumerable<Course> empList;
        //        HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Course").Result;
        //        empList = response.Content.ReadAsAsync<IEnumerable<Course>>().Result;
        //        return View(empList);
        //    }

        //    public ActionResult AddOrEdit(int id = 0)
        //    {
        //        if (id == 0)
        //            return View(new Course());
        //        else
        //        {
        //            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employee/" + id.ToString()).Result;
        //            return View(response.Content.ReadAsAsync<mvcEmployeeModel>().Result);
        //        }
        //    }
        //    [HttpPost]
        //    public ActionResult AddOrEdit(mvcEmployeeModel emp)
        //    {
        //        if (emp.EmployeeID == 0)
        //        {
        //            HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Employee", emp).Result;
        //            TempData["SuccessMessage"] = "Saved Successfully";
        //        }
        //        else
        //        {
        //            HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Employee/" + emp.EmployeeID, emp).Result;
        //            TempData["SuccessMessage"] = "Updated Successfully";
        //        }
        //        return RedirectToAction("Index");
        //    }

        //    public ActionResult Delete(int id)
        //    {
        //        HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Employee/" + id.ToString()).Result;
        //        TempData["SuccessMessage"] = "Deleted Successfully";
        //        return RedirectToAction("Index");
        //    }
        //}
    }
}
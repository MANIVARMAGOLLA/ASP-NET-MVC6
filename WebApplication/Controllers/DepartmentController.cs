using BusinessLogic;
using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InsertIntoDepartment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertIntoDepartment(DepartmentModel DeptModel)
        {
            try
            {
                DTO dto = new DTO()
                {
                    DeptName = DeptModel.DeptName,
                    DeptGroupName= DeptModel.DeptGroupName,

                };
                BL bl = new BL();
                int result=bl.InsertIntoDept(dto);
                if (result == 1)
                {
                    return View("Success");
                }
                else
                {
                    return View("Error");
                }

            }
            catch (Exception ex)
            {

                return View("Error");
            }

        }
    }
}
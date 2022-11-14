﻿using Microsoft.AspNetCore.Mvc;
using PParikhBooks.DataAccess.Repository;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PParikhBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        private bool success;
        private object objfromDb;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.Id == 0)
                {
                    _unitOfWork.Category.Add(category);
                  
                }
                else
                {
                    _unitOfWork.Category.Update(category);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new
            {
                data = allObj
            });
        }

        private IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success == false, message = "Error While deleting" });
            }
            bool v = _unitOfWork.Category.Remove(objfromDb);
            _unitOfWork.Save();
            return Json(new { success, message = "delete successfully" });
        }
                 #endregion
    }
}


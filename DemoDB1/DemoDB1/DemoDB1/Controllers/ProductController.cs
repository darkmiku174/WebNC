﻿using DemoDB1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
namespace DemoDB1.Controllers
{
    public class ProductController : Controller
    {
        DBSportStoreEntities database = new DBSportStoreEntities();
        // GET: Product
        public ActionResult Index(string category, int? page,double min = double.MinValue,double max=double.MaxValue)
        {
            int pageSize = 4;
            int pageNum = (page ?? 1);
            if (category==null)
            {
                var productList = database.Products.OrderByDescending(x => x.NamePro);

                return View(productList.ToPagedList(pageNum,pageSize));
            }
            else
            {
                var productList = database.Products.OrderByDescending(x => x.NamePro).Where(x => x.Category == category);
                return View(productList);
            }
        }
        public ActionResult Create()
        {
            Product pro = new Product();
            return View(pro);
        }
        public ActionResult SelectCate()
        {
            Category se_cate = new Category();
            se_cate.ListCate = database.Categories.ToList<Category>();
            return PartialView(se_cate);
        }
        [HttpPost]
        public ActionResult Create(Product pro)
        {
            try
            {
                if (pro.UploadImage != null)
                {
                    string filename = Path.GetFileNameWithoutExtension(pro.UploadImage.FileName);
                    string extent = Path.GetExtension(pro.UploadImage.FileName);
                    filename = filename + extent;
                    pro.ImagePro = "~/Content/images" + filename;
                    pro.UploadImage.SaveAs(Path.Combine(Server.MapPath("~/Content/images"), filename));
                }
                database.Products.Add(pro);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult SearchOption(double min = double.MinValue,double max=double.MaxValue)
        {
            var list = database.Products.Where(p => (double)p.Price >= min && (double)p.Price <= max).ToList();
            return View(list);
        }
    }
}
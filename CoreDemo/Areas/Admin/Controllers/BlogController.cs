using BusinessLayer.Concrete;
using ClosedXML.Excel;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult GetBlogListPage()
        {
            return View();
        }
        public IActionResult ExportBlogList()
        {
            BlogManager blogManager = new BlogManager(new EfBlogRepository());
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Blog Listesi");

                workSheet.Cell(1, 1).Value = "Blog ID";
                workSheet.Cell(1, 2).Value = "Blog başlık";
                workSheet.Cell(1, 3).Value = "Blog içerik";
                workSheet.Cell(1, 4).Value = "Blog oluşturulma tarihi";
                workSheet.Cell(1, 5).Value = "Blog kategorisi";
                workSheet.Cell(1, 6).Value = "Blog yazarı";

                var values = blogManager.GetAllBlogWithCategoryAndWriter();

                int rowNumber = 2;

                foreach (var item in values)
                {
                    workSheet.Cell(rowNumber, 1).Value = item.BlogID;
                    workSheet.Cell(rowNumber, 2).Value = item.BlogTitle;
                    workSheet.Cell(rowNumber, 3).Value = item.BlogContent.Substring(0,150);
                    workSheet.Cell(rowNumber, 4).Value = item.BlogCreateDate;
                    workSheet.Cell(rowNumber, 5).Value = item.Category.CategoryName;
                    workSheet.Cell(rowNumber, 6).Value = item.Writer.WriterName;

                    rowNumber++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreatsheetml.sheet", "BlogList.xlsx");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMVC.Models;

namespace MyMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {

            // 返回同名的视图
            return View();

        }
        public IActionResult GetViewData()
        {
            // 1、将字符串传递到View
            ViewData["Other"] = "通过ViewData向View传递字符串";
            // 2、通过KeyValuePair添加
            ViewData.Add(new KeyValuePair<string, object>("name", "tom"));
            // 3、直接添加
            ViewData.Add("age", 23);
            // 4、传递集合到View
            ViewData["Data"] = new List<Student>()
            {
                new Student
               {
                 ID = 1,
                 Name = "张三",
                 Age = 34,
                 Sex = "男",
                 Email = "zhangs@qq.com"
               },
               new Student
               {
                 ID = 2,
                 Name = "李四",
                 Age = 635,
                 Sex = "男",
                 Email = "lis@163.com"
               },
               new Student
               {
                 ID = 3,
                 Name = "王五",
                 Age = 4532,
                 Sex = "女",
                 Email = "wangw@qq.com"
               }
            };

            // 返回同名的视图
            return View();

        }

        public IActionResult GetViewModel(int? id)
        {

            var student = new Student
            {
                ID = 1,
                Name = "王五",
                Age = 34,
                Sex = "男",
                Email = "747976523@qq.com"
            };

            if (id == 2)
            {
                student = new Student
                {
                    ID = 1,
                    Name = "刘七",
                    Age = 22,
                    Sex = "女",
                    Email = "99999999@qq.com"
                };
            }

            // 返回同名的视图
            return View(student);

        }


        public IActionResult GetViewBag()
        {

            var students = new List<Student>()
            {
                new Student
               {
                 ID = 1,
                 Name = "张三",
                 Age = 34,
                 Sex = "男",
                 Email = "zhangs@qq.com"
               },
               new Student
               {
                 ID = 2,
                 Name = "李四",
                 Age = 635,
                 Sex = "男",
                 Email = "lis@163.com"
               },
               new Student
               {
                 ID = 3,
                 Name = "王五",
                 Age = 4532,
                 Sex = "女",
                 Email = "wangw@qq.com"
               }
            };

            ViewBag.Students = students;
            ViewBag.Title = "我是ViewBag";


            return View();

        }
    }
}

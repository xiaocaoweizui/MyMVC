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
                 Name = "唐僧",
                 Age = 34,
                 Sex = "男",
                 Email = "747976523@qq.com"
               },
               new Student
               {
                 ID = 2,
                 Name = "孙悟空",
                 Age = 635,
                 Sex = "男",
                 Email = "sunwukong@163.com"
               },
               new Student
               {
                 ID = 3,
                 Name = "白骨精",
                 Age = 4532,
                 Sex = "女",
                 Email = "74345523@qq.com"
               }
            };

            // 返回同名的视图
            return View();




        }

        public IActionResult GetStudent(int? id)
        {

            var student = new Student
            {
                ID = 1,
                Name = "王五",
                Age = 34,
                Sex = "男",
                Email = "747976523@qq.com"
            };

            if (id == 1)
            {
                student= new Student
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
    }
}

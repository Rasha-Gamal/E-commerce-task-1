using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using task1._1.Models;

namespace task1._1.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            return "welcome to home page";
        }
        public String Welcome()
        {
            return "this is the welcome page ";
        }
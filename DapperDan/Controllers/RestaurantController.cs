using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperDan.Models;
using Dapper;
using MySqlConnector;

namespace DapperDan.Controllers
{
    public class RestaurantController : Controller
    {
        public IActionResult Index()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                //Dappe4r allows us to put sql queries into a string
                //and pass them along to our DB
                //All MySql syntax is useable here
                string sql = "select * from dishes";

                connect.Open();

                List<Dish> dishes = connect.Query<Dish>(sql).ToList();
                connect.Close();

                Dish d = dishes[0];
                return View(d);
            }            
        }
    }
}

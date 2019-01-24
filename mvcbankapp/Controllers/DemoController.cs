using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvcbankapp.Models;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
namespace mvcbankapp.Controllers
{
    public class DemoController : Controller
    {
        SqlConnection con = new SqlConnection("user id=sa; password=123;database=mvcbatch47;data source=MUKTAR");
        SqlCommand cmd;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult store(CustomerModel c)
        {
            cmd = new SqlCommand("insert into customer values(@accno,@accname,@accbal)",con);
            cmd.Parameters.AddWithValue("@accno", c.accno);
            cmd.Parameters.AddWithValue("@accname", c.accname);
            cmd.Parameters.AddWithValue("@accbal", c.accbal);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ViewBag.msg = "Record Inserted Successfully " +" Account Number"  +  c.accno + "Account Name - "+  c.accname  +" Balance -   "+ c.accbal ;

            return View();
        }

        public ActionResult index1()
        {
            return View();
        }

        public ActionResult manipulation(CustomerModel c , string command)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            
            switch(command)
            {
                case "Search":
                    cmd.CommandText = "select * from customer where accno =@accno ";
                    cmd.Parameters.AddWithValue("@accno", c.accno);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        ViewBag.accno = dr["accno"];
                        ViewBag.name = dr["accname"];
                        ViewBag.bal = dr["accbal"];
                    }
                    else
                       ViewBag.msg = "Account Not Found ";
                    break;

                case "Delete":
                    cmd.CommandText = "delete from customer where accno = @accno";
                    cmd.Parameters.AddWithValue("@accno", c.accno);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ViewBag.msg = "Record Deleted";
                    break;
                   
            }


            return View("index1");
        }





    }
}
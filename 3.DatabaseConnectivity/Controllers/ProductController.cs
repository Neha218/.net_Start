using _3.DatabaseConnectivity.Config;
using _3.DatabaseConnectivity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3.DatabaseConnectivity.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Create()
        {
            return View(new Product { Id = 0 });
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            string insertSql = "INSERT INTO Products(Name, Price, Supplier) VALUES ('" + product.Name + "','" + product.Price + "','" + product.Supplier + "')";
            string updateSql = "UPDATE Products SET Name = '" + product.Name + "', Price = '"+product.Price+"', Supplier = '"+product.Supplier+"' WHERE Id = '"+product.Id+"'";
            using (SqlConnection con = new SqlConnection(StoreConnection.GetConnection()))
            {
                using (SqlCommand cmd = new SqlCommand(product.Id > 0 ? updateSql : insertSql, con))
                {
                    if (con.State != System.Data.ConnectionState.Open)
                        con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return Content("Record is save in the database");
        }

        public ActionResult GetAll()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection con = new SqlConnection(StoreConnection.GetConnection()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con))
                {
                    if (con.State != System.Data.ConnectionState.Open)
                        con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable dtProducts = new DataTable();
                    dtProducts.Load(sdr);

                    foreach (DataRow row in dtProducts.Rows)
                    {
                        products.Add(
                            new Product
                            {
                                Id = Convert.ToInt32(row["Id"]),
                                Name = row["Name"].ToString(),
                                Price = Convert.ToDecimal(row["Price"]),
                                Supplier = row["Supplier"].ToString()
                            }
                         );
                    }
                }
            }
            return View(products);
        }

        public ActionResult Delete(int id)
        {
            if (id < 0)
                return HttpNotFound();
            using (SqlConnection con = new SqlConnection(StoreConnection.GetConnection()))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE Id = '"+id+"'", con))
                {
                    if (con.State != System.Data.ConnectionState.Open)
                        con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return RedirectToAction("GetAll");
        }

        public ActionResult Edit(int id)
        {
            if (id < 0)
                return HttpNotFound();
            var _product = new Product();
            using (SqlConnection con = new SqlConnection(StoreConnection.GetConnection()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Products WHERE Id = '"+id+"'", con))
                {
                    if (con.State != System.Data.ConnectionState.Open)
                        con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    if (sdr.HasRows)
                    {
                        dt.Load(sdr);
                        DataRow row = dt.Rows[0];
                        _product.Id = Convert.ToInt32(row["Id"]);
                        _product.Name = row["Name"].ToString();
                        _product.Price = Convert.ToDecimal(row["Price"]);
                        _product.Supplier = row["Supplier"].ToString();

                        return View("Create", _product);
                    }
                    else
                    {
                        return HttpNotFound();
                    }

                }
            }
        }
    }
}
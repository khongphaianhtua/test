using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using testStudentDatabase.Models;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Http;

namespace testStudentDatabase.Controllers
{
    public class HomeController : Controller
    {
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        List<Address> addresses = new List<Address>();
        List<User> users = new List<User>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            con.ConnectionString = testStudentDatabase.Properties.Resources.ConnectionString;
        }

        private void FetchData()
        {
            if (addresses.Count > 0)
            {
                addresses.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT *from student";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    addresses.Add(new Address()
                    {
                        ID = dr["ID"].ToString(),
                        Adress = dr["Adress"].ToString(),
                        Name = dr["name"].ToString(),
                        DiemTB = dr["diemtb"].ToString(),
                        Class = dr["class"].ToString(),
                    });
                }

                con.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void DataUser()
        {
            if (users.Count > 0)
            {
                users.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT *from user";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    users.Add(new User()
                    {
                        ID = dr["ID"].ToString(),
                        UserName = dr["UserName"].ToString(),
                        Password = dr["Password"].ToString(),

                    });
                }

                con.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public IActionResult Index()
        {
            FetchData();
            return View(addresses);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();

        }


        public IActionResult CreateStudent(Address a)
        {
            /*if (a!=null )
            {
*/
            try
            {
                con.Open();
                string sql = @"INSERT INTO student  VALUES(@ID,@Name,@Adress,@DiemTB,@Class)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Float).Value = a.ID;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = a.Name;
                    cmd.Parameters.Add("@Adress", SqlDbType.NVarChar, 50).Value = a.Adress;
                    cmd.Parameters.Add("@DiemTB", SqlDbType.Float).Value = a.DiemTB;
                    cmd.Parameters.Add("@Class", SqlDbType.NVarChar, 50).Value = a.Class;
                    cmd.CommandType = CommandType.Text;

                    cmd.ExecuteReader();
                }
                con.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }

            /* }
             else
             {
                 ViewBag.error = "ID đã có !Mời nhập ID khác";
                 return View("create");
             }*/
            FetchData();
            return View("index", addresses);

        }
        public IActionResult UpdateStudent(Address a)
        {
            try
            {
                con.Open();
                string sql = @"UPDATE student SET Name=@Name,Adress=@Adress,DiemTB=@DiemTB,Class=@Class WHERE ID=@ID";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Float).Value = a.ID;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = a.Name;
                    cmd.Parameters.Add("@Adress", SqlDbType.NVarChar, 50).Value = a.Adress;
                    cmd.Parameters.Add("@DiemTB", SqlDbType.Float).Value = a.DiemTB;
                    cmd.Parameters.Add("@Class", SqlDbType.NVarChar, 50).Value = a.Class;
                    //   cmd.ExecuteReader();
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        addresses.Add(new Address()
                        {
                            ID = reader["ID"].ToString(),
                            Adress = reader["Adress"].ToString(),
                            Name = reader["name"].ToString(),
                            DiemTB = reader["diemtb"].ToString(),
                            Class = reader["class"].ToString(),
                        });

                    }
                }
                con.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            FetchData();
            return View("index", addresses);
        }
        public IActionResult DeleteStudent(Address a)
        {
            try
            {
                con.Open();
                string sql = @"DELETE FROM student WHERE ID=@ID";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Float, 50).Value = a.ID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            FetchData();
            return View("index", addresses);

        }
        private List<Address> SearchStudent(string a)
        {
            if (a != null)
            {
                try
                {
                    con.Open();
                    var sql = @"SELECT *FROM student WHERE  ID like '%'+@id+'%' or Name like '%'+@id+'%' or Adress like '%'+@id+'%' or  DiemTB like '%'+@id+'%'  or Class like '%'+@id+'%'";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = a;
                        using var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            addresses.Add(new Address()
                            {
                                ID = reader["ID"].ToString(),
                                Adress = reader["Adress"].ToString(),
                                Name = reader["name"].ToString(),
                                DiemTB = reader["diemtb"].ToString(),
                                Class = reader["class"].ToString(),
                            });

                        }

                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return addresses;
        }
        public IActionResult Search(Address a)
        {
            SearchStudent(a.ID);
            if (addresses.Count >= 1)
            {
                addresses.Clear();
                return View("index", SearchStudent(a.ID));

            }
            else
            {
                ViewBag.error = "không có!mời nhập lại";
                FetchData();
                return View("index", addresses);
            }
        }


        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Update(Address a)
        {/*
            updateS(a.ID);
            addresses.Clear();
            return View(updateS(a.ID));*/
            return View();


        }
        private List<Address> updateS(string c)
        {
            try
            {
                con.Open();
                string sql = @"SELECT * FROM [student] WHERE ID=@ID ";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Float).Value = c;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        addresses.Clear();
                        addresses.Add(new Address()
                        {
                            ID = reader["id"].ToString()
                        });

                    }


                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return addresses;
        }
        public IActionResult ShowStudent()
        {
            return View();
        }
        public IActionResult Dangnhap()
        {
            return View();
        }
        public IActionResult Login(User b)
        {
            List<User> users = new List<User>();

            try
            {
                con.Open();
                string sql = "SELECT *  FROM [user] WHERE UserName=@username AND Password=@password";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = b.UserName;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = b.Password;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        users.Add(new User()
                        {
                            UserName = reader["username"].ToString(),
                            Password = reader["password"].ToString(),
                        });

                    }
                }
                con.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (users.Count == 1)
            {
                FetchData();
                return View("index", addresses);

            }
            else
            {
                ViewBag.error = "Tài khoản hoặc mật khẩu không chính xác";
                return View("dangnhap");
            }


        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return View("dangnhap");

        }
        public IActionResult Dangky()
        {
            return View();
        }
        public  IActionResult DangkyUser( User a)
        {
            try
            {
                con.Open();
                string sql = @"INSERT INTO [user]  VALUES(@UserName,@Password)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = a.UserName;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = a.Password;
                    cmd.ExecuteReader();
                }
                con.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            ViewBag.error = "dang ky thanh cong moi dang nhap";
            return View("dangnhap");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

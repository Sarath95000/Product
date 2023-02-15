using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SampleProduct.Users;
using SampleProduct.Users.Initializers;

namespace SampleProduct
{

    class Student
    {
        public int Roll { set; get; }
        string Name { set; get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //SqlConnection connection = new SqlConnection("Data Source = LWO-LAP844; Initial Catalog = UserDB; Integrated Security = true");
                //connection.Open();

                DBConnect connection = new DBConnect("LWO-LAP844", "Product_Main", true);
                List<User> user = new List<User>()
                {
                    new User()
                    {
                        FirstName = "Sarath",
                        LastName = "s",
                        FullName ="Sarath.S",
                        LoginName ="Sarath.s",
                        IsWindowsAuthenticated = 1,
                        Password = "password-1",
                        PhoneNumber = "9500053616",
                        PhoneExtensionNumber ="91",
                        Email = "sarath.s@gmail.com",
                        Title ="SDE",
                        FaxNumber = "9500053616",
                        IsEmailNotificationAllowed = 1,
                        //LoginEffectiveDate = DateTime.Now,
                        //LoginExpiryDate = DateTime.Now,
                        //IsLoginBlocked = 0,
                        //IsAdminBlocked = 0,
                        //LoginBlockedTime = DateTime.Now,
                        //ForcePasswordReset = 0,
                        //CreationDate = DateTime.Now,
                        //ActivationDate = DateTime.Now,
                        //DeactivationDate = DateTime.Now,
                        //CanLogin = 0,
                        //LoginFailureCounter = 0,
                        //ApprovalStatus ="Approved",
                        
                        //CreatedById = 1,
                        //CreatedTime = DateTime.Now,
                        //UpdatedById = 1,
                        //UpdatedTime = DateTime.Now,
                        //IsFullAccess = 0,
                        //DefaultBusinessUnitId = 0,
                        //AdminUserId = 0,
                        //IsFactorAuthenticationEnabled = 0,
                        //MultiFactorAuthenticationId = 0,
                        //ContractId = 0,
                        //ExternalUserId = "0",
                        //DomainId = 0,
                    }
                };

                //foreach (var item in user)
                //{
                //    Console.WriteLine(item.);
                //}
                InsertUser insert = new InsertUser();
                insert.InsertUserData(user);





























                //Console.Write("Enter Name : ");
                //string Name = Console.ReadLine();
                //Console.Write("Enter Age : ");
                //int Age = int.Parse(Console.ReadLine());

                //SqlCommand command = new SqlCommand("GetUserData",connection);
                //command.CommandType = CommandType.StoredProcedure;
                //SqlDataReader Reader = command.ExecuteReader();

                //while (Reader.Read())
                //{
                //    Console.WriteLine(Reader.GetValue(1).ToString());
                //}

                //Console.WriteLine("Executed");




















               
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }





            Console.ReadLine();
        }
    }
}

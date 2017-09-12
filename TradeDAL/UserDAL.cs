using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeDAL
{
   public class UserDAL
    {

        SqlConnection con = new
          SqlConnection("server=.\\SQLEXPRESS;database=SM;Trusted_Connection=Yes");



       //Login function
      
        public string AddUserDetails(loginDALModel login) // passing Bussiness object Here
        {
            string Result = "";
            try
            {
                

                SqlCommand cmd = new SqlCommand("LoginUser", con);

             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@NIC", login.NIC);
             cmd.Parameters.AddWithValue("@Password", login.Password);

             con.Open();

             SqlDataReader reader = cmd.ExecuteReader();
             reader.Read();
                if(reader.HasRows){
                   // RedirectToAction("Index", "MyController");
                    Result="Successfully login";
                    
                }else{
                   Result="Username or Password wrong";
                    
                }

            // int Result = cmd.ExecuteNonQuery(); 
             cmd.Dispose();
             con.Close();

             //if (Result != 0)
             //{
                 
             //    Console.WriteLine(Result + "Data Saved");
             //}

            // return Result; 
            }
            catch(Exception e)
            {
                throw;
            }
            return Result; 
        }

       /// <summary>
       /// Register the user
       /// </summary>
       /// <param name="register"></param>
       /// <returns></returns>

        public int RegisterUser(loginDALModel register) // passing Bussiness object Here
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UserInsert", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NIC", register.NIC);
                cmd.Parameters.AddWithValue("@Password", register.Password);

                con.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                if (Result != 0)
                {
                    Console.WriteLine(Result + "Data Saved");
                }

                return Result;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    


    }
}

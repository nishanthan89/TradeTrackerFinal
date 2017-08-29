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
      
        public int AddUserDetails(loginDALModel login) // passing Bussiness object Here
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UserInsert", con);

             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@NIC", login.NIC);
             cmd.Parameters.AddWithValue("@Password", login.Password);
             
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
            catch(Exception e)
            {
                throw;
            }
        }



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

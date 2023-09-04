using System.Data;
using New_folder.Models;
using Microsoft.Data.SqlClient;

namespace New_folder.UserFunction
{
    public class UsersFunction
    {
        string connstr="Server=DESKTOP-3K7G22V;Database=traningdb2;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True";
        public UserModel getloginuser(UserModel model)
        {
            SqlConnection con= new SqlConnection(connstr);
            UserModel user=new UserModel();
            try
            {
                SqlCommand cmd=new SqlCommand("getLoginuser", con);
                cmd.Parameters.AddWithValue("@UserName", model.UserName);
                cmd.Parameters.AddWithValue("@Password", model.Password);
                cmd.CommandType=CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter da= new SqlDataAdapter();
                DataSet ds= new DataSet();
                da.SelectCommand=cmd;
                da.Fill(ds);

                user=ds.Tables[0].AsEnumerable().Select(row => new UserModel{
                    UserName=row["UserName"].ToString(),
                    Password=row["Password"].ToString(),
                }).FirstOrDefault();
             
                
            }
            catch(Exception ex) 
            {

            }
            finally
            {
                con.Close();
            }
            return user;
        }
       
       
       
        // public response getalluser()
        // {
        //     SqlConnection con= new SqlConnection(connstr);
        //     response response  =new response();
        //     try
        //     {
        //         SqlCommand cmd=new SqlCommand("getallusers", con);
        //         cmd.CommandType=CommandType.StoredProcedure;
        //         con.Open();
        //         SqlDataAdapter da= new SqlDataAdapter();
        //         DataSet ds= new DataSet();
        //         da.SelectCommand=cmd;
        //         da.Fill(ds);

        //         List<Account> user=ds.Tables[0].AsEnumerable().Select(row => new Account{
        //             userid=Convert.ToInt32(row["userid"].ToString()),
        //             firstName=row["firstName"].ToString(),
        //             lastName=row["lastName"].ToString(),
        //             middleName=row["middleName"].ToString(),
        //             email=row["email"].ToString(),
        //             city=row["city"].ToString(),
        //             address=row["address"].ToString(),
        //             gender=row["gender"].ToString()
        //         }).ToList();
        //         response.IsSuccess=true;
        //         response.Message="current user get success";
        //         response.Data=user;
        //     }
        //     catch(Exception ex) 
        //     {
        //         response.IsSuccess=false;
        //         response.Message=ex.Message;

        //     }
        //     finally
        //     {
        //         con.Close();
        //     }
        //     return response;
        // }
        // public response addnewuser(Account model)
        // {
        //     SqlConnection con= new SqlConnection(connstr);
        //     response response  =new response();
        //     try
        //     {
        //         SqlCommand cmd=new SqlCommand("addnewuser", con);
        //         cmd.Parameters.AddWithValue("@firstName", model.firstName);
        //         cmd.Parameters.AddWithValue("@middleName", model.middleName);
        //         cmd.Parameters.AddWithValue("@lastName", model.lastName);
        //         cmd.Parameters.AddWithValue("@email", model.email);
        //         cmd.Parameters.AddWithValue("@city", model.city);
        //         cmd.Parameters.AddWithValue("@address", model.address);
        //         cmd.Parameters.AddWithValue("@gender", model.gender);
        //         // cmd.Parameters.AddWithValue("@firstName", model.hobbies);
        //         cmd.CommandType=CommandType.StoredProcedure;
        //         con.Open();
        //         SqlDataAdapter da= new SqlDataAdapter();
        //         DataSet ds= new DataSet();
        //         da.SelectCommand=cmd;
        //         da.Fill(ds);
        //         var currentrow=ds.Tables[0].Rows[0];
        //         response.Message=currentrow["message"].ToString();
        //         response.IsSuccess=Convert.ToBoolean(currentrow["IsSuccess"]);
        //     }
        //     catch(Exception ex)
        //     {
        //         response.Message=ex.Message;
        //         response.IsSuccess=false;
        //     }
        //     finally
        //     {
        //         con.Close();
        //     }
        //     return response;  
        // }
        // public response getoneuser(int userid)
        // {
        //     SqlConnection con= new SqlConnection(connstr);
        //     response response  =new response();
        //     try
        //     {
        //         SqlCommand cmd=new SqlCommand("getoneuser", con);
        //         cmd.Parameters.AddWithValue("@userid", userid);
        //         cmd.CommandType=CommandType.StoredProcedure;
        //         con.Open();
        //         SqlDataAdapter da= new SqlDataAdapter();
        //         DataSet ds= new DataSet();
        //         da.SelectCommand=cmd;
        //         da.Fill(ds);

        //         Account user=ds.Tables[0].AsEnumerable().Select(row => new Account{
        //             userid=Convert.ToInt32(row["userid"].ToString()),
        //             firstName=row["firstName"].ToString(),
        //             lastName=row["lastName"].ToString(),
        //             middleName=row["middleName"].ToString(),
        //             email=row["email"].ToString(),
        //             city=row["city"].ToString(),
        //             address=row["address"].ToString(),
        //             gender=row["gender"].ToString()
        //         }).FirstOrDefault();
        //         response.IsSuccess=true;
        //         response.Message="current user get success";
        //         response.Data=user;
        //     }
        //     catch(Exception ex) 
        //     {
        //         response.IsSuccess=false;
        //         response.Message=ex.Message;

        //     }
        //     finally
        //     {
        //         con.Close();
        //     }
        //     return response;
        // }
        // public response updateuser(Account model)
        // {
        //     SqlConnection con= new SqlConnection(connstr);
        //     response response  =new response();
        //     try
        //     {
        //          SqlCommand cmd=new SqlCommand("updateuserdetail", con);
        //         cmd.Parameters.AddWithValue("@userid", model.userid);
        //         cmd.Parameters.AddWithValue("@firstName", model.firstName);
        //         cmd.Parameters.AddWithValue("@middleName", model.middleName);
        //         cmd.Parameters.AddWithValue("@lastName", model.lastName);
        //         cmd.Parameters.AddWithValue("@email", model.email);
        //         cmd.Parameters.AddWithValue("@city", model.city);
        //         cmd.Parameters.AddWithValue("@address", model.address);
        //         cmd.Parameters.AddWithValue("@gender", model.gender);
        //         cmd.CommandType=CommandType.StoredProcedure;

        //         con.Open();
        //         SqlDataAdapter da= new SqlDataAdapter();
        //         DataSet ds= new DataSet();
        //         da.SelectCommand=cmd;
        //         da.Fill(ds);
        //         var currentrow=ds.Tables[0].Rows[0];
        //         response.Message=currentrow["message"].ToString();
        //         response.IsSuccess=Convert.ToBoolean(currentrow["IsSuccess"]);
        //     }
        //     catch(Exception ex) 
        //     {
        //         response.IsSuccess=false;
        //         response.Message=ex.Message;

        //     }
        //     finally
        //     {
        //         con.Close();

        //     }
        //     return response;
        // }
        // public response deleteuser(int userid)
        // {
        //     SqlConnection con= new SqlConnection(connstr);
        //     response response  =new response();
        //     try
        //     {
        //         SqlCommand cmd=new SqlCommand("DeleteUserdetail", con);
        //         cmd.Parameters.AddWithValue("@userid", userid);
        //         cmd.CommandType=CommandType.StoredProcedure;
        //         con.Open();
        //         SqlDataAdapter da= new SqlDataAdapter();
        //         DataSet ds= new DataSet();
        //         da.SelectCommand=cmd;
        //         da.Fill(ds);
        //         var currentrow=ds.Tables[0].Rows[0];
        //         response.Message=currentrow["message"].ToString();
        //         response.IsSuccess=Convert.ToBoolean(currentrow["IsSuccess"]);
        //     }
        //     catch(Exception ex) 
        //     {
        //         response.IsSuccess=false;
        //         response.Message=ex.Message;

        //     }
        //     finally
        //     {
        //         con.Close();

        //     }
        //     return response;
        // }

        // public bool emailexist(string email)
        // {
        //     SqlConnection con= new SqlConnection(connstr);
        //     try
        //     {
        //         SqlCommand cmd=new SqlCommand("CheckEmail", con);
        //         cmd.Parameters.AddWithValue("@email", email);
        //         cmd.CommandType=CommandType.StoredProcedure;
        //         con.Open();
        //         SqlDataAdapter da= new SqlDataAdapter();
        //         DataSet ds= new DataSet();
        //         da.SelectCommand=cmd;
        //         da.Fill(ds);
        //         var currentrow=ds.Tables[0].Rows[0];
        //         return Convert.ToBoolean(currentrow["exist"]);
        //     }
        //     catch(Exception ex) 
        //     {
        //         return false;

        //     }
        //     finally
        //     {
        //         con.Close();
        //     }
        // }
    }
}
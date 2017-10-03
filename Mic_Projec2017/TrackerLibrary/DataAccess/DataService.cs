using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class DataService
    {
        //private const string db = "MicProject";
        //private const string konek = "IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings['MicProject'].ConnectionString)";
        //public List<CustomerModel> Getall(CustomerModel model)
        //{            
        //    using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[db].ConnectionString))
        //    {
        //        model.CustomerSearch = "";
        //        var p = new DynamicParameters();
        //        p.Add("@CustomerSearch", model.CustomerSearch);
        //        if (connection.State == ConnectionState.Closed)
        //        {
        //            connection.Open();
        //        }
        //        return connection.Query<CustomerModel>("sp_CustomerViewAllOrSearch", p, commandType: CommandType.StoredProcedure).ToList();
        //    }
        //}
        //public CustomerModel createCust(CustomerModel model)
        //{

        //    using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[db].ConnectionString))
        //    {
        //        var p = new DynamicParameters();
        //        p.Add("@CustomerNama", model.CustomerNama);
        //        p.Add("@CustomerAlamat", model.CustomerAlamat);
        //        p.Add("@CustomerKota", model.CustomerKota);
        //        p.Add("@CustomerTlp", model.CustomerTlp);
        //        p.Add("@CustomerPic", model.CustomerPic);
        //        p.Add("@CustomerEmail", model.CustomerEmail);
        //        p.Add("@CustomerInputBy", model.CustomerInputBy);
        //        //p.Add("@CustomerInputTgl", model.CustomerInputTgl);
        //        //p.Add("@Cust_Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
        //        p.Add("@Cust_Id", 0);
        //        connection.Execute("dbo.sp_CustomerAddOrUpdate", p, commandType: CommandType.StoredProcedure);
                
        //        return model;
        //    }
        //}

        //public LoginModel logon(LoginModel model)
        //{
        //    using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[db].ConnectionString))
        //    {
        //        var p = new DynamicParameters();
        //        p.Add("@UserId", model.UserID);
        //        p.Add("@Password", model.Password);
                
        //        model.Hitung = connection.ExecuteScalar<int>("dbo.SpLogin_Get_USerID", p, commandType: CommandType.StoredProcedure);

        //        return model;
        //    }
        //}
        //public CustomerModel cekCust(CustomerModel model)
        //{
        //    using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[db].ConnectionString))
        //    {
        //        var p = new DynamicParameters();
        //        p.Add("@Cust_Id", model.Cust_Id);
        //        p.Add("@CustomerNama", model.CustomerNama);
                
        //        model.Hitung = connection.ExecuteScalar<int>("dbo.SpCust_Cek_Nama", p, commandType: CommandType.StoredProcedure);

        //        return model;
        //    }
        //}
    }

}

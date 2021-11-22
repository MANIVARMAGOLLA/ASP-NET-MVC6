using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL
    {
        
        SqlConnection SqlConObj =new SqlConnection();
        SqlCommand SqlCmdObj =new SqlCommand();

        public int InsrertIntoDept(DTO dto)
        {
            try
            {
                SqlConObj.ConnectionString = ConfigurationManager.ConnectionStrings["AdvWorksADOConStr"].ConnectionString;
                SqlCmdObj.CommandText = @"usp_InsertIntoDept";
                SqlCmdObj.CommandType = CommandType.StoredProcedure;
                SqlCmdObj.Connection = SqlConObj;
                SqlCmdObj.Parameters.AddWithValue("@DeptName", dto.DeptName);
                SqlCmdObj.Parameters.AddWithValue("@DeptGroupName", dto.DeptGroupName);
                SqlCmdObj.Parameters.AddWithValue("@DeptModifiedDate", DateTime.Now);
                SqlParameter sqlpm = new SqlParameter();
                sqlpm.Direction = ParameterDirection.ReturnValue;
                sqlpm.SqlDbType = SqlDbType.Int;
                SqlCmdObj.Parameters.Add(sqlpm);
                SqlConObj.Open();
                SqlCmdObj.ExecuteNonQuery();
                return Convert.ToInt32(sqlpm.Value);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}

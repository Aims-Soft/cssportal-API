
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Options;
using UMISModuleAPI.Configuration;
using UMISModuleAPI.Entities;
using System.Data.SqlClient;
using System.IO;

namespace UMISModuleAPI.Services
{
    public class dapperQuery
    {

        //for fmis connection variable //
        public static IEnumerable<T> StrConQry<T>(string sql, string conStr)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                return con.Query<T>(sql).ToList();
            }
        }

        public static IEnumerable<T> Qry<T>(string sql, IOptions<conStr> conStr)
        {
            using (SqlConnection con = new SqlConnection(conStr.Value.dbCon))
            {
                return con.Query<T>(sql);
            }
        }

        public static IEnumerable<string> SPReturn<T>(string procedure, T model, IOptions<conStr> conStr)
        {
            using (IDbConnection con = new SqlConnection(conStr.Value.dbCon))
            {
                string[] response = new string[2];
                // check connection state
                if (con.State == ConnectionState.Closed)
                    con.Open();

                var row = con.Query<string>(procedure, model, commandType: CommandType.StoredProcedure);

                //close connection 
                if (con.State == ConnectionState.Open)
                    con.Close();

                return row;
            }
        }

        public static IEnumerable<string> SPReturnFMIS<T>(string procedure, T model, string conStr)
        {
            using (IDbConnection con = new SqlConnection(conStr))
            {
                string[] response = new string[2];
                // check connection state
                if (con.State == ConnectionState.Closed)
                    con.Open();

                var row = con.Query<string>(procedure, model, commandType: CommandType.StoredProcedure);

                //close connection 
                if (con.State == ConnectionState.Open)
                    con.Close();

                return row;
            }
        }
        public static string saveImageFile(string regPath, string name, string binData, string ext)
        {
            string path = regPath; //Path
            //Check if directory exist
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path); //Create directory if it doesn't exist
            }

            string imageName = name + "." + ext;

            //set the image path
            string imgPath = Path.Combine(path, imageName);

            byte[] imageBytes = Convert.FromBase64String(binData);

            System.IO.File.WriteAllBytes(imgPath, imageBytes);

            return "Ok";
        }
         
    }
}
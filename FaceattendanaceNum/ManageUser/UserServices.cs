using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace scanface.ManageUser
{
    public class UserServices
    {
       
        public  List<StudentSource> Getall()
        {
            string sql = @"SELECT u.UserID ID,u.UserName Name,u.Generation as Generation ,u.groups as Groups,u.Sex as sex,u.FaceScan as image ,r.RolesName,mj.MajorName MajorName
                from usernum u,roles r,userdetail d,major mj
                where u.UserID=d.UserID and d.RolesID=r.RolesID and d.MajorID=mj.MajorID";
            var con = new MySqlConnection(@"server=localhost;uid=root;pwd=loang*001;database=face-scan");
            if (ConnectionState.Closed == con.State)
            {
                con.Open();
            }

            var dapper = con.Query<StudentSource>(sql, "", commandType: CommandType.Text).ToList();
            return dapper;
        }
    }
}

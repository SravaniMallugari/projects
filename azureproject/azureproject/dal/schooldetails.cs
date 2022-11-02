using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bal;



namespace dal
{
    public class schooldetails
    {
        public List<classes> GetProducts()
        {
            SqlConnection c = new SqlConnection(@"Server = tcp:sravanidb.database.windows.net,1433; Initial Catalog = firstdatabase; Persist Security Info = False; User ID = sravanidb; Password =Sravani@123; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand("select * from Classes", c);
            c.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<classes> plist = new List<classes>();

            while (dr.Read())
            {
                plist.Add(new classes { class_roomno = Convert.ToInt32(dr[0]), class_strength = Convert.ToInt32(dr[1]) });

            }
            c.Close();
            c.Dispose();
            return plist;

        }
        public List<subjectss> GetProducts1()
        {
            SqlConnection c = new SqlConnection(@"Server = tcp:sravanidb.database.windows.net,1433; Initial Catalog = firstdatabase; Persist Security Info = False; User ID = sravanidb; Password =Sravani@123; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand("select * from subjects", c);
            c.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<subjectss> plist = new List<subjectss>();

            while (dr.Read())
            {
                plist.Add(new subjectss {subjects_id1 = Convert.ToInt32(dr[0]),subjects_name1 = dr[1].ToString() });

            }
            c.Close();
            c.Dispose();
            return plist;

        }
        public List<student> GetProducts2()
        {
            SqlConnection c = new SqlConnection(@"Server = tcp:sravanidb.database.windows.net,1433; Initial Catalog = firstdatabase; Persist Security Info = False; User ID = sravanidb; Password =Sravani@123; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand("select * from student ", c);
            c.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<student> plist = new List<student>();

            while (dr.Read())
            {
                plist.Add(new student { student_id = Convert.ToInt32(dr[0]), student_name = dr[1].ToString(), student_class = Convert.ToInt32(dr[2]) });

            }
            c.Close();
            c.Dispose();
            return plist;

        }
    }
}
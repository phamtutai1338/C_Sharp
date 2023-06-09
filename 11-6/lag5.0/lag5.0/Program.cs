using System ;
using System.Data.SqlClient;
using System.Data;
using lag5._0;

namespace products
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CreateData();
            GetData();


          }
        public static void GetData()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection conn = connectionDb.GetConnection();
            string query = "SELECT * FROM NHANVIEN";
            SqlCommand command = new SqlCommand(query, conn);   
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(" Name:" + reader[1] +"Desc: " + reader[2]);
            }
            conn.Close();
        }
        //
        public static void UpdateData()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection conn= connectionDb.GetConnection();
        }
        //
        public static void CreateData()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection conn = connectionDb.GetConnection();
            string query = "INSERT INTO NHANVIEN VALUES('100' ,N'Tú Tài','Nam','2003-09-19',N'Bình Định','23356')";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            int dataCount = command.ExecuteNonQuery();
            Console.WriteLine("Them {0} ban ghi thanh cong", dataCount);
           
            conn.Close();   
        }
        public static void DeleteData()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection conn = connectionDb.GetConnection();
        }
    }
}
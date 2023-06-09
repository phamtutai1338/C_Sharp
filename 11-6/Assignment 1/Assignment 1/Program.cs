
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;

namespace product
{
    class program
    {
        static void Main(string[] args)
        {
            Add();
            View_all();
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                menu();

                Console.WriteLine("Bạn có muốn tiếp tục sử dụng không ? (Y/N):");
                string s = Console.ReadLine();
                if (s == "N")

                    break;




            }
            Console.WriteLine("Exit!");
            Console.ReadLine();
        }
        private static void menu()
        {
            Console.WriteLine("\t\t\t\t\t========== Actions=========\a ");
          
            Console.WriteLine("1. Add product ");
            Console.WriteLine("2. Edit product ");
            Console.WriteLine("3. Delete product ");
            Console.WriteLine("4. View all product ");
            Console.WriteLine("5. Search product by id ");
            Console.WriteLine("6. Search product by name  ");
            Console.WriteLine("Bạn chọn chức năng gì ?");
            try
            {
                int cn = int.Parse(Console.ReadLine());
                switch (cn)
                {
                    case 1:
                        Add ();
                        break;
                    case 2:
                        Edit ();
                        break;
                    case 3:
                        Delete ();
                        break;
                    case 4:
                        View_all ();
                        break;
                    case 5:
                        Search_id();
                        break;
                    case 6:
                        Search_name();
                        break;
                    default:
                        Console.WriteLine("Vui lòng nhập lại!");
                        break;


                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi gì đó : " + ex.Message);
            }
        }
        private static void Add ()
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
        private static void Edit()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection conn = connectionDb.GetConnection();

           
        }
        private static void Delete()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection conn = connectionDb.GetConnection();
            
        }
        private static void View_all()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection conn = connectionDb.GetConnection();
            string query = "SELECT * FROM NHANVIEN";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(" Name:" + reader[1] + "Desc: " + reader[2]);
            }
            conn.Close();
        }
        private static void Search_id()
        {

        }
        private static void Search_name()
        {

        }
    }  
}
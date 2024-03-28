// using System;
// using System.Data;
// using System.Linq.Expressions;
// using MySql.Data.MySqlClient;
// namespace DatabaseTest
// {
//     class Program
//     {
//         MySqlConnection conn;
//         MySqlCommand cmd;
//         void CreateConnection()
//         {
//             string constr = "server=localhost;database=dotnet;user=root;password=root";
//             conn = new MySqlConnection(constr);
//             conn.Open();
//         }
       

//         void InsertUpdateDelete(string sql)
//         {
//             cmd = new MySqlCommand(sql, conn);
//             cmd.ExecuteNonQuery();
//             Console.WriteLine("Operation performed Successfully!");
//         }

//         void SelectRecords(string sql)
//         {
//             cmd = new MySqlCommand(sql, conn);
//             MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
//             DataTable dt = new DataTable();
//             adapter.Fill(dt);
//             if (dt.Rows.Count != 0)
//             {
//                 Console.WriteLine("\t id \t Name \t Address");
//                 for (int i = 0; i < dt.Rows.Count; i++)
//                 {
//                     string id = dt.Rows[i]["id"].ToString();
//                     string name = dt.Rows[i]["name"].ToString();
//                     string address = dt.Rows[i]["address"].ToString();
//                     Console.WriteLine("\t " + id + " \t " + name + " \t " + address);

//                 }

//             }

//         }

//         static void Main()
//         {
//             Program obj = new Program();
//             try
//             {
//                 obj.CreateConnection();
//             x: Console.WriteLine("1. Insert \t 2. Update\t 3. Delete\t 4. Select");

//                 Console.WriteLine("Enter your Choice:");
//                 int n = Convert.ToInt32(Console.ReadLine());
//                 string sql = "", nm = "", add = "";
//                 int id = 0;
//                 switch (n)
//                 {

                
//                     case 1:
//                         Console.WriteLine("Enter name of student:");
//                         nm = Console.ReadLine();
//                         Console.WriteLine("Enter address of student:");
//                         add = Console.ReadLine();
//                         sql = "INSERT INTO tblStudent (name, address) VALUES ('" + nm + "','" + add + "')";
//                         obj.InsertUpdateDelete(sql);
//                         break;



//                     case 2:
//                         Console.WriteLine("Enter id to be updated");
//                         id = Convert.ToInt32(Console.ReadLine());
//                         Console.WriteLine("Enter name of student:");
//                         nm = Console.ReadLine();
//                         Console.WriteLine("Enter address of student:");
//                         add = Console.ReadLine();
//                         sql = "UPDATE tblStudent SET name='" + nm + "', address='" + add + "' WHERE id=" + id;
//                         obj.InsertUpdateDelete(sql);
//                         break;

//                     case 3:
//                         Console.WriteLine("Enter id to be deleted");
//                         id = Convert.ToInt32(Console.ReadLine());
//                         sql = "DELETE FROM tblStudent WHERE id=" + id;
//                         obj.InsertUpdateDelete(sql);
//                         break;

//                     case 4:
//                         sql = "SELECT * FROM tblStudent";
//                         obj.SelectRecords(sql);
//                         break;

//                     default:
//                         Console.WriteLine("Invalid Choice!");
//                         break;


//                 }
//                 goto x;


//             }
//             catch (Exception e)
//             {
//                 Console.WriteLine(e.Message);
//                 Console.WriteLine("Connection Failed!");
//             }
//             Console.ReadKey();

//         }
//     }

// }




















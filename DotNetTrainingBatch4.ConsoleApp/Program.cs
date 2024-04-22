// See https://aka.ms/new-console-template for more information
using ZHADotNetCore.ConsoleApp;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

/*SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();

stringBuilder.DataSource = "(localdb)\\MSSQLLocalDB";  // Server Name
stringBuilder.InitialCatalog = "DotNetTrainingBatch4";
stringBuilder.UserID = "sa";
stringBuilder.Password = "11111111";

SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);

connection.Open();
Console.WriteLine("Connection Open");

string query = "select * from tbl_blog";
SqlCommand cmd = new SqlCommand(query, connection);

SqlDataAdapter adapter = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();

adapter.Fill(dt);

connection.Close();
Console.WriteLine("Connection Close");

foreach (DataRow dr in dt.Rows)
{
    Console.WriteLine("Blog Id => ", dr["BlogId"]);
    Console.WriteLine("Blog Title => ", dr["BlogTitle"]);
    Console.WriteLine("Blog Author => ", dr["BlogAuthor"]);
    Console.WriteLine("Blog Content => ", dr["BlogContent"]);
    Console.WriteLine("-----------------------------------");
}*/

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();

adoDotNetExample.Read();
/*adoDotNetExample.Create("test2", "zeenick", "long time no see");*/
/*adoDotNetExample.Update(13, "Test 4", "မောင်မောင်", "မတွေ့တာကြာပြီနော် သားကြီး");*/
/*adoDotNetExample.Delete(1);*/

adoDotNetExample.Edit(2);

Console.ReadKey();
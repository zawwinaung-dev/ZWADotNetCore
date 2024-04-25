// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;
using ZWADotNetCore.ConsoleApp;

Console.WriteLine("Hello, World!");

//SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
//stringBuilder.DataSource = "."; //server name
//stringBuilder.InitialCatalog = "ZWADotNetCore"; //database name
//stringBuilder.UserID = "sa";
//stringBuilder.Password = "sa@123";
//SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);

//connection.Open();
//Console.WriteLine("Connection open.");

//string query = "select * from tbl_blog";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//sqlDataAdapter.Fill(dt);

//connection.Close();
//Console.WriteLine("Connection close.");

//// dataset => datatable
//// datatable => datarow
//// datarow => datacolumn

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine("blog id => " + dr["blogid"]);
//    Console.WriteLine("blog title => " + dr["blogtitle"]);
//    Console.WriteLine("blog author => " + dr["blogauthor"]);
//    Console.WriteLine("blog content => " + dr["blogcontent"]);
//    Console.WriteLine("---------------------------------------");
//}

// Ado.Net Read

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");
//adoDotNetExample.Update(12, "test title", "test author", "test content");
//adoDotNetExample.Delete(12);
//adoDotNetExample.Edit(12);
//adoDotNetExample.Edit(1);

DapperExample dapperExample = new DapperExample();
dapperExample.Run();

Console.ReadKey();

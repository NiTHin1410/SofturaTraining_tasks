using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace SimpleActivity
{
    class Simple_Activity
    {
        SqlConnection con = new SqlConnection("Data source = AsHWiN; database = trial; user id = sa; password = P@ssw0rd");
        public void ProductList()
        {
            string prolist = "Select *from Product_table";
            SqlCommand cmd = new SqlCommand(prolist, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("ProdID : " + dr[0] + " " + "ProdName : " + dr[1] + "  " + "Price : " + dr[2] + "  " + "DateOdManu : " + dr[3] + "  " + "ExpiryDate : " + dr[4]);
            }
        }
        public void CustomerTable()
        {
            Console.WriteLine("If you Forgot your your CustID Please Enter your Name:");
            string CusID = Console.ReadLine();
            SqlConnection con = new SqlConnection("Data source = AsHWiN; database = trial; user id = sa; password = P@ssw0rd");
            string oldcust = "select*from Customer_table where Name ='" + CusID + "'";
            SqlCommand scmd = new SqlCommand(oldcust, con);
            con.Open();
            SqlDataReader dr = scmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("CostID : " + dr[0] + " " + "Name : " + dr[1] + " " + "Gender :" + dr[2] + " " + "DOB: " + dr[3] + " " + "ContactNO: " + dr[4] + " " + "EmailId: " + dr[5] + "  " + " City: " + dr[6]);
            }
            Simple_Activity obj1 = new Simple_Activity();
            obj1.ProductList();
            con.Close();

        }
        public void NewCost()
        {
            Console.WriteLine("Enter the name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Gender:");
            string Gender = Console.ReadLine();
            Console.WriteLine("Enter the Dob:");
            string DOB = Console.ReadLine();
            Console.WriteLine("Enter the ContactNo:");
            string ContactNo = Console.ReadLine();
            Console.WriteLine("Enter the MailID:");
            string EmailID = Console.ReadLine();
            Console.WriteLine("Enter the City(Chennai/Mumbai):");
            string City = Console.ReadLine();
            string CustDetails = "insert Customer_table(Name,Gender,DOB,ContactNo,EmailID,City) values('" + Name + "','" + Gender + "','" + DOB + "','" + ContactNo + "','" + EmailID + "','" + City + "')";
            SqlCommand cmd = new SqlCommand(CustDetails, con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Customer Details inserted !!!");
            //SqlDataReader dr = cmd.ExecuteReader();
            while (true)
            {
                SqlConnection con1 = new SqlConnection("Data source = AsHWiN; database = trial; user id = sa; password = P@ssw0rd");
                SqlCommand cmd1 = new SqlCommand("select CustID  from Customer_table where Name='"+Name +"'",con1);
                con1.Open();    
                //cmd1.ExecuteNonQuery();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    Console.WriteLine("Your Customer ID is : " + dr1[0]);
                }
                con1.Close();
                break;
            }
            Console.WriteLine();
            Simple_Activity obj1 = new Simple_Activity();
            obj1.ProductList();
            con.Close();
        }
        public void purchaseList()
        {
            Console.WriteLine("Enter the CustomerID:");
            string cus = Console.ReadLine();
            Console.WriteLine("Enter the ProductID:");
            string pur = Console.ReadLine();
            Console.WriteLine("Enter the Quantity:");
            int unit = Convert.ToInt32(Console.ReadLine());
            SqlConnection con = new SqlConnection("Data source = AsHWiN; database = trial; user id = sa; password = P@ssw0rd");
            SqlCommand cmd = new SqlCommand("select Price* " + unit + " ,ProdID,ProdName,Price from Product_table where ProdID = " + pur + "", con);
            //SqlCommand cmd = new SqlCommand(pl, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                int Total = Convert.ToInt32(dr[0]);
                Console.WriteLine("ProdID : " + dr[1] + " " + "   ProdName : " + dr[2] + "  " + "  Price : " + dr[3] + "  Total Amount :  " + Total);
                string purins = "insert Purchase_table (CustID,ProdID,Quantity,TotalAmount) values ("+ cus + ","+ pur + ","+unit+","+ Total + ")";
                SqlConnection con1 = new SqlConnection("Data source = AsHWiN; database = trial; user id = sa; password = P@ssw0rd");
                SqlCommand cmd1 = new SqlCommand(purins, con1);
                con1.Open();
                cmd1.ExecuteNonQuery();
                Console.WriteLine("                                   Thank You");
                //Console.WriteLine("purchase Details Inserted");
                con1.Close();
            }
            con.Close();
            //Simple_Activity obj = new Simple_Activity();
            //obj.ShowBill(cus);
        }
        public void ShowBill(string cus)
        {
            string bill = "select  CustID,ptt.ProdID,ProdName,Price,Quantity,TotalAmount from Product_table pt join Purchase_table ptt on pt.ProdID = ptt.ProdID where CustID=" + cus + "";
            SqlCommand cmd = new SqlCommand(bill, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(" CustomerID : " + dr[0] + " ProductID : " + dr[1]  + " ProdName : " + dr[2] + " Quantity : " + dr[3] + " TotalAmount : " + dr[4] + " Date : " + dr[5]);
            }
            con.Close();
        }
            public void showPurchase()
        {
            Console.WriteLine();
            Console.WriteLine("Enter your CustID To View Your Purchase Information:");
            string cuss = Console.ReadLine();
            SqlConnection con = new SqlConnection("Data source = AsHWiN; database = trial; user id = sa; password = P@ssw0rd");
            string purch = "select  CustID,ptt.ProdID,ProdName,Price,Quantity,TotalAmount from Product_table pt join Purchase_table ptt on pt.ProdID = ptt.ProdID where CustID="+cuss+"";
            SqlCommand cmd = new SqlCommand(purch,con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("                                        PURCHASE INFORMATION ");
            while (dr.Read())
            {
                //Console.WriteLine("                                        PURCHASE INFORMATION ");
                Console.WriteLine("CustomerID : " + dr[0] +" "+ "ProductID : " + dr[1] +" "+ "ProductName : " + dr[2] + " "+"Price : " + dr[3] +" "+ "Quantity : " + dr[4]+" " + "TotalAmount : " + dr[5]);
            }
            con.Close();
        }
        public void showPurchaseBDate()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the Date:");
            var Date =Convert.ToString( Console.ReadLine());
            SqlConnection con = new SqlConnection("Data source = AsHWiN; database = trial; user id = sa; password = P@ssw0rd");
            string purch = "select  CustID,ptt.ProdID,ProdName,Price,Quantity,TotalAmount,PurchaseDate from Product_table pt join Purchase_table ptt on pt.ProdID = ptt.ProdID where PurchaseDate='" + Date + "'";
            SqlCommand cmd = new SqlCommand(purch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("                                  PURCHASE INFORMATION By Using Date");
            while (dr.Read())
            {
                //Console.WriteLine("                                        PURCHASE INFORMATION ");
                Console.WriteLine("CustomerID : " + dr[0] + " " + "ProductID : " + dr[1] + " " + "ProductName : " + dr[2] + " " + "Price : " + dr[3] + " " + "Quantity : " + dr[4] + " " + "TotalAmount : " + dr[5]);
            }
            con.Close();
        }
            public static void Main()
        {
            Console.WriteLine("                                             WELLCOME  ");
            Simple_Activity obj = new Simple_Activity();
            Console.WriteLine("If You are Existing Costomer (Y/N) // If You want your Details Enter VIEW");
            string ver = Console.ReadLine();
            switch (ver)
            {
                case "VIEW":
                    obj.CustomerTable();
                    break;
                case "Y":
                    obj.ProductList();
                    break;
                case "N":
                    obj.NewCost();
                    break;
            }

            obj.purchaseList();
            obj.showPurchase();
            obj.showPurchaseBDate();
            
        }
    }
}




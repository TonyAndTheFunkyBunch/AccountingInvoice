using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Accounting_Invoice
{
    public partial class InvoiceForm : MetroForm
    {

        MySqlCommand com;
        MySqlConnection con;
        MySqlDataReader data;

        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection();
      
            autogenerate();
            autogeneratex();
            cancelbtn.Visible = false;

            duedatetxbx.Value = duedatetxbx.Value.AddDays(15);
        }

        public void loadx()
        {

          
                con.Open();
                com = new MySqlCommand("Truncate table tbl_invoice", con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                com = new MySqlCommand("Truncate table tbl_invoice_one", con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                com = new MySqlCommand("Truncate table tbl_invoice_two", con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                com = new MySqlCommand("Truncate table tbl_invoice_three", con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                com = new MySqlCommand("Truncate table tbl_invoice_four", con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                com = new MySqlCommand("Truncate table tbl_invoice_five", con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                com = new MySqlCommand("Truncate table tbl_invoice_six", con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                com = new MySqlCommand("Truncate table tbl_invoice_seven", con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                com = new MySqlCommand("Truncate table tbl_pleasegumanakafck", con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                com = new MySqlCommand("Truncate table tbl_subtotal", con);
                com.ExecuteNonQuery();
                con.Close();


            


        }


        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_accountinginvoice; UID = root; password = 0000");
            con.Open();
            con.Close();
        }

        public void insert()
        {
            con.Open(); //1
            com = new MySqlCommand("Insert into db_accountinginvoice.tbl_pleasegumanakafck(ToCompany,DateCompany,DueCompany,InvoiceCompany,ReferenceCompany,ClientidCompany) values ('" + totxbx.Text + "' , '" + datetxbx.Text + "','" + duedatetxbx.Text + "','" + invoicetxbx.Text + "','" + referencetxbx.Text + "','" + ClientIDtxbx.Text +"')", con);
            com.ExecuteNonQuery();
            con.Close();



            if (qtyonetxbx.Text != "")
            {

                con.Open(); //1
                com = new MySqlCommand("Insert into db_accountinginvoice.tbl_invoice(Item,Description,Qty,UnitPrice,Discount,Account,Taxrate,AmountPhp) values ('" + itemonetxbx.Text + "','" + descriptiononetxbx.Text + "','" + qtyonetxbx.Text + "','" + unitonetxbx.Text + "','" + discountonetxbx.Text + "','" + accountonetxbx.Text + "','" + taxrateonetxbx.Text + "','" + amountonetxbx.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();

            }

            if (qtytwotxbx.Text != "")
            {
                con.Open();//2
                com = new MySqlCommand("Insert into db_accountinginvoice.tbl_invoice_one(Item,Description,Qty,UnitPrice,Discount,Account,Taxrate,AmountPhp) values ('" + itemtwotxbx.Text + "','" + descriptiontwotxbx.Text + "','" + qtytwotxbx.Text + "','" + unittwotxbx.Text + "','" + discounttwotxbx.Text + "','" + accounttwotxbx.Text + "','" + taxratetwotxbx.Text + "','" + amounttwotxbx.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }

            if (qtythreetxbx.Text != "")
            {
                con.Open();//3
                com = new MySqlCommand("Insert into db_accountinginvoice.tbl_invoice_two(Item,Description,Qty,UnitPrice,Discount,Account,Taxrate,AmountPhp) values ('" + itemthreetxbx.Text + "','" + descriptionthreetxbx.Text + "','" + qtythreetxbx.Text + "','" + unitthreetxbx.Text + "','" + discountthreetxbx.Text + "','" + accountthreetxbx.Text + "','" + taxratethreetxbx.Text + "','" + amountthreetxbx.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }

            if (qtyfourtxbx.Text != "")
            {
                con.Open();//4
                com = new MySqlCommand("Insert into db_accountinginvoice.tbl_invoice_three(Item,Description,Qty,UnitPrice,Discount,Account,Taxrate,AmountPhp) values ('" + itemfourtxbx.Text + "','" + descriptionfourtxbx.Text + "','" + qtyfourtxbx.Text + "','" + unitfourtxbx.Text + "','" + discountfourtxbx.Text + "','" + accountfourtxbx.Text + "','" + taxfourtxbx.Text + "','" + amountfourtxbx.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }

            if (qtyfivetxbx.Text != "")
            {
                con.Open();//5
                com = new MySqlCommand("Insert into db_accountinginvoice.tbl_invoice_four(Item,Description,Qty,UnitPrice,Discount,Account,Taxrate,AmountPhp) values ('" + itemfivetxbx.Text + "','" + descriptionfivetxbx.Text + "','" + qtyfivetxbx.Text + "','" + unitfivetxbx.Text + "','" + discountfivetxbx.Text + "','" + accountfivetxbx.Text + "','" + taxratefivetxbx.Text + "','" + refreshbtn.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }

            if (qtysixtxbx.Text != "")
            {
                con.Open();//6
                com = new MySqlCommand("Insert into db_accountinginvoice.tbl_invoice_five(Item,Description,Qty,UnitPrice,Discount,Account,Taxrate,AmountPhp) values ('" + itemsixtxbx.Text + "','" + descriptionsixtxbx.Text + "','" + qtysixtxbx.Text + "','" + unitysixtxbx.Text + "','" + discountsixtxbx.Text + "','" + accountsixtxbx.Text + "','" + taxratesixtxbx.Text + "','" + amountsixtxbx.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }

            if (qtyseventxbx.Text != "")
            {
                con.Open();//7
                com = new MySqlCommand("Insert into db_accountinginvoice.tbl_invoice_six(Item,Description,Qty,UnitPrice,Discount,Account,Taxrate,AmountPhp) values ('" + itemseventxbx.Text + "','" + descriptionseventxbx.Text + "','" + qtyseventxbx.Text + "','" + unitseventxbx.Text + "','" + discountseventxbx.Text + "','" + accountseventxbx.Text + "','" + taxrateseventxbx.Text + "','" + amountseventxbx.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }

            if (qtyeighttxbx.Text != "")
            {
                con.Open();//8
                com = new MySqlCommand("Insert into db_accountinginvoice.tbl_invoice_seven(Item,Description,Qty,UnitPrice,Discount,Account,Taxrate,AmountPhp) values ('" + itemeighttxbx.Text + "','" + descriptioneighttxbx.Text + "','" + qtyeighttxbx.Text + "','" + uniteighttxbx.Text + "','" + discounteighttxbx.Text + "','" + accounteighttxbx.Text + "','" + taxrateeighttxbx.Text + "','" + amounteighttxbx.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }

            con.Open();//total
            com = new MySqlCommand("Insert into db_accountinginvoice.tbl_subtotal(Subtotal,Tax,Total) values ('" + subtotalholder.Text + "','" + taxholderfinal.Text + "','" + totalfinal.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
     
        }


        public void autogenerate()
        {

            con.Open();
            com = new MySqlCommand("SELECT MAX(AccNumber)as maxid FROM AccountNumber", con);
            data = com.ExecuteReader();
            data.Read();

            var id = data.GetString("maxid");
            var x = "1";
            int a = Convert.ToInt32(id);
            int b = Convert.ToInt32(x);

            int y = a + b;

            int length = 4;
            String result = y.ToString().PadLeft(length, '0');
            String INV = "INV-" + result;

            invoicetxbx.Text = INV;
            invoicetxbxholder.Text = result;

            con.Close();

        }

        public void autogeneratex()
        {

            con.Open();
            com = new MySqlCommand("SELECT MAX(AccNumberWithINV)as maxholder FROM AccountNumberBS", con);
            data = com.ExecuteReader();
            data.Read();

            var id = data.GetString("maxholder");
            var x = "1";
            int a = Convert.ToInt32(id);
            int b = Convert.ToInt32(x);

            int y = a + b;

            int length = 4;
            String result = y.ToString().PadLeft(length, '0');
            String INV = "BS-" + result;

            referencetxbx.Text = INV;
            referencetxbxholder.Text = result;

            con.Close();

        }



        public void autoincrement()
        {

            con.Open();
            com = new MySqlCommand("Insert into db_accountinginvoice.AccountNumber(AccNumber,AccNumberWithINV) values ('" + invoicetxbxholder.Text + "','" + invoicetxbx.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
        }

        public void autoincrementref()
        {

            con.Open();
            com = new MySqlCommand("Insert into db_accountinginvoice.AccountNumberBS(AccNumberWithINV,AccNumber) values ('" + referencetxbxholder.Text + "','" + referencetxbx.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
        }





        private void metroLabel3_Click(object sender, EventArgs e)
        {
            
        }

        private void computefirsttxbx_Click(object sender, EventArgs e)
        {
           
            

                check();
          
         
      
        }


        public void check()
        {
            if (itemonetxbx.Text == "" || descriptiononetxbx.Text == "" || qtyonetxbx.Text == "" || unitonetxbx.Text == "" || accountonetxbx.Text == "" || taxrateonetxbx.Text == "")
            {
                MessageBox.Show("Please Fill up all the fields");
                return;
            }
            else
            {
                double qty = Convert.ToDouble(qtyonetxbx.Text);
                double unit = Convert.ToDouble(unitonetxbx.Text);

                double totalQtyandUnit = qty * unit;
                String totalqtyandunitholder = System.Convert.ToString(totalQtyandUnit);

                if (taxrateonetxbx.Text == "VAT (12%)")
                {
                    double tax = totalQtyandUnit * .12;
                    String totalQtyandUnittax = System.Convert.ToString(tax);
                    taxholder.Text = totalQtyandUnittax;


                    double subtax = Convert.ToDouble(taxholderfinal.Text); //subtax
                    double totaltax = subtax + tax;
                    String subtaxholders = System.Convert.ToString(totaltax);
                    taxholderfinal.Text = subtaxholders;


                }

                holderone.Text = totalqtyandunitholder;

                double subtotal = Convert.ToDouble(subtotalholder.Text); // subtotal
                double total = subtotal + totalQtyandUnit;
                String subtotalholders = System.Convert.ToString(total);
                subtotalholder.Text = subtotalholders;
                addtwo.Visible = true;

           

                double subtotalx = Convert.ToDouble(subtotalholder.Text);
                double subtaxtotalx = Convert.ToDouble(taxholderfinal.Text);
                double totalall = subtotalx + subtaxtotalx;

                String totalltaxandsub = System.Convert.ToString(totalall);

                totalfinal.Text = totalltaxandsub;


                String holderuna = System.Convert.ToString(taxholderfinal.Text);
                String holdertwo = System.Convert.ToString(subtotalholder.Text);

                subtotaltext.Text = holdertwo;
                taxtext.Text = holderuna;
                finaltotal.Text = totalltaxandsub;

                computefirsttxbx.Enabled = false;

                amountonetxbx.Text = unitonetxbx.Text;

            }

            

        }

        public void checktwo()
        {

            if (itemtwotxbx.Text == "" || descriptiontwotxbx.Text == "" || qtytwotxbx.Text == "" || unittwotxbx.Text == "" || accounttwotxbx.Text == "" || taxratetwotxbx.Text == "")
            {
                MessageBox.Show("Please Fill up all the fields");
                return;
            }
            else
            {
                double qty = Convert.ToDouble(qtytwotxbx.Text);
                double unit = Convert.ToDouble(unittwotxbx.Text);

                double totalQtyandUnit = qty * unit;
                String totalqtyandunitholder = System.Convert.ToString(totalQtyandUnit);

                if (taxratetwotxbx.Text == "VAT (12%)")
                {
                    double tax = totalQtyandUnit * .12;
                    String totalQtyandUnittax = System.Convert.ToString(tax);
                    taxholdertwo.Text = totalQtyandUnittax;


                    double subtax = Convert.ToDouble(taxholderfinal.Text); //subtax
                    double totaltax = subtax + tax;
                    String subtaxholders = System.Convert.ToString(totaltax);
                    taxholderfinal.Text = subtaxholders;


                }

                holdertwo.Text = totalqtyandunitholder;
                addthree.Visible = true;

                double subtotal = Convert.ToInt32(subtotalholder.Text); // subtotal
                double total = subtotal + totalQtyandUnit;
                String subtotalholders = System.Convert.ToString(total);
                subtotalholder.Text = subtotalholders;


                double subtotalx = Convert.ToDouble(subtotalholder.Text);
                double subtaxtotalx = Convert.ToDouble(taxholderfinal.Text);
                double totalall = subtotalx + subtaxtotalx;

                String totalltaxandsub = System.Convert.ToString(totalall);

                totalfinal.Text = totalltaxandsub;

                String holdermuna = System.Convert.ToString(taxholderfinal.Text);
                String holdertwod = System.Convert.ToString(subtotalholder.Text);

                subtotaltext.Text = holdertwod;

                taxtext.Text = holdermuna;
                finaltotal.Text = totalltaxandsub;
                computetwo.Enabled = false;
                amounttwotxbx.Text = unittwotxbx.Text;
            }
        }


        public void checkthree()
        {

            if (itemthreetxbx.Text == "" || descriptionthreetxbx.Text == "" || qtythreetxbx.Text == "" || unitthreetxbx.Text == "" || accountthreetxbx.Text == "" || taxratethreetxbx.Text == "")
            {
                MessageBox.Show("Please Fill up all the fields");
                return;
            }
            else
            {
                double qty = Convert.ToDouble(qtythreetxbx.Text);
                double unit = Convert.ToDouble(unitthreetxbx.Text);

                double totalQtyandUnit = qty * unit;
                String totalqtyandunitholder = System.Convert.ToString(totalQtyandUnit);

                if (taxratethreetxbx.Text == "VAT (12%)")
                {
                    double tax = totalQtyandUnit * .12;
                    String totalQtyandUnittax = System.Convert.ToString(tax);
                    taxholderthree.Text = totalQtyandUnittax;


                    double subtax = Convert.ToDouble(taxholderfinal.Text); //subtax
                    double totaltax = subtax + tax;
                    String subtaxholders = System.Convert.ToString(totaltax);
                    taxholderfinal.Text = subtaxholders;


                }

                holderthree.Text = totalqtyandunitholder;
                addfour.Visible = true;

                double subtotal = Convert.ToInt32(subtotalholder.Text); // subtotal
                double total = subtotal + totalQtyandUnit;
                String subtotalholders = System.Convert.ToString(total);
                subtotalholder.Text = subtotalholders;


                double subtotalx = Convert.ToDouble(subtotalholder.Text);
                double subtaxtotalx = Convert.ToDouble(taxholderfinal.Text);
                double totalall = subtotalx + subtaxtotalx;

                String totalltaxandsub = System.Convert.ToString(totalall);

                totalfinal.Text = totalltaxandsub;

                String holdermuna = System.Convert.ToString(taxholderfinal.Text);
                String holdertwod = System.Convert.ToString(subtotalholder.Text);

                subtotaltext.Text = holdertwod;

                taxtext.Text = holdermuna;
                finaltotal.Text = totalltaxandsub;
                computethree.Enabled = false;
                amountthreetxbx.Text = unitthreetxbx.Text;
                addfour.Visible = true;

            }
        }


        public void checkfour()
        {

            if (itemfourtxbx.Text == "" || descriptionfourtxbx.Text == "" || qtyfourtxbx.Text == "" || unitfourtxbx.Text == "" || accountfourtxbx.Text == "" || taxfourtxbx.Text == "")
            {
                MessageBox.Show("Please Fill up all the fields");
                return;
            }
            else
            {
                double qty = Convert.ToDouble(qtyfourtxbx.Text);
                double unit = Convert.ToDouble(unitfourtxbx.Text);

                double totalQtyandUnit = qty * unit;
                String totalqtyandunitholder = System.Convert.ToString(totalQtyandUnit);

                if (taxfourtxbx.Text == "VAT (12%)")
                {
                    double tax = totalQtyandUnit * .12;
                    String totalQtyandUnittax = System.Convert.ToString(tax);
                    taxholderfour.Text = totalQtyandUnittax;


                    double subtax = Convert.ToDouble(taxholderfinal.Text); //subtax
                    double totaltax = subtax + tax;
                    String subtaxholders = System.Convert.ToString(totaltax);
                    taxholderfinal.Text = subtaxholders;


                }

                holderfour.Text = totalqtyandunitholder;
                addfive.Visible = true;

                double subtotal = Convert.ToInt32(subtotalholder.Text); // subtotal
                double total = subtotal + totalQtyandUnit;
                String subtotalholders = System.Convert.ToString(total);
                subtotalholder.Text = subtotalholders;


                double subtotalx = Convert.ToDouble(subtotalholder.Text);
                double subtaxtotalx = Convert.ToDouble(taxholderfinal.Text);
                double totalall = subtotalx + subtaxtotalx;

                String totalltaxandsub = System.Convert.ToString(totalall);

                totalfinal.Text = totalltaxandsub;

                String holdermuna = System.Convert.ToString(taxholderfinal.Text);
                String holdertwod = System.Convert.ToString(subtotalholder.Text);

                subtotaltext.Text = holdertwod;

                taxtext.Text = holdermuna;
                finaltotal.Text = totalltaxandsub;
                computefour.Enabled = false;
                amountfourtxbx.Text = unitfourtxbx.Text;
                addfive.Visible = true;

            }
        }


        public void checkfive()
        {

            if (itemfivetxbx.Text == "" || descriptionfivetxbx.Text == "" || qtyfivetxbx.Text == "" || unitfivetxbx.Text == "" || accountfivetxbx.Text == "" || taxratefivetxbx.Text == "")
            {
                MessageBox.Show("Please Fill up all the fields");
                return;
            }
            else
            {
                double qty = Convert.ToDouble(qtyfivetxbx.Text);
                double unit = Convert.ToDouble(unitfivetxbx.Text);

                double totalQtyandUnit = qty * unit;
                String totalqtyandunitholder = System.Convert.ToString(totalQtyandUnit);

                if (taxratefivetxbx.Text == "VAT (12%)")
                {
                    double tax = totalQtyandUnit * .12;
                    String totalQtyandUnittax = System.Convert.ToString(tax);
                    taxholderfive.Text = totalQtyandUnittax;


                    double subtax = Convert.ToDouble(taxholderfinal.Text); //subtax
                    double totaltax = subtax + tax;
                    String subtaxholders = System.Convert.ToString(totaltax);
                    taxholderfinal.Text = subtaxholders;


                }

                holderfive.Text = totalqtyandunitholder;
                addsix.Visible = true;

                double subtotal = Convert.ToInt32(subtotalholder.Text); // subtotal
                double total = subtotal + totalQtyandUnit;
                String subtotalholders = System.Convert.ToString(total);
                subtotalholder.Text = subtotalholders;


                double subtotalx = Convert.ToDouble(subtotalholder.Text);
                double subtaxtotalx = Convert.ToDouble(taxholderfinal.Text);
                double totalall = subtotalx + subtaxtotalx;

                String totalltaxandsub = System.Convert.ToString(totalall);

                totalfinal.Text = totalltaxandsub;

                String holdermuna = System.Convert.ToString(taxholderfinal.Text);
                String holdertwod = System.Convert.ToString(subtotalholder.Text);

                subtotaltext.Text = holdertwod;

                taxtext.Text = holdermuna;
                finaltotal.Text = totalltaxandsub;
                computefive.Enabled = false;
                refreshbtn.Text = unitfivetxbx.Text;
                addsix.Visible = true;

            }
        }


        public void checksix()
        {

            if (itemsixtxbx.Text == "" || descriptionsixtxbx.Text == "" || qtysixtxbx.Text == "" || unitysixtxbx.Text == "" || accountsixtxbx.Text == "" || taxratesixtxbx.Text == "")
            {
                MessageBox.Show("Please Fill up all the fields");
                return;
            }
            else
            {
                double qty = Convert.ToDouble(qtysixtxbx.Text);
                double unit = Convert.ToDouble(unitysixtxbx.Text);

                double totalQtyandUnit = qty * unit;
                String totalqtyandunitholder = System.Convert.ToString(totalQtyandUnit);

                if (taxratesixtxbx.Text == "VAT (12%)")
                {
                    double tax = totalQtyandUnit * .12;
                    String totalQtyandUnittax = System.Convert.ToString(tax);
                    taxholdersix.Text = totalQtyandUnittax;


                    double subtax = Convert.ToDouble(taxholderfinal.Text); //subtax
                    double totaltax = subtax + tax;
                    String subtaxholders = System.Convert.ToString(totaltax);
                    taxholderfinal.Text = subtaxholders;


                }

                holdersix.Text = totalqtyandunitholder;
                addseven.Visible = true;

                double subtotal = Convert.ToInt32(subtotalholder.Text); // subtotal
                double total = subtotal + totalQtyandUnit;
                String subtotalholders = System.Convert.ToString(total);
                subtotalholder.Text = subtotalholders;


                double subtotalx = Convert.ToDouble(subtotalholder.Text);
                double subtaxtotalx = Convert.ToDouble(taxholderfinal.Text);
                double totalall = subtotalx + subtaxtotalx;

                String totalltaxandsub = System.Convert.ToString(totalall);

                totalfinal.Text = totalltaxandsub;

                String holdermuna = System.Convert.ToString(taxholderfinal.Text);
                String holdertwod = System.Convert.ToString(subtotalholder.Text);

                subtotaltext.Text = holdertwod;

                taxtext.Text = holdermuna;
                finaltotal.Text = totalltaxandsub;

                computesix.Enabled = false;
                amountsixtxbx.Text = unitysixtxbx.Text;
                addseven.Visible = true;
            }
        }


        public void checkseven()
        {

            if (itemseventxbx.Text == "" || descriptionseventxbx.Text == "" || qtyseventxbx.Text == "" || unitseventxbx.Text == "" || accountseventxbx.Text == "" || taxrateseventxbx.Text == "")
            {
                MessageBox.Show("Please Fill up all the fields");
                return;
            }
            else
            {
                double qty = Convert.ToDouble(qtyseventxbx.Text);
                double unit = Convert.ToDouble(unitseventxbx.Text);

                double totalQtyandUnit = qty * unit;
                String totalqtyandunitholder = System.Convert.ToString(totalQtyandUnit);

                if (taxrateseventxbx.Text == "VAT (12%)")
                {
                    double tax = totalQtyandUnit * .12;
                    String totalQtyandUnittax = System.Convert.ToString(tax);
                    taxholderseven.Text = totalQtyandUnittax;


                    double subtax = Convert.ToDouble(taxholderfinal.Text); //subtax
                    double totaltax = subtax + tax;
                    String subtaxholders = System.Convert.ToString(totaltax);
                    taxholderfinal.Text = subtaxholders;


                }

                holderseven.Text = totalqtyandunitholder;
                addeight.Visible = true;

                double subtotal = Convert.ToInt32(subtotalholder.Text); // subtotal
                double total = subtotal + totalQtyandUnit;
                String subtotalholders = System.Convert.ToString(total);
                subtotalholder.Text = subtotalholders;


                double subtotalx = Convert.ToDouble(subtotalholder.Text);
                double subtaxtotalx = Convert.ToDouble(taxholderfinal.Text);
                double totalall = subtotalx + subtaxtotalx;

                String totalltaxandsub = System.Convert.ToString(totalall);

                totalfinal.Text = totalltaxandsub;

                String holdermuna = System.Convert.ToString(taxholderfinal.Text);
                String holdertwod = System.Convert.ToString(subtotalholder.Text);

                subtotaltext.Text = holdertwod;

                taxtext.Text = holdermuna;
                finaltotal.Text = totalltaxandsub;

                computeseven.Enabled = false;

                amountseventxbx.Text = unitseventxbx.Text;
                addeight.Visible = true;

            }
        }


        public void checkeight()
        {

            if (itemeighttxbx.Text == "" || descriptioneighttxbx.Text == "" || qtyeighttxbx.Text == "" || uniteighttxbx.Text == "" || accounteighttxbx.Text == "" || taxrateeighttxbx.Text == "")
            {
                MessageBox.Show("Please Fill up all the fields");
                return;
            }
            else
            {
                double qty = Convert.ToDouble(qtyeighttxbx.Text);
                double unit = Convert.ToDouble(uniteighttxbx.Text);

                double totalQtyandUnit = qty * unit;
                String totalqtyandunitholder = System.Convert.ToString(totalQtyandUnit);

                if (taxrateeighttxbx.Text == "VAT (12%)")
                {
                    double tax = totalQtyandUnit * .12;
                    String totalQtyandUnittax = System.Convert.ToString(tax);
                    taxholdereight.Text = totalQtyandUnittax;


                    double subtax = Convert.ToDouble(taxholderfinal.Text); //subtax
                    double totaltax = subtax + tax;
                    String subtaxholders = System.Convert.ToString(totaltax);
                    taxholderfinal.Text = subtaxholders;


                }

                holdereight.Text = totalqtyandunitholder;

                double subtotal = Convert.ToInt32(subtotalholder.Text); // subtotal
                double total = subtotal + totalQtyandUnit;
                String subtotalholders = System.Convert.ToString(total);
                subtotalholder.Text = subtotalholders;


                double subtotalx = Convert.ToDouble(subtotalholder.Text);
                double subtaxtotalx = Convert.ToDouble(taxholderfinal.Text);
                double totalall = subtotalx + subtaxtotalx;

                String totalltaxandsub = System.Convert.ToString(totalall);

                totalfinal.Text = totalltaxandsub;

                String holdermuna = System.Convert.ToString(taxholderfinal.Text);
                String holdertwod = System.Convert.ToString(subtotalholder.Text);

                subtotaltext.Text = holdertwod;

                taxtext.Text = holdermuna;
                finaltotal.Text = totalltaxandsub;
                computeeight.Enabled = false;
                amounteighttxbx.Text = uniteighttxbx.Text;

            }
        }



        public void insertone()
        {

            con.Open();
            com = new MySqlCommand("Insert into db_accountinginvoice.tbl_invoice(Item,Description,Qty,UnitPrice,Discount,Account,Taxrate,AmountPhp) values('" + itemonetxbx.Text + "','" + descriptiononetxbx.Text + "','" + qtyonetxbx.Text + "','" + unitonetxbx.Text + "','" + discountonetxbx.Text + "', '" + accountonetxbx.Text + "','" + taxrateonetxbx.Text + "','" + amountonetxbx.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
            
        }

        private void descriptiononetxbx_TextChanged(object sender, EventArgs e)
        {
        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            numbertwogroup.Visible = true;

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            numbertwogroup.Visible = true;
            addtwo.Visible = false;
            computetwo.Visible = true;
            canceltwo.Visible = true;
            cancelone.Visible = false;

        }

        private void canceltwo_Click(object sender, EventArgs e)
        {
            numbertwogroup.Visible = false;
            canceltwo.Visible = false;
            computetwo.Visible = false;
            addtwo.Visible = false;
            addthree.Visible = false;

            itemtwotxbx.Text = "";
            descriptiontwotxbx.Text = "";
            qtytwotxbx.Text = "";
            unittwotxbx.Text = "";
            discounttwotxbx.Text = "";
            accounttwotxbx.Text = "";
            taxratetwotxbx.Text = "";
            amounttwotxbx.Text = "";
            cancelone.Visible = true;
            computetwo.Enabled = true;
            

            if (holdertwo.Text != "")
            {

                double stingholder = Convert.ToDouble(holdertwo.Text);
                double taxholderx = Convert.ToDouble(taxholdertwo.Text);
                double totalstringholder = Convert.ToDouble(subtotalholder.Text);
                double totaltaxholder = Convert.ToDouble(taxholderfinal.Text);
     

                double stringcompute = totalstringholder - stingholder;
                double taxcompute = totaltaxholder - taxholderx;

                String newstringvalue = System.Convert.ToString(stringcompute);
                String newtaxvalue = System.Convert.ToString(taxcompute);


                double stingholderx = Convert.ToDouble(holdertwo.Text);
                double taxholderxx = Convert.ToDouble(taxholdertwo.Text);
                double totalx = stingholder + taxholderxx;
                double totalfinalholder = Convert.ToDouble(totalfinal.Text);
                double totalfinalcompute = totalfinalholder - totalx;

                if (totalfinalcompute <= 0)
                {
                    totalfinalcompute = 0;
                    String totalofall = System.Convert.ToString(totalfinalcompute);


                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    holdertwo.Text = "";
                }
                else
                {
                    String totalofall = System.Convert.ToString(totalfinalcompute);


                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    holdertwo.Text = "";
                    
                }
            }

        }

        private void addeight_Click(object sender, EventArgs e)
        {
            numbereightgroup.Visible = true;
            addeight.Visible = false;
            computeeight.Visible = true;
            canceleight.Visible = true;
        }

        private void addthree_Click(object sender, EventArgs e)
        {
            numberthreegroup.Visible = true;
            addthree.Visible = false;
            computethree.Visible = true;
            computethree.Enabled = true;
            cancelthree.Visible = true;
        }

        private void cancelthree_Click(object sender, EventArgs e)
        {
            numberthreegroup.Visible = false;
            cancelthree.Visible = false;
            computethree.Visible = false;
            addthree.Visible = false;
            addfour.Visible = false;

            itemthreetxbx.Text = "";
            descriptionthreetxbx.Text = "";
            qtythreetxbx.Text = "";
            unitthreetxbx.Text = "";
            discountthreetxbx.Text = "";
            accountthreetxbx.Text = "";
            taxratethreetxbx.Text = "";
            amountthreetxbx.Text = "";
           


            if (holderthree.Text != "")
            {

                double stingholder = Convert.ToDouble(holderthree.Text);
                double taxholderx = Convert.ToDouble(taxholderthree.Text);
                double totalstringholder = Convert.ToDouble(subtotalholder.Text);
                double totaltaxholder = Convert.ToDouble(taxholderfinal.Text);


                double stringcompute = totalstringholder - stingholder;
                double taxcompute = totaltaxholder - taxholderx;

                String newstringvalue = System.Convert.ToString(stringcompute);
                String newtaxvalue = System.Convert.ToString(taxcompute);


                double stingholderx = Convert.ToDouble(holderthree.Text);
                double taxholderxx = Convert.ToDouble(taxholderthree.Text);
                double totalx = stingholder + taxholderxx;
                double totalfinalholder = Convert.ToDouble(totalfinal.Text);
                double totalfinalcompute = totalfinalholder - totalx;

                if (totalfinalcompute <= 0)
                {
                    totalfinalcompute = 0;
                    String totalofall = System.Convert.ToString(totalfinalcompute);


                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    holderthree.Text = "";
                }
                else
                {
                    String totalofall = System.Convert.ToString(totalfinalcompute);


                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    holderthree.Text = "";
                }
            }


        }

        private void addfour_Click(object sender, EventArgs e)
        {
            numberfourgroup.Visible = true;
            addfour.Visible = false;
            computefour.Visible = true;
            cancelfour.Visible = true;
        }

        private void cancelfour_Click(object sender, EventArgs e)
        {
            numberfourgroup.Visible = false;
            cancelfour.Visible = false;
            computefour.Visible = false;
            addfour.Visible = false;
            addfive.Visible = false;

            itemfourtxbx.Text = "";
            descriptionfourtxbx.Text = "";
            qtyfourtxbx.Text = "";
            unitfourtxbx.Text = "";
            discountfourtxbx.Text = "";
            accountfourtxbx.Text = "";
            taxfourtxbx.Text = "";
            amountfourtxbx.Text = "";
          

            if (holderfour.Text != "")
            {

                double stingholder = Convert.ToDouble(holderfour.Text);
                double taxholderx = Convert.ToDouble(taxholderfour.Text);
                double totalstringholder = Convert.ToDouble(subtotalholder.Text);
                double totaltaxholder = Convert.ToDouble(taxholderfinal.Text);


                double stringcompute = totalstringholder - stingholder;
                double taxcompute = totaltaxholder - taxholderx;

                String newstringvalue = System.Convert.ToString(stringcompute);
                String newtaxvalue = System.Convert.ToString(taxcompute);


                double stingholderx = Convert.ToDouble(holderfour.Text);
                double taxholderxx = Convert.ToDouble(taxholderfour.Text);
                double totalx = stingholder + taxholderxx;
                double totalfinalholder = Convert.ToDouble(totalfinal.Text);
                double totalfinalcompute = totalfinalholder - totalx;

                if (totalfinalcompute <= 0)
                {
                    totalfinalcompute = 0;
                    String totalofall = System.Convert.ToString(totalfinalcompute);


                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    holderfour.Text = "";
                }
                else
                {
                    String totalofall = System.Convert.ToString(totalfinalcompute);


                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    holderfour.Text = "";
                }
            }

        }

        private void computetwo_Click(object sender, EventArgs e)
        {
           
                checktwo();
              

            
        }

        private void computethree_Click(object sender, EventArgs e)
        {
           
            checkthree();
        }

        private void cancelfive_Click(object sender, EventArgs e)
        {
            numberfivegroup.Visible = false;
            cancelfive.Visible = false;
            computefive.Visible = false;
            addfive.Visible = false;
            addsix.Visible = false;

            itemfivetxbx.Text = "";
            descriptionfivetxbx.Text = "";
            qtyfivetxbx.Text = "";
            unitfivetxbx.Text = "";
            discountfivetxbx.Text = "";
            accountfivetxbx.Text = "";
            taxratefivetxbx.Text = "";
            refreshbtn.Text = "";


            if (holderfive.Text != "")
            {

                double stingholder = Convert.ToDouble(holderfive.Text);
                double taxholderx = Convert.ToDouble(taxholderfive.Text);
                double totalstringholder = Convert.ToDouble(subtotalholder.Text);
                double totaltaxholder = Convert.ToDouble(taxholderfinal.Text);


                double stringcompute = totalstringholder - stingholder;
                double taxcompute = totaltaxholder - taxholderx;

                String newstringvalue = System.Convert.ToString(stringcompute);
                String newtaxvalue = System.Convert.ToString(taxcompute);


                double stingholderx = Convert.ToDouble(holderfive.Text);
                double taxholderxx = Convert.ToDouble(taxholderfive.Text);
                double totalx = stingholder + taxholderxx;
                double totalfinalholder = Convert.ToDouble(totalfinal.Text);
                double totalfinalcompute = totalfinalholder - totalx;

                if (totalfinalcompute <= 0)
                {
                    totalfinalcompute = 0;
                    String totalofall = System.Convert.ToString(totalfinalcompute);


                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    holderfive.Text = "";
                }
                else
                {
                    String totalofall = System.Convert.ToString(totalfinalcompute);


                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    holderfive.Text = "";
                }
            }

        }

        private void cancelsix_Click(object sender, EventArgs e)
        {
            numbersixgroup.Visible = false;
            cancelsix.Visible = false;
            computesix.Visible = false;
            addsix.Visible = false;
            addseven.Visible = false;

            itemsixtxbx.Text = "";
            descriptionsixtxbx.Text = "";
            qtysixtxbx.Text = "";
            unitysixtxbx.Text = "";
            discountsixtxbx.Text = "";
            accountsixtxbx.Text = "";
            taxratesixtxbx.Text = "";
            amountsixtxbx.Text = "";


            if (holdersix.Text != "")
            {

                double stingholder = Convert.ToDouble(holdersix.Text);
                double taxholderx = Convert.ToDouble(taxholdersix.Text);
                double totalstringholder = Convert.ToDouble(subtotalholder.Text);
                double totaltaxholder = Convert.ToDouble(taxholderfinal.Text);


                double stringcompute = totalstringholder - stingholder;
                double taxcompute = totaltaxholder - taxholderx;

                String newstringvalue = System.Convert.ToString(stringcompute);
                String newtaxvalue = System.Convert.ToString(taxcompute);


                double stingholderx = Convert.ToDouble(holdersix.Text);
                double taxholderxx = Convert.ToDouble(taxholdersix.Text);
                double totalx = stingholder + taxholderxx;
                double totalfinalholder = Convert.ToDouble(totalfinal.Text);
                double totalfinalcompute = totalfinalholder - totalx;

                if (totalfinalcompute <= 0)
                {
                    totalfinalcompute = 0;
                    String totalofall = System.Convert.ToString(totalfinalcompute);


                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    holdersix.Text = "";
                }
                else
                {
                    String totalofall = System.Convert.ToString(totalfinalcompute);

                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    holdersix.Text = "";
                }
            }

        }

        private void cancelseven_Click(object sender, EventArgs e)
        {
            numbersevengroup.Visible = false;
            cancelseven.Visible = false;
            computeseven.Visible = false;
            addseven.Visible = false;
            addeight.Visible = false;

            itemseventxbx.Text = "";
            descriptionseventxbx.Text = "";
            qtyseventxbx.Text = "";
            unitseventxbx.Text = "";
            discountseventxbx.Text = "";
            accountseventxbx.Text = "";
            taxrateseventxbx.Text = "";
            amountseventxbx.Text = "";


            if (holderseven.Text != "")
            {

                double stingholder = Convert.ToDouble(holderseven.Text);
                double taxholderx = Convert.ToDouble(taxholderseven.Text);
                double totalstringholder = Convert.ToDouble(subtotalholder.Text);
                double totaltaxholder = Convert.ToDouble(taxholderfinal.Text);


                double stringcompute = totalstringholder - stingholder;
                double taxcompute = totaltaxholder - taxholderx;

                String newstringvalue = System.Convert.ToString(stringcompute);
                String newtaxvalue = System.Convert.ToString(taxcompute);


                double stingholderx = Convert.ToDouble(holderseven.Text);
                double taxholderxx = Convert.ToDouble(taxholderseven.Text);
                double totalx = stingholder + taxholderxx;
                double totalfinalholder = Convert.ToDouble(totalfinal.Text);
                double totalfinalcompute = totalfinalholder - totalx;

                if (totalfinalcompute <= 0)
                {
                    totalfinalcompute = 0;
                    String totalofall = System.Convert.ToString(totalfinalcompute);


                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    holderseven.Text = "";
                }
                else
                {
                    String totalofall = System.Convert.ToString(totalfinalcompute);

                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    holderseven.Text = "";
                }
            }

        }

        private void addfive_Click(object sender, EventArgs e)
        {
            numberfivegroup.Visible = true;
            addfive.Visible = false;
            computefive.Visible = true;
            cancelfive.Visible = true;
        }

        private void addsix_Click(object sender, EventArgs e)
        {
            numbersixgroup.Visible = true;
            addsix.Visible = false;
            computesix.Visible = true;
            cancelsix.Visible = true;
        }

        private void computefour_Click(object sender, EventArgs e)
        {
            
            checkfour();
        }

        private void computefive_Click(object sender, EventArgs e)
        {
           
            checkfive();
        }

        private void computesix_Click(object sender, EventArgs e)
        {
            
            checksix();
        }

        private void computeseven_Click(object sender, EventArgs e)
        {
           
            checkseven();
        }

        private void computeeight_Click(object sender, EventArgs e)
        {
            checkeight();
        }

        private void addseven_Click(object sender, EventArgs e)
        {
            numbersevengroup.Visible = true;
            addseven.Visible = false;
            computeseven.Visible = true;
            cancelseven.Visible = true;
        }

        private void canceleight_Click(object sender, EventArgs e)
        {
            numbereightgroup.Visible = false;
            canceleight.Visible = false;
            computeeight.Visible = false;
            addeight.Visible = false;

            itemeighttxbx.Text = "";
            descriptioneighttxbx.Text = "";
            qtyeighttxbx.Text = "";
            uniteighttxbx.Text = "";
            discounteighttxbx.Text = "";
            accounteighttxbx.Text = "";
            taxrateeighttxbx.Text = "";
            amounteighttxbx.Text = "";


            if (holdereight.Text != "")
            {

                double stingholder = Convert.ToDouble(holdereight.Text);
                double taxholderx = Convert.ToDouble(taxholdereight.Text);
                double totalstringholder = Convert.ToDouble(subtotalholder.Text);
                double totaltaxholder = Convert.ToDouble(taxholderfinal.Text);


                double stringcompute = totalstringholder - stingholder;
                double taxcompute = totaltaxholder - taxholderx;

                String newstringvalue = System.Convert.ToString(stringcompute);
                String newtaxvalue = System.Convert.ToString(taxcompute);


                double stingholderx = Convert.ToDouble(holdereight.Text);
                double taxholderxx = Convert.ToDouble(taxholdereight.Text);
                double totalx = stingholder + taxholderxx;
                double totalfinalholder = Convert.ToDouble(totalfinal.Text);
                double totalfinalcompute = totalfinalholder - totalx;

                if (totalfinalcompute <= 0)
                {
                    totalfinalcompute = 0;
                    String totalofall = System.Convert.ToString(totalfinalcompute);


                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    holdereight.Text = "";
                }
                else
                {
                    String totalofall = System.Convert.ToString(totalfinalcompute);

                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    holdereight.Text = "";
                }
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            itemonetxbx.Text = "";
            descriptiononetxbx.Text = "";
            qtyonetxbx.Text = "";
            unitonetxbx.Text = "";
            discountonetxbx.Text = "";
            accountonetxbx.Text = "";
            taxrateonetxbx.Text = "";
            amountonetxbx.Text = "";
            addtwo.Visible = false;

            if (holderone.Text != "")
            {

                double stingholder = Convert.ToDouble(holderone.Text);
                double taxholderx = Convert.ToDouble(taxholder.Text);
                double totalstringholder = Convert.ToDouble(subtotalholder.Text);
                double totaltaxholder = Convert.ToDouble(taxholderfinal.Text);


                double stringcompute = totalstringholder - stingholder;
                double taxcompute = totaltaxholder - taxholderx;

                String newstringvalue = System.Convert.ToString(stringcompute);
                String newtaxvalue = System.Convert.ToString(taxcompute);


                double stingholderx = Convert.ToDouble(holderone.Text);
                double taxholderxx = Convert.ToDouble(taxholder.Text);
                double totalx = stingholder + taxholderxx;
                double totalfinalholder = Convert.ToDouble(totalfinal.Text);
                double totalfinalcompute = totalfinalholder - totalx;

                if (totalfinalcompute <= 0)
                {
                    totalfinalcompute = 0;
                    String totalofall = System.Convert.ToString(totalfinalcompute);


                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    computefirsttxbx.Enabled = true;
                    cancelone.Visible = false;
                    
             
                }
                else
                {
                    String totalofall = System.Convert.ToString(totalfinalcompute);


                    subtotalholder.Text = "";
                    taxholderfinal.Text = "";
                    totalfinal.Text = "";

                    subtotalholder.Text = newstringvalue;
                    taxholderfinal.Text = newtaxvalue;
                    totalfinal.Text = totalofall;

                    subtotaltext.Text = newstringvalue;
                    taxtext.Text = newtaxvalue;
                    finaltotal.Text = totalofall;
                    computefirsttxbx.Enabled = true;
                    cancelone.Visible = false;
                
                   
                }
            }

 


        }

        private void metroButton1_Click_2(object sender, EventArgs e)
        {
            if (totxbx.Text == "" || datetxbx.Text == "" || duedatetxbx.Text == "" || invoicetxbx.Text == "" || referencetxbx.Text == "" || ClientIDtxbx.Text == "")
            {
                MessageBox.Show("Please fill up all the requirements");

                
            }

            else
            {
                MessageBox.Show("Done!");
                groupBox3.Visible = true;
                computefirsttxbx.Visible = true;
                totxbx.Enabled = false;
                datetxbx.Enabled = false;
                invoicetxbx.Enabled = false;
                referencetxbx.Enabled = false;
                ClientIDtxbx.Enabled = false;
                duedatetxbx.Enabled = false;
                cancelbtn.Visible = true;
                groupBox2.Visible = true;
                printbtn.Visible = true;
               
                

            }
        }

        private void printbtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Double check your work", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                autoincrement();
                autoincrementref();

                loadx();

                insert();

                Printing_Form pf = new Printing_Form();
                pf.Show();
                this.Hide();
                
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
          
         
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void lastotaltext_Enter(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            donebtn.Visible = true;
            cancelbtn.Visible = false;
            groupBox2.Visible = false ;
            totxbx.Enabled = true;
            datetxbx.Enabled = true;
            invoicetxbx.Enabled = true;
            duedatetxbx.Enabled = true;
            referencetxbx.Enabled = true;
            ClientIDtxbx.Enabled = true;
            printbtn.Visible = false;

        }

        private void metroButton1_Click_3(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            
        }

    }
}

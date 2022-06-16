/*
 * ManageProduct form code
 * class with the code of the form of products management options for the admin
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadot
{
    public partial class ManageProduct : Form
    {
        private DBSQL db = new DBSQL();
        private Product[] productArray;
        private Product newProduct;
        private Product productToUpdate;

        /// <summary>
        /// form constractor
        /// </summary>
        public ManageProduct()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method wich works when manage product form load
        /// </summary>
        private void AdminManageProduct_Load(object sender, EventArgs e)
        {
            btnUpdateProduct.Enabled = false;
            productArray = db.GetProductsData();
            cboParameterToSearch.Text = "שם המוצר";
        }

        /// <summary>
        /// method wich works when the user press on "show all products" button
        /// the method will fill the products list with the products details from data base
        /// </summary>
        private void btnShowAllProduct_Click(object sender, EventArgs e)
        {
            FillProductList();
        }

        /// <summary>
        /// method wich get all the products details from the data base and fill
        /// the products list with those details
        /// </summary>
        private void FillProductList()
        {
            lstProductList.Items.Clear();
            productArray = db.GetProductsData();
            //loop to pass on the products array
            for (int i = 0; i < productArray.Length; i++)
            {
                if(productArray[i].Type != "Dish" && productArray[i].Type != "Wine" && productArray[i].Type != "none")
                    lstProductList.Items.Add(productArray[i].ToString());
            }
        }

        /// <summary>
        /// method wich works when the user press on "add product" button
        /// the method will check the inputs and insert the new product to data base
        /// </summary>
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (Checks.IsEmptyString(txtProductName.Text) || Checks.IsNumberPositive(int.Parse(nudProductPrice.Value.ToString())))
            {
                MessageBox.Show("אחד מהשדות לא מלא !! ", "הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (db.IsProductNameAlreadyExists(txtProductName.Text))
                {
                    MessageBox.Show("המוצר כבר קיים במלאי  !! ", "הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InsertNewProduct();
                    MessageBox.Show(txtProductName.Text + " נוסף בהצלחה לתפריט ! ", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanFields();
                }
            }
        }

        /// <summary>
        /// method wich fill the new product object with the details from fields
        /// and insert the new product to data base
        /// </summary>
        private void InsertNewProduct()
        {
            newProduct = new Product();
            newProduct.Name = txtProductName.Text;
            newProduct.Price = int.Parse(nudProductPrice.Value.ToString());
            newProduct.Type = SetNewProductType(cboType.Text);
            newProduct.Department = cboDepartment.Text;
            newProduct.Status = cbProductStatus.Checked;
            db.InsertNewProduct(newProduct);
            newProduct.ProductID = db.GetProductIdByName(newProduct.Name);
            db.InsertNewProductToStockByDate(newProduct.ProductID, 0);
            db.InsertNewProductToStockByYear(newProduct.ProductID, 0, DateTime.Now.Month, DateTime.Now.Year);
        }

        /// <summary>
        /// method to get the new product type from the combo box
        /// </summary>
        /// <param name="type">the type the user choose</param>
        /// <returns>
        /// string res - the type of the new product
        /// </returns>
        private string SetNewProductType(string type)
        {
            string res = string.Empty;
            if (type == "שתיה קלה / אלכוהול")
                res = "SoftDrink";
            if (type == "שתיה חמה / קפה")
                res = "HotDrink";
            if (type == "קינוחים")
                res = "Dessert";
            if (type == "מוצר כללי")
                res = "General";
            return res;
        }

        /// <summary>
        /// method to get the correct string from the product type to put in combo box
        /// </summary>
        /// <param name="type">the type of the product</param>
        /// <returns>
        /// string res - the correct string to put in the combo box
        /// </returns>
        private string TypeToString(string type)
        {
            string res = string.Empty;
            if (type == "SoftDrink")
                res = "שתיה קלה / אלכוהול";
            if (type == "HotDrink")
                res = "שתיה חמה / קפה";
            if (type == "Dessert")
                res = "קינוחים";
            if (type == "General")
                res = "מוצר כללי";
            return res;
        }

        /// <summary>
        /// method wich works when the user press on "update product" button
        /// the method will check the inputs and update the spcific product details
        /// </summary>
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (Checks.IsEmptyString(txtProductName.Text))
            {
                MessageBox.Show("הכנס את השם של המוצר בבקשה ", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (productToUpdate.Name != txtProductName.Text)
                {
                    if (db.IsProductNameAlreadyExists(txtProductName.Text)) 
                    {
                        MessageBox.Show("המוצר כבר קיים במערכת !! בדוק בבקשה את הפרטים שוב  ", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FillDataToUpdateProduct();
                        db.UpdateProduct(productToUpdate);
                        MessageBox.Show(txtProductName.Text + " עודכן בהצלחה ! ", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleanFields();
                    }
                }
                else
                {
                    FillDataToUpdateProduct();
                    db.UpdateProduct(productToUpdate);
                    MessageBox.Show(txtProductName.Text + " עודכן בהצלחה ! ", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanFields();
                }
            }
        }

        /// <summary>
        /// method wich fill the product object with the details from the fields
        /// </summary>
        private void FillDataToUpdateProduct()
        { 
            productToUpdate.Name = txtProductName.Text;
            productToUpdate.Price = int.Parse(nudProductPrice.Value.ToString());
            productToUpdate.Department = cboDepartment.Text;
            productToUpdate.Status = cbProductStatus.Checked;
        }

        /// <summary>
        /// method wich works when the user select product from the products list
        /// the method will fill all the fields with the selected product details
        /// </summary>
        private void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Checks.IsItemSelected(lstProductList))
            {
                btnAddProduct.Enabled = false;
                btnUpdateProduct.Enabled = true;
                FillSelectedProductData();
            }
        }

        /// <summary>
        /// method wich fill all the fields in the form with the
        /// details of the chosen product 
        /// </summary>
        private void FillSelectedProductData()
        {
            bool flag = true;
            string[] words = lstProductList.SelectedItem.ToString().Split();
            int productId = int.Parse(words[0]);
            //loop to pass on products array
            for (int i = 0; i < productArray.Length && flag; i++)
            {
                if (productArray[i].ProductID == productId)
                {
                    productToUpdate = productArray[i];
                    flag = false;
                }
            }

            txtProductName.Text = productToUpdate.Name.ToString();
            nudProductPrice.Text = productToUpdate.Price.ToString(); 
            cboDepartment.Text = productToUpdate.Department;
            cboType.Text = TypeToString(productToUpdate.Type);
            cbProductStatus.Checked = productToUpdate.Status;
        }

        /// <summary>
        /// method wich works when the user press on "clean fields" button
        /// the method clean all the fields in the form
        /// </summary>
        private void btnCleanFields_Click(object sender, EventArgs e)
        {
            CleanFields();
        }

        /// <summary>
        /// mehtod wich clean all the fields in the form
        /// </summary>
        private void CleanFields()
        {
            FillProductList();
            txtProductName.Text = string.Empty;
            txtSearchProduct.Text = string.Empty;
            nudProductPrice.Value = 0;
            btnAddProduct.Enabled = true;
        }

        /// <summary>
        /// method of the search option
        /// the method will check by which parameter the user want to srearch
        /// </summary>
        /// <param name="parameterToSearch">the chosen paramter from the combo box</param>
        /// <returns>
        /// string - the parameter to search by
        /// </returns>
        public string ParameterToColumnName(string parameterToSearch)
        {
            if (parameterToSearch == "שם המוצר")
                return "name";
            else if (parameterToSearch == "מחיר")
                return "price";
            return "department";
        }

        /// <summary>
        /// method wich works when the user write on search txt
        /// the method will get the text and search the products by the right parameter
        /// </summary>
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string querry = string.Empty;
            querry = "SELECT * FROM `product` WHERE " + "`" + ParameterToColumnName(cboParameterToSearch.Text) + "`" + " LIKE '" + txtSearchProduct.Text + "%' AND type IN ('General', 'Dessert', 'HotDrink', 'SoftDrink')";
            Product[] searcProducts = db.GetProductDataSearch(querry);

            lstProductList.Items.Clear();
            for (int i = 0; i < searcProducts.Length; i++)
            {
                lstProductList.Items.Add(searcProducts[i].ToString());
            }
        }

        /// <summary>
        /// method wich works when the user press on "back to main page" button
        /// the method will close the current form and back to the admin home page
        /// </summary>
        private void btnReturnToHomePage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

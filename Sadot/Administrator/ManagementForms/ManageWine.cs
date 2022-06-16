/*
 * ManageWine form code
 * class with the code of the form of wines management options for the admin
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadot
{
    public partial class ManageWine : Form
    {
        private DBSQL db = new DBSQL();
        private Wine[] wineArray;
        Product newProduct;
        Wine newWine;
        Wine wineToUpdate;

        /// <summary>
        /// form constractor
        /// </summary>
        public ManageWine()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method wich works when manage wines form load
        /// </summary>
        private void AdminManageWine_Load(object sender, EventArgs e)
        {
            btnUpdateWine.Enabled = false;
            wineArray = db.GetWinesData();
            cboParameterToSearch.Text = "שם היין";
        }

        /// <summary>
        /// method wich works when the user press on "show all wines" button
        /// the method will fill the wines list with the wines details from data base
        /// </summary>
        private void btnShowAllWine_Click(object sender, EventArgs e)
        {
            FillWineList();
        }

        /// <summary>
        /// method wich get all the wines details from the data base and fill
        /// the wines list with the details
        /// </summary>
        private void FillWineList()
        {
            lstWineList.Items.Clear();
            wineArray = db.GetWinesData();
            //loop to pass on all the wines in the array
            for (int i = 0; i < wineArray.Length; i++)
            {
                 lstWineList.Items.Add(wineArray[i].ToString());
            }
        }

        /// <summary>
        /// method wich works when the user press on "add wine" button
        /// the method will check the inputs and insert the new wine to data base
        /// </summary>
        private void btnAddWine_Click(object sender, EventArgs e)
        {
            if (Checks.IsEmptyString(txtWineName.Text))
            {
                MessageBox.Show("הכנס את השם של היין בבקשה ", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (db.IsWineNameAndYearAlreadyExists(txtWineName.Text, dtpWineYear.Text))
                {
                    MessageBox.Show("היין כבר קיים במערכת !! בדוק בבקשה את הפרטים שוב  ", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InsertNewWine();
                    MessageBox.Show( txtWineName.Text + " נוסף בהצלחה לתפריט ! ", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanFields();
                }
            }
        }

        /// <summary>
        /// method wich fill the product and wine objects with the new wine details
        /// and insert the new wine to data base
        /// </summary>
        private void InsertNewWine()
        {
            newProduct = new Product();
            newProduct.Name = txtWineName.Text + " " + dtpWineYear.Text;
            newProduct.Price = int.Parse(nudWinePriceBottle.Value.ToString());
            newProduct.Type = "Wine";
            newProduct.Department = "Bar";
            newProduct.Status = true;
            db.InsertNewProduct(newProduct);

            newWine = new Wine();
            newWine.WineID = db.GetProductIdByName(newProduct.Name);
            newWine.Name = txtWineName.Text;
            newWine.Year = dtpWineYear.Text;
            newWine.PriceBottle = int.Parse(nudWinePriceBottle.Value.ToString());
            newWine.PriceGlass = int.Parse(nudWinePriceGlass.Value.ToString());
            newWine.Status = cbWineStatus.Checked;
            db.InsertNewWine(newWine);
            db.InsertNewProductToStockByDate(newWine.WineID, 0);
            db.InsertNewProductToStockByYear(newWine.WineID, 0, DateTime.Now.Month, DateTime.Now.Year);
        }

        /// <summary>
        /// method wich works when the user select wine from the wines list
        /// the method will fill all the fields with the selected wine details
        /// </summary>
        private void lstWineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Checks.IsItemSelected(lstWineList))
            {
                btnAddWine.Enabled = false;
                btnUpdateWine.Enabled = true;
                FillSelectedWineData();
            }
        }

        /// <summary>
        /// method wich fill all the fields in the form with the
        /// details of the chosen wine 
        /// </summary>
        private void FillSelectedWineData()
        {
            bool flag = true;
            string[] words = lstWineList.SelectedItem.ToString().Split();
            int wineId = int.Parse(words[0]);
            //loop to pass on all the wine array
            for (int i = 0; i < wineArray.Length && flag; i++)
            {
                if (wineArray[i].WineID == wineId)
                {
                    wineToUpdate = wineArray[i];
                    flag = false;
                }
            }
            txtWineName.Text = wineToUpdate.Name.ToString();
            dtpWineYear.Text = "01-01-"+wineToUpdate.Year;
            nudWinePriceBottle.Value = wineToUpdate.PriceBottle;
            nudWinePriceGlass.Value = wineToUpdate.PriceGlass;
            cbWineStatus.Checked = wineToUpdate.Status;
        }

        /// <summary>
        /// method wich works when the user press on "update wine" button
        /// the method will check the inputs and update the spcific wine details
        /// </summary>
        private void btnUpdateWine_Click(object sender, EventArgs e)
        {
            if (Checks.IsEmptyString(txtWineName.Text))
            {
                MessageBox.Show("הכנס את השם של היין בבקשה ", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (wineToUpdate.Name != txtWineName.Text || wineToUpdate.Year != dtpWineYear.Text)
                {
                    if (db.IsWineNameAndYearAlreadyExists(txtWineName.Text , dtpWineYear.Text))
                    {
                        MessageBox.Show("היין כבר קיים במערכת !! בדוק בבקשה את הפרטים שוב  ", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        db.UpdateWine(FiilDataToUpdateWine());
                        db.UpdateProduct(FillDateToUpdateProduct());
                        MessageBox.Show( txtWineName.Text + " עודכן בהצלחה ! ", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    db.UpdateWine(FiilDataToUpdateWine());
                    db.UpdateProduct(FillDateToUpdateProduct());
                    MessageBox.Show( txtWineName.Text + " עודען בהצלחה ! ", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            CleanFields();
        }

        /// <summary>
        /// method wich fill the wine object with the details from the fields
        /// </summary>
        private Wine FiilDataToUpdateWine()
        {
            wineToUpdate.Name = txtWineName.Text;
            wineToUpdate.Year = dtpWineYear.Text;
            wineToUpdate.PriceBottle = int.Parse(nudWinePriceBottle.Value.ToString());
            wineToUpdate.PriceGlass = int.Parse(nudWinePriceGlass.Value.ToString());
            wineToUpdate.Status = cbWineStatus.Checked;
            return wineToUpdate;
        }

        /// <summary>
        /// method wich fill the product object with the details of the wine
        /// </summary>
        private Product FillDateToUpdateProduct()
        {
            Product productToUpdate = new Product();
            productToUpdate.ProductID = wineToUpdate.WineID;
            productToUpdate.Name = wineToUpdate.Name;
            productToUpdate.Price = wineToUpdate.PriceBottle;
            productToUpdate.Type = "Wine";
            productToUpdate.Department = "Bar";
            productToUpdate.Status = wineToUpdate.Status;
            return productToUpdate;
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
        public void CleanFields()
        {
            FillWineList();
            txtWineName.Text = string.Empty;
            dtpWineYear.Text = string.Empty;
            nudWinePriceBottle.Value = 0;
            nudWinePriceGlass.Value = 0;
            cbWineStatus.Checked = true;
            btnAddWine.Enabled = true;
            btnUpdateWine.Enabled = false;
            txtSearchWine.Text = string.Empty;
            //lstWineList.Items.Clear();
            cboParameterToSearch.Text = "שם היין";
        }

        /// <summary>
        /// method wich works when the user press on "back to main page" button
        /// the method will close the current form and back to the admin home page
        /// </summary>
        private void btnReturnToHomePage_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (parameterToSearch == "שם היין")
                return "wineName";
            else
                return "wineYear";
        }

        /// <summary>
        /// method wich works when the user write on search txt
        /// the method will get the text and search the wines by the right parameter
        /// </summary>
        private void txtSearchWine_TextChanged(object sender, EventArgs e)
        {
            string querry = string.Empty;
            querry = "SELECT * FROM `wine` WHERE " + "`" + ParameterToColumnName(cboParameterToSearch.Text) + "`" + " LIKE '" + txtSearchWine.Text + "%'";
            Wine[] searchWines = db.GetWineDataSearch(querry);

            lstWineList.Items.Clear();
            for (int i = 0; i < searchWines.Length; i++)
            {
                lstWineList.Items.Add(searchWines[i].ToString());
            }
        }
    }
}

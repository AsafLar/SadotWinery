/*
 * ManageDishPage form code
 * class with the code of the form of dishs and ingredients management options for the admin
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
    public partial class ManageDishPage : Form
    {
        private DBSQL db = new DBSQL();

        private Ingredients[] ingredients;//All Ingredients
        private IngredientsInDish[] dishIngredients;//Array with all  Ingredients In Dish
        private Dish[] dishes;//All dishes

        private Dish newDish;
        private Product newProduct;

        private List<IngredientsInDish> IngredientsToRemoveFromDish;
        private List<IngredientsInDish> IngredientsToAddToDish;

        private bool updateFlag;
        private string chosenIngredientName;

        /// <summary>
        /// ManageDishPage constractor
        /// </summary>
        public ManageDishPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method wich works when the AdminManageDishPageTest loads
        /// </summary>
        private void AdminManageDishPageTest_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            PassToAddDish();
            RefreshDishesList(); //Fill the dishes list
            FillIngredientsComboBox(); //Fill ingredients combo box
            this.Size = new Size(1020, 650);
            this.CenterToScreen();
        }

        /// <summary>
        /// Method wich works when the user press on add ingredient button
        /// </summary>
        private void btnAddIngredientsToDish_Click(object sender, EventArgs e)
        {
            if (cbIngredientName.SelectedItem == null)//check if user choose ingredint
                MessageBox.Show("לא נבחר מרכיב להוספה !!");
            else
            {
                if (IsIngredientAllreadyInList(ingredients[cbIngredientName.SelectedIndex].ID))
                    MessageBox.Show("מרכיב זה כבר נמצא במנה !");
                else
                {  //the user choose ingredient and the ingredient not shows then add the ingredient
                    dgvIngredientsList.Rows.Add(ingredients[cbIngredientName.SelectedIndex].ID, ingredients[cbIngredientName.SelectedIndex].Name, cbAmount.Text);
                    dgvIngredientsList.CurrentCell.Selected = false;

                    if (updateFlag)
                    {
                        IngredientsInDish ingredientInDish = new IngredientsInDish();
                        ingredientInDish.DishID = newDish.ID;
                        ingredientInDish.IngredientID = ingredients[cbIngredientName.SelectedIndex].ID;
                        ingredientInDish.Quantity = double.Parse(cbAmount.Text);
                        IngredientsToAddToDish.Add(ingredientInDish);
                    }

                    cbIngredientName.Text = string.Empty;
                    cbAmount.Text = "1";
                }
            }
        }

        /// <summary>
        /// Method wich works when the user press on remove ingredient button
        /// the method will remove ingredeint from the list
        /// </summary>
        private void btnRemoveIngredientFromDish_Click(object sender, EventArgs e)
        {
            if (dgvIngredientsList.SelectedCells.Count > 0)
            {
                int index = dgvIngredientsList.CurrentCell.RowIndex;
                if (updateFlag)
                    IngredientsToRemoveFromDish.Add(dishIngredients[index]);

                dgvIngredientsList.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("בחר מרכיב להסרה מרשימת המרכיבים!");
            }
        }

        /// <summary>
        /// Function to check if the ingredient to add allready in list of ingredients of the new dish
        /// </summary>
        /// <param name="idToSearch">the id of the ingredient to check if show</param>
        /// <returns>
        /// bool res = true - if show
        /// bool res = false - if not show
        /// </returns>
        public bool IsIngredientAllreadyInList(int idToSearch)
        {
            bool res = false;
            for (int i = 0; i < dgvIngredientsList.RowCount; i++)//loop to search in the new dish ingredients list
            {
                if (dgvIngredientsList.Rows[i].Cells[0].Value.ToString() == idToSearch.ToString())
                    res = true;
            }
            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        private void btnAddDish_Click(object sender, EventArgs e)
        {
            if (InputCheckDishNameAndPrice())
            {
                if (db.IsDishNameAlreadyExists(txtDishName.Text))
                    MessageBox.Show(" שם המנה כבר קיים !! בבקשה תבחר שם חדש או שתבצע עדכון למנה  ", "Messgae", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (CheckIngredientsList())
                    {
                        NewProduct();
                        NewDish();
                        FillIngredientArrayList();
                        InserIngredientsOfDish();
                        MessageBox.Show(newDish.Name + " נוספה בהצלחה לתפריט !! ");
                        ClearingFields();
                        RefreshDishesList();
                    }
                }
            }


        }

        /// <summary>
        /// Method wich checks if the ingredients list of the new dish is not empty
        /// </summary>
        /// <returns>
        /// bool res = true - the list of ingredients not empty
        /// bool res = false - the list of ingredients empty
        /// </returns>
        public bool CheckIngredientsList()
        {
            bool res = true;
            if (dgvIngredientsList.RowCount == 0)
            {
                MessageBox.Show("המנה חייבת להכיל לפחות מרכיב אחד");
                res = false;
            }
            return res;
        }
        /// <summary>
        /// Method wich checks if user didnet fill the price or name inputs
        /// </summary>
        /// <returns>
        /// bool res = true - if the inputs is ok
        /// bool res = false - if ont of the inputs is not ok
        /// </returns>
        public bool InputCheckDishNameAndPrice()
        {
            bool res = true;
            if (txtDishName.Text == string.Empty)
            {
                MessageBox.Show("הכנס שם למנה");
                res = false;
            }
            else if (nudDishPrice.Value == 0)
            {
                MessageBox.Show("הכנס מחיר למנה");
                res = false;
            }

            return res;
        }

        /// <summary>
        /// Method to create new product object
        /// </summary>
        private void NewProduct()
        {
            newProduct = new Product();
            newProduct.Name = txtDishName.Text;
            newProduct.Price = int.Parse(nudDishPrice.Value.ToString());
            newProduct.Type = "Dish";
            newProduct.Department = "kitchen";
            newProduct.Status = true;
            db.InsertNewProduct(newProduct);
        }

        /// <summary>
        /// Method to create new dish object
        /// </summary>
        private void NewDish()
        {
            newDish = new Dish();
            newDish.ID = db.GetProductIdByName(newProduct.Name); //get the new product id from data base
            newDish.Name = newProduct.Name;
            newDish.Price = newProduct.Price;
            newDish.Status = 1;
            db.InsertNewDish(newDish);
            db.InsertNewProductToStockByDate(newDish.ID, 0);
            db.InsertNewProductToStockByYear(newDish.ID, 0, DateTime.Now.Month, DateTime.Now.Year);
        }

        /// <summary>
        /// Method to fill the IngredientsToAddToDish array list with all the new dish ingredients 
        /// </summary>
        private void FillIngredientArrayList()
        {
            if(IngredientsToAddToDish == null)
                IngredientsToAddToDish = new List<IngredientsInDish>();

            for (int i = 0; i < dgvIngredientsList.Rows.Count; i++)
            {
                IngredientsInDish tmpIngredientToAdd = new IngredientsInDish();
                tmpIngredientToAdd.DishID = newDish.ID;
                tmpIngredientToAdd.IngredientID = int.Parse(dgvIngredientsList.Rows[i].Cells[0].Value.ToString());
                tmpIngredientToAdd.Quantity = double.Parse(dgvIngredientsList.Rows[i].Cells[2].Value.ToString());
                IngredientsToAddToDish.Add(tmpIngredientToAdd);
            }
        }

        /// <summary>
        /// Method to insert all ingredients of the new dish to the database
        /// </summary>
        private void InserIngredientsOfDish()
        {
            for (int i = 0; i < IngredientsToAddToDish.Count; i++)
                db.InsertIngredientsOfDish(IngredientsToAddToDish[i]);
        }

        /// <summary>
        /// Method to clear all the form fields
        /// </summary>
        public void ClearingFields()
        {
            txtDishName.Text = String.Empty;
            nudDishPrice.Value = 0;
            cbIngredientName.Text = string.Empty;
            cbAmount.Text = "1";
            dgvIngredientsList.Rows.Clear();
        }

        /// <summary>
        /// Method to refresh the list of the dishes
        /// </summary>
        private void RefreshDishesList()
        {
            dishes = db.GetDishData();
            dgvDishList.Rows.Clear();
            for (int i = 0; i < dishes.Length; i++)
            {
                dgvDishList.Rows.Add(dishes[i].Name, dishes[i].Price, (dishes[i].Status == 1)? "כן":"לא");
                if (dishes[i].Status == 0)
                {
                    for (int j = 0; j < 3; j++)
                        dgvDishList.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
            dgvDishList.ClearSelection();
        }

        /// <summary>
        /// Method to fill ingredients selection list
        /// </summary>
        public void FillIngredientsComboBox()
        {
            ingredients = db.GetIngredientsData();
            cbIngredientName.Items.Clear();
            for (int i = 0; i < ingredients.Length; i++)
            {
                cbIngredientName.Items.Add(ingredients[i].Name);
            }
            cbIngredientName.Text = ingredients[0].Name;
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Function for filling of ingredients in the dish to the dgvIngredientsList
        /// </summary>
        private void FillIngredientsOfDish(int dishID)
        {
            dgvIngredientsList.Rows.Clear();
            dishIngredients = db.GetDishIngredientsByID(dishID);
            for (int j = 0; j < dishIngredients.Length; j++)//בכדי לקבל את השמות של המרכיבים
            {
                string name = db.GetIngredientNameByID(dishIngredients[j].IngredientID);
                dgvIngredientsList.Rows.Add(dishIngredients[j].IngredientID, name, dishIngredients[j].Quantity);
            }

        }

        //------------------------------------- update dish code

        /// <summary>
        /// meethod wich works when the user chose dish from the dishes list
        /// the mehtod will pass to update dish form and fill the fields with the spcific dish details
        /// </summary>
        private void dgvDishList_Click(object sender, EventArgs e)
        {
            PassToUpdateDish();
            FillFieldsWithDishInfo();
        }

        /// <summary>
        /// method to arrange the form to update exists dish
        /// </summary>
        private void PassToUpdateDish()
        {
            updateFlag = true;
            lblMenu.Visible = true;
            cbDishInMenu.Visible = true;
            btnUpdateDish.Visible = true;
            btnAddDish.Visible = false;
            txtDishName.Enabled = false;
            lblHeader.Text = "עדכון מנה";
            IngredientsToAddToDish = new List<IngredientsInDish>();
            IngredientsToRemoveFromDish = new List<IngredientsInDish>();
        }

        /// <summary>
        /// method to arrange the form to add new dish
        /// </summary>
        private void PassToAddDish()
        {
            updateFlag = false;
            lblMenu.Visible = false;
            cbDishInMenu.Visible = false;
            btnUpdateDish.Visible = false;
            btnAddDish.Visible = true;
            txtDishName.Enabled = true;
            lblHeader.Text = "הוספת מנה חדשה";
        }

        /// <summary>
        /// method wich works when the user press on "update dish" button
        /// the method will pass to update dish form
        /// </summary>
        private void btnUpdateForm_Click(object sender, EventArgs e)
        {
            tcMain.SelectedTab = tpManageDish;
            PassToUpdateDish();
        }

        /// <summary>
        /// method wich works when the user press on "add dish" button
        /// the method will pass to add dish form
        /// </summary>
        private void btnAddDishForm_Click(object sender, EventArgs e)
        {
            tcMain.SelectedTab = tpManageDish;
            if (updateFlag)
            {
                ClearingFields();
                dgvDishList.ClearSelection();
            }
            PassToAddDish();
        }

        /// <summary>
        /// Methos wich works when the user press on "update dish" button
        /// the method will update the dish details in the data base
        /// </summary>
        private void btnUpdateDish_Click(object sender, EventArgs e)
        {
            if (dgvDishList.SelectedRows.Count > 0)//check if the user choose dish from the list
            {
                if (InputCheckDishNameAndPrice())
                {
                    newDish.Price = int.Parse(nudDishPrice.Value.ToString());
                    if (cbDishInMenu.Text == "כן")
                        newDish.Status = 1;
                    else
                        newDish.Status = 0;
                    db.UpdateDish(newDish);
                    UpdateProduct();
                    if (IngredientsToRemoveFromDish.Count > 0)//check if the user remove ingredeints from the dish
                    {
                        for (int i = 0; i < IngredientsToRemoveFromDish.Count; i++)
                            db.DeleteIngredientsOfDish(IngredientsToRemoveFromDish[i]);
                    }
                    if (IngredientsToAddToDish.Count > 0)//check if the user add ingredeints to the dish
                    {
                        for (int i = 0; i < IngredientsToAddToDish.Count; i++)
                            db.InsertIngredientsOfDish(IngredientsToAddToDish[i]);
                    }
                    MessageBox.Show(" !המנה עודכנה בהצלחה  ", "Messgae", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearingFields();
                    RefreshDishesList();
                }
            }
            else
                MessageBox.Show(" יש לבחור מנה מהרשימה!  ", "Messgae", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        /// <summary>
        /// method to fill the fields of form with the selected dish details
        /// </summary>
        private void FillFieldsWithDishInfo()
        {
            int index = dgvDishList.CurrentCell.RowIndex;
            newDish = dishes[index];
            txtDishName.Text = newDish.Name;
            nudDishPrice.Value = newDish.Price;
            if (newDish.Status == 1)
                cbDishInMenu.Text = "כן";
            else
                cbDishInMenu.Text = "לא";

            FillIngredientsOfDish(newDish.ID);
        }

        /// <summary>
        /// method to update the product with the new details
        /// </summary>
        private void UpdateProduct()
        {
            Product productToUpdate = new Product();
            productToUpdate.ProductID = newDish.ID;
            productToUpdate.Name = newDish.Name;
            productToUpdate.Price = newDish.Price;
            if (newDish.Status == 1)
                productToUpdate.Status = true;
            else
                productToUpdate.Status = false;
            productToUpdate.Type = "Dish";
            productToUpdate.Department = "kitchen";
            db.UpdateProduct(productToUpdate);
        }



        /******************************************mangae ingredients****************************************/

        /// <summary>
        /// method to fill the ingredients list with the ingredients details
        /// </summary>
        public void FillIngredientsList()
        {
            lstIngredients.Items.Clear();
            ingredients = db.GetIngredientsData();
            for (int i = 0; i < ingredients.Length; i++)
                lstIngredients.Items.Add(ingredients[i].Name);
        }

        //method wich works when the user press on "הוסף מרכיב" button
        //the method will add new ingredient in to the data base and refresh the ingredient list
        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            if (Checks.IsEmptyString(txtIngredientName.Text))
                MessageBox.Show("הכנס שם מרכיב להוספה");
            else
            {
                if (Checks.IsStringContainNumbers(txtIngredientName.Text))
                    MessageBox.Show("שם מרכיב לא יכול להכיל מספרים");
                else
                {
                    if (db.IsIngredientShow(txtIngredientName.Text))
                        MessageBox.Show("מרכיב עם השם הזה כבר קיים ברשימת המרכיבים!");
                    else
                    {
                        db.InsertNewIngredient(txtIngredientName.Text);
                        FillIngredientsList();
                        MessageBox.Show("המרכיב התווסף בהצלחה!");
                    }
                }
            }
        }

        /// <summary>
        /// Method to remove ingredient from the database
        /// </summary>
        private void btnRemoveIngredient_Click(object sender, EventArgs e)
        {
            if (Checks.IsItemSelected(lstIngredients))
            {
                if (db.IsIngredientPartOfDish(GetIngredientIdByName(txtIngredientName.Text)))
                    MessageBox.Show("המרכיב שנבחר הוא חלק ממנה, לא ניתן להסיר אותו!");
                else
                {
                    db.RemoveIngredientByName(chosenIngredientName);
                    MessageBox.Show("המרכיב נמחק בהצלחה!");
                    FillIngredientsList();
                }
            }
            else
                MessageBox.Show("בחר מרכיב מהרשימה ואז לחץ על הסר מרכיב");
        }

        /// <summary>
        /// method wich works when the user press on "update ingredient" button
        /// the method will update the chosen ingredient name in the data base
        /// </summary>
        private void btnUpdateIngredient_Click(object sender, EventArgs e)
        {
            if (Checks.IsItemSelected(lstIngredients))
            {
                int idToUpdate = GetIngredientIdByName(chosenIngredientName);
                db.UpdateIngredientById(txtIngredientName.Text, idToUpdate);
                MessageBox.Show("המרכיב עודכן בהצלחה בהצלחה!");
                FillIngredientsList();
            }
            else
                MessageBox.Show("בחר מרכיב מהרשימה ואז לחץ על עדכן מרכיב");
        }

        /// <summary>
        /// method wich works when the user chose ingredient from the list
        /// the method will fill the name field with the name of the chosen ingredient
        /// </summary>
        private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Checks.IsItemSelected(lstIngredients))
                chosenIngredientName = txtIngredientName.Text = lstIngredients.SelectedItem.ToString();
        }

        /// <summary>
        /// method wich get ingredient id by it name
        /// </summary>
        /// <param name="nameToSearchId">the name of the ingredient to get it id</param>
        /// <returns>int - the id of the ingredient</returns>
        public int GetIngredientIdByName(string nameToSearchId)
        {
            int res = -1;
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Name == nameToSearchId)
                    res = ingredients[i].ID;
            }
            return res;
        }

        /// <summary>
        /// method wich works when the user press on "manage ingredients" button
        /// the method will pass to manage ingreditns tab page
        /// </summary>
        private void btnManageIngredients_Click(object sender, EventArgs e)
        {
            FillIngredientsList();
            tcMain.SelectedTab = tpIngredeints;
        }

        /// <summary>
        /// method wich works when the tab pages changes
        /// the method will refresh the igredients combo box
        /// </summary>
        private void tpMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillIngredientsComboBox();
        }
    }
}

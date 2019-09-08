/*
 * OrderForm form code
 * class with the code of the form of making order when user press on table, this is the main form of the user to place order
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadot
{
    public partial class OrderForm : Form
    {
        private DBSQL db = new DBSQL();      //db connection
        private string glassOrBottle;        // flag to know if chosen glass or bottle
        private Order order;                 // the order we work with could be existent one or new one
        private LinesInOrder lineInOrder;    //the new line to add to an order
        private List<LinesInOrder> linesInOrders;  //list with all the new lines to insert to the order we work with. could be new order or existent one
        private List<LinesInOrder> linesInExistOrders; // List with all the existent lines of the current existent order
        private List<CancellationsInOrder> cancelsInOrder; // List with all the canceles of cur order

        private Customer selectedCustomer;
        private Employee selectedEmployee;

        private bool isExistOrder;           //flag to know if the order is new or existent
        private bool isInBill = false;           //flag to know if the order is in bill
        private bool dishFlag = false;       //For fill the current tab buttons
        private bool softDrinkFlag = false;  //For fill the current tab buttons
        private bool hotDrinkFlag = false;   //For fill the current tab buttons
        private bool dessertFlag = false;   //For fill the current tab buttons
        private bool generalFlag = false;   //For fill the current tab buttons

        private Table table;
        private Product[] currentProductByType; //array of the products of the same type (wine, dish, hot drink, soft drink...)
        private CancellationsInOrder cancelLine;

        /// <summary>
        /// OrderForm form constuctor
        /// methd wich set the header to table num and set the size of the form
        /// </summary>
        /// <param name="tableInfo">the spcific chosen table details </param>
        public OrderForm(Table tableInfo)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            table = tableInfo;
            lblTableOrder.Text = "הזמנה עבור שולחן מספר  " + table.TableID;

            linesInExistOrders = new List<LinesInOrder>();
            cancelsInOrder = new List<CancellationsInOrder>();
    }

        /// <summary>
        /// method wich works when OrderForm loads
        /// the method will check if the table status and set the form details according to status
        /// </summary>
        private void OrderFormTest_Load(object sender, EventArgs e)
        {
            FillCurrentTabButtons("Wine", tpWine);
            linesInOrders = new List<LinesInOrder>();
            if (table.TableStatus == "פנוי")//availble table - new order 
                NewOrder();
            else if (table.TableStatus == "תפוס")//occupied table - exist order
            {
                ExistentOrder();
            }
            else //occupied table - in bill
            {
                BillOrUpdate billOrUpdate = new BillOrUpdate();
                billOrUpdate.ShowDialog();
                if (billOrUpdate.DialogResult == System.Windows.Forms.DialogResult.Yes)
                    ExistentOrder();
                if (billOrUpdate.DialogResult == System.Windows.Forms.DialogResult.No)
                    InBill();
            }
                
        }

        /// <summary>
        /// method wich make new order with new details to availble table
        /// </summary>
        public void NewOrder()
        {
            btnBill.Enabled = false;
            btnPay.Enabled = false;
            btnDiscount.Enabled = false;
            cbDiscount.Enabled = false;
            btnCancelProductFromOrder.Enabled = false;
            isExistOrder = false;
            btnOTH.Enabled = true;
            order = new Order();
            order.OrderID = db.GetOrdersNumber();
            order.TableID = table.TableID;
            order.TotalPrice = 0;
            SelectWaiter selectWaiter = new SelectWaiter();
            selectWaiter.ShowDialog();
            lblEmployee.Text = " שם המלצר : " + selectWaiter.selctedWaiter.FirstName;
            order.EmployeeID = selectWaiter.selctedWaiter.ID;
            btnOTH.Enabled = false;
        }

        /// <summary>
        /// method wich fill the form with exist order details of the occupied table
        /// </summary>
        private void ExistentOrder()
        {
            isExistOrder = true;
            order = db.GetOrderByTableId(table.TableID);
            linesInExistOrders = new List<LinesInOrder>(db.GetLinesOfOrder(order.OrderID));
            SelectedEmployee();
            ContinueOrder();
            FillTablesList();
        }

        /// <summary>
        /// method wich fill the form fields with exist order details of occupied table that in bill
        /// </summary>
        private void InBill()
        {
            order = db.GetOrderByTableId(table.TableID);
            linesInExistOrders = new List<LinesInOrder>(db.GetLinesOfOrder(order.OrderID));
            SelectedCustomer();
            FillOrderListWithExistsProducts();
            FillListWithCancels();
            btnSwitchTable.Enabled = false;
            btnBill.Enabled = false;
            tcOrder.Enabled = false;
            btnAddOrder.Enabled = false;
            btnDeleteLine.Enabled = false;
            btnAddAmount.Enabled = false;
            btnSubAmount.Enabled = false;
            btnDiscount.Enabled = false;
            cbDiscount.Enabled = false;
            btnBill.Enabled = true;
            btnOTH.Enabled = false;
            btnCancelProductFromOrder.Enabled = false;
            isInBill = true;
        }

        /// <summary>
        /// method to select employee to the spcficic order and update the header
        /// </summary>
        private void SelectedEmployee()
        {
            selectedEmployee = db.GetEmployeeById(order.EmployeeID);
            lblEmployee.Text = " שם המלצר : " + selectedEmployee.FirstName ;
        }

        /// <summary>
        /// method to select customer to the spcficic order and update the header
        /// </summary>
        private void SelectedCustomer()
        {
            selectedCustomer = db.GetCustomerById(order.CustomerId);
            if (selectedCustomer != null)
                lblEmployee.Text = " " + selectedCustomer.FirstName + " " + selectedCustomer.LastName;
            else
                lblEmployee.Text = " לא נבחר לקוח";
        }

        /// <summary>
        /// method to continue with exist order and fill the table with the exists products
        /// </summary>
        private void ContinueOrder()
        {
            btnAddOrder.Enabled = false;
            btnDeleteLine.Enabled = true;
            btnPay.Enabled = false;
            btnOTH.Enabled = true;
            lblPrice.Text = order.TotalPrice.ToString();
            FillOrderListWithExistsProducts();
            FillListWithCancels();
            btnOTH.Enabled = true;
        }

        /// <summary>
        /// method to continue with exist order wich in bill requset and fill the table with the exists products
        /// </summary>
        private void BillRequest()
        {
            FillOrderListWithExistsProducts();
            FillListWithCancels();
            btnSelectCustomer.Enabled = true;
            btnSwitchTable.Enabled = false;
            btnBill.Enabled = true;
            btnDiscount.Enabled = true;
            btnPay.Enabled = false;
            btnAddOrder.Enabled = false;
            tcOrder.Enabled = false;
            btnAddAmount.Enabled = false;
            btnSubAmount.Enabled = false;
            btnOTH.Enabled = true;
            lblPrice.Text = order.TotalPrice.ToString();
        }

        /// <summary>
        /// method wich works when the user change the tab pages of the products
        /// the method will fill each tab with it spcific products from the data base
        /// </summary>
        private void tcOrder_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tcOrder.SelectedTab.Name == "tpDish" && !dishFlag)
            {
                FillCurrentTabButtons("Dish", tpDish);
                dishFlag = true;
            }
            if (tcOrder.SelectedTab.Name == "tpSoftDrinksAndAlcohol" && !softDrinkFlag)
            {
                FillCurrentTabButtons("SoftDrink", tpSoftDrinksAndAlcohol);
                softDrinkFlag = true;
            }
            if (tcOrder.SelectedTab.Name == "tpHotDrinksAndCoffee" && !hotDrinkFlag)
            {
                FillCurrentTabButtons("HotDrink", tpHotDrinksAndCoffee);
                hotDrinkFlag = true;
            }
            if (tcOrder.SelectedTab.Name == "tpDessert" && !dessertFlag)
            {
                FillCurrentTabButtons("Dessert", tpDessert);
                dessertFlag = true;
            }
            if (tcOrder.SelectedTab.Name == "tpGeneralProduct" && !generalFlag)
            {
                FillCurrentTabButtons("General", tpGeneralProduct);
                generalFlag = true;
            }
        }


        #region Order Functions **Fill** (FillCurrentTabButtons , FillOrderList ,  FillOrderListWithExistsProducts , )

        /// <summary>
        /// function to fill the spcific tab buttons of the products
        /// </summary>
        /// <param name="type"> the type of the buttons to get from the database </param>
        /// <param name="currTab"> the current tab page to add the buttons to </param>
        public void FillCurrentTabButtons(string type, TabPage currTab)
        {
            currentProductByType = db.GetProductsDataByType(type);//get the product from database by type
            int cols = 3;
            int rows = currentProductByType.Length / 3; // 3 buttons per line
            if (currentProductByType.Length % 3 > 0)//check if thers need in one more row
                rows++;

            int dif = 20;
            int width = 80; //set width of the button
            int height = 130;//set height of the button

            int top = dif;
            int left = currTab.Left + dif;
            int k = 0;// index of the spicific product in the array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols && k < currentProductByType.Length; j++, k++)
                {
                    MyBtn newBtn = new MyBtn();
                    newBtn.Text = currentProductByType[k].Name;
                    newBtn.ID = currentProductByType[k].ProductID;
                    newBtn.Left = left;
                    newBtn.Top = top;
                    newBtn.Width = width;
                    newBtn.Height = height;
                    newBtn.FlatStyle = FlatStyle.Popup;
                    newBtn.Font = new Font("Microsoft Sans Serif", 12);
                    left = width * (j + 1) + (dif * (j + 2));
                    newBtn.Click += new EventHandler(btnProduct_Click);
                    currTab.Controls.Add(newBtn);
                }
                top = height * (i + 1) + (dif * (i + 2));
                left = tpWine.Left + dif;
            }
        }

        private void FillListWithCancels()
        {
            int lastRowIndex = linesInExistOrders.Count();
            if(order.isCancels())
            {
                cancelsInOrder = new List<CancellationsInOrder>(db.GetCancelsOfOrder(order.OrderID));
                for (int i = 0; i < cancelsInOrder.Count; i++)
                {
                    dgvOrderList.Rows.Add(cancelsInOrder[i].printName(), 1, cancelsInOrder[i].PriceToSub * -1);
                    dgvOrderList.Rows[lastRowIndex + i].DefaultCellStyle.BackColor = Color.Yellow;
                }  
            }
        }

        /// <summary>
        /// method to fill order list with the details of products from the arrays
        /// </summary>
        private void FillOrderList()
        {
            dgvOrderList.Rows.Clear();
            if (isExistOrder)
            {
                FillOrderListWithExistsProducts();
                FillListWithCancels();
            }
            for (int i = 0; i < linesInOrders.Count; i++)
            {
                dgvOrderList.Rows.Add(linesInOrders[i].ProductName, linesInOrders[i].Amount, linesInOrders[i].TotalPrice);
                dgvOrderList.Rows[i].Selected = false;
            }
        }

        /// <summary>
        /// method to fill order list with the details of products from the array of exist products
        /// </summary>
        private void FillOrderListWithExistsProducts()
        {
            dgvOrderList.Rows.Clear();
            for (int i = 0; i < linesInExistOrders.Count; i++)
            {
                dgvOrderList.Rows.Add(linesInExistOrders[i].ProductName, linesInExistOrders[i].Amount, linesInExistOrders[i].TotalPrice);
                /*
                if (linesInExistOrders[i].Cancels != "No")
                    dgvOrderList.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                else
                */
                dgvOrderList.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                dgvOrderList.Rows[i].Selected = false;
            }
            lblPrice.Text = order.TotalPrice.ToString();
        }


        #endregion


        #region Order Functions **Update** ( UpdateStock , UpdateStockByDate , UpdateLineInOrder , )

        /// <summary>
        /// method to update stock by date table in the data base
        /// with the spcific amount from every line in order
        /// </summary>
        private void UpdateStockByDate()
        {
            Stock tmpStock = new Stock();
            for (int i = 0; i < linesInExistOrders.Count; i++)
            {
                tmpStock.ProductID = linesInExistOrders[i].ProductID;
                if(linesInExistOrders[i].Notes == "כוס")
                {
                    tmpStock.TotalAmount = linesInExistOrders[i].Amount/4;
                }
                tmpStock.TotalAmount = linesInExistOrders[i].Amount;
                tmpStock.Date = DateTime.Now.Day.ToString();
                db.UpdateProductInStockByDate(tmpStock.Date, tmpStock.TotalAmount, tmpStock.ProductID);
            }
        }

        /// <summary>
        /// method to update spsific line in order details
        /// </summary>
        /// <param name="lineInOrderToUpdate">the line with the new details to update</param>
        private void UpdateLineInOrder(LinesInOrder lineInOrderToUpdate)
        {
            bool stopFlag = false;
            for (int i = 0; i < linesInOrders.Count && !stopFlag; i++)
            {
                if (linesInOrders[i].ProductID == lineInOrderToUpdate.ProductID && linesInOrders[i].ProductName == lineInOrderToUpdate.ProductName)
                {
                    linesInOrders[i].Amount += lineInOrderToUpdate.Amount;
                    linesInOrders[i].TotalPrice += lineInOrderToUpdate.TotalPrice;
                    stopFlag = true;
                }
            }
        }

        #endregion


        #region Order Functions **Button** ( btnOrder_Click , OpenCurrentTab , btnProduct_Click , btnSelectCustomer_Click , btnPay_Click ,  btnExit_Click , btnAddOrder_Click  , btnDeleteLine_Click)

        /// <summary>
        /// method wich works when the user press on one of the menue tabs buttons
        /// the method will fill the chosen tab with the products buttons (only if this is the first enter)
        /// and set the tabe to the chosen one
        /// </summary>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenCurrentTab(((Button)sender).Text);
        }

        /// <summary>
        /// method to move the tab to the chosen one
        /// </summary>
        /// <param name="btnName">the name of the tab that the use chose</param>
        private void OpenCurrentTab(string btnName)
        {
            if (btnName == btnWine.Text)
                tcOrder.SelectedIndex = 0;
            if (btnName == btnDish.Text)
                tcOrder.SelectedIndex = 1;
            if (btnName == btnSoftDrinksAndAlcohol.Text)
                tcOrder.SelectedIndex = 2;
            if (btnName == btnHotDrinksAndCoffee.Text)
                tcOrder.SelectedIndex = 3;
            if (btnName == btnDessert.Text)
                tcOrder.SelectedIndex = 4;
            if (btnName == btnGeneralProduct.Text)
                tcOrder.SelectedIndex = 5;
        }

        /// <summary>
        /// method wich works when the use press on one of the products buttons
        /// the method will add the spcific product to the lines in order
        /// </summary>
        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product tmpProduct = db.GetProductById(((MyBtn)sender).ID);//get product details with the id (the id is in the "ID" property of the specific MyBtn object )
            lineInOrder = new LinesInOrder();
            lineInOrder.OrderID = order.OrderID;
            lineInOrder.ProductID = tmpProduct.ProductID;
            lineInOrder.ProductName = tmpProduct.Name;

            if (tmpProduct.Type == "Wine")
                WineChosed(tmpProduct);
            else
                lineInOrder.TotalPrice = tmpProduct.Price;

            if (tmpProduct.Type == "Dish")
                DishChosed(tmpProduct);

            if (lineInOrder.TotalPrice != -1)
            {
                if (ProductAlreadyInOrderLine(lineInOrder.ProductID, lineInOrder.ProductName))//Check if the product allready existent in the lines of the current order
                    UpdateLineInOrder(lineInOrder);//The product is in the list, update the current line amount and total price
                else
                    linesInOrders.Add(lineInOrder);//The product is not in the list, add the product to current order lines

                FillOrderList(); //Update the list, for user to know the product add
                glassOrBottle = string.Empty;
                order.TotalPrice += lineInOrder.TotalPrice;
                lblPrice.Text = order.TotalPrice.ToString();
            }

        }

        /// <summary>
        /// method wich add dish product to the lines in order
        /// </summary>
        /// <param name="tmpProduct">the dish product details</param>
        private void DishChosed(Product tmpProduct)
        {
            DishingredentsInOrder dishingredentsInOrder = new DishingredentsInOrder(tmpProduct.ProductID, tmpProduct.Name);
            dishingredentsInOrder.ShowDialog();
            if (dishingredentsInOrder.ingredentsToRemove != string.Empty)
            {
                lineInOrder.ProductName += " " + dishingredentsInOrder.ingredentsToRemove;
                lineInOrder.Notes = "" + dishingredentsInOrder.ingredentsToRemove;
            }
        }

        /// <summary>
        /// method wich add wine product to the lines in order
        /// </summary>
        /// <param name="tmpProduct">the wine product details</param>
        private void WineChosed(Product tmpProduct)
        {
            Wine tmpWine = db.GetWineById(tmpProduct.ProductID);
            if (SplitProductName(tmpWine.Name) == "טעימות")
            {
                lineInOrder.TotalPrice = tmpWine.PriceGlass;
                lineInOrder.Notes = "none";
            }
            else
            {
                using (GlassOrBottle glassOrBottleForm = new GlassOrBottle(tmpWine.PriceGlass)) //Pop up the form to choose glass or bottle
                {
                    if (glassOrBottleForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        glassOrBottle = glassOrBottleForm.Result;
                }
                if (glassOrBottle == "כוס")//if the user chose to add glas of wine
                {
                    lineInOrder.TotalPrice = tmpWine.PriceGlass;
                    lineInOrder.ProductName += "-כוס";
                    lineInOrder.Notes = "כוס";
                }
                else if (glassOrBottle == "בקבוק")
                {
                    lineInOrder.TotalPrice = tmpWine.PriceBottle;//if the user chose to add bottle of wine
                    lineInOrder.ProductName += "-בקבוק";
                    using (NumberOfGlass numberOfGlass = new NumberOfGlass()) //Pop up the form to choose glass or bottle
                    {
                        if (numberOfGlass.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            lineInOrder.Notes = numberOfGlass.Number.ToString();
                    }
                }
                else if (glassOrBottle == "בקבוק לקחת")
                {
                    lineInOrder.TotalPrice = (tmpWine.PriceBottle - (tmpWine.PriceBottle * 10 / 100)) - 1;//if the user chose to add to take bottle of wine -  10% discount 
                    lineInOrder.ProductName += "-בקבוק לקחת";
                }
            }
        }

        /// <summary>
        /// method to split product name by spaces
        /// </summary>
        /// <param name="productName">the product name to split</param>
        /// <returns>string - the first string until space</returns>
        private string SplitProductName(string productName)
        {
            string[] str = productName.Split(' ');
            return str[0];
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            SelectCustomer selectCustomer = new SelectCustomer();
            selectCustomer.ShowDialog();
            selectedCustomer = selectCustomer.selctedCustomer;
            if (selectedCustomer != null)
            {
                lblEmployee.Text = " " + selectedCustomer.FirstName + " " + selectedCustomer.LastName;
                order.CustomerId = selectedCustomer.CustomerId;
            }
            db.UpdateOrder(order);
        }

        /// <summary>
        /// method wich works when the user press on "exit" button
        /// the method will close the order form and back to user home page form
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// method wich works when the user press on "make order" button
        /// the method will send to print the currents bons and insert the new lines in order to the data base
        /// </summary>
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            bool flag = true;
            PrintBon printBon = new PrintBon();
            printBon.Print(linesInOrders.ToArray(), order.TableID , order.EmployeeID);
            if (isExistOrder)
            {
                for (int i = 0; i < linesInOrders.Count; i++)
                {
                    flag = true;
                    for (int j = 0; j < linesInExistOrders.Count && flag; j++)
                    {
                        if ((linesInOrders[i].ProductID == linesInExistOrders[j].ProductID) && (linesInOrders[i].ProductName == linesInExistOrders[j].ProductName))
                        {
                            flag = false;
                            linesInOrders[i].Amount += linesInExistOrders[j].Amount;
                            linesInOrders[i].TotalPrice += linesInExistOrders[j].TotalPrice;
                            db.UpdateLineInOrder(linesInOrders[i]);
                        }
                    }
                    if (flag)
                    {
                        db.InsertLineInOrder(linesInOrders[i]); 
                    }
                }
                db.UpdateOrder(order);
            }
            else
            {
                db.InsertNewOrder(order);
                for (int i = 0; i < linesInOrders.Count; i++)
                {
                    db.InsertLineInOrder(linesInOrders[i]);
                }
            }
        }

        /// <summary>
        /// method wich works when the user press on "delete line" button
        /// the method will delete the chosen line in order in case that is not invited allready
        /// </summary>
        private void btnDeleteLine_Click(object sender, EventArgs e)
        {
            int index;
            int sumOfCancelsAndExistProducts = linesInExistOrders.Count + cancelsInOrder.Count;
            if (dgvOrderList.SelectedRows.Count > 0)
            {
                index = dgvOrderList.CurrentCell.RowIndex;
                if (index >= sumOfCancelsAndExistProducts)
                {
                    order.TotalPrice -= linesInOrders[index - sumOfCancelsAndExistProducts].TotalPrice;
                    linesInOrders.RemoveAt(index - sumOfCancelsAndExistProducts);
                    lblPrice.Text = order.TotalPrice.ToString();
                    FillOrderList();
                }
                else
                    MessageBox.Show("לא ניתן למחוק מוצר שסופק או בוטל");
            }
            else
                MessageBox.Show("בחר מוצר למחיקה ");
        }

        #endregion


        /// <summary>
        /// Method wich check if product allready show in the list of products in the current order
        /// </summary>
        /// <param name="productID">the id of the product to search if show</param>
        /// <param name="productName">the name of the product to search if show</param>
        /// <returns>true - show, false - not show</returns>
        private bool ProductAlreadyInOrderLine(int productID, string productName)
        {
            bool result = false;
            for (int i = 0; i < linesInOrders.Count && !result; i++)
            {
                if (linesInOrders[i].ProductID == productID && linesInOrders[i].ProductName == productName)
                    result = true;
            }
            return result;
        }

        /// <summary>
        /// method wich works when the user press on "switch table" button
        /// the method will change btween the current table to the the new table of user chose
        /// and close the current form
        /// </summary>
        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            if (isExistOrder)//check if this is exist order
            {
                if(order.TableID < 200)
                {
                    if (linesInOrders.Count == 0)//check if there is products that is not part of the exist order
                    {
                        if (cbTablesList.Text != "בחר שולחן")
                        {
                            if (CheckIfTableIsAvailable(int.Parse(cbTablesList.Text)))
                            {  //if the change is to empty table
                                db.UpdateTableStatus(order.TableID, "פנוי");
                                order.TableID = int.Parse(cbTablesList.Text);
                                db.UpdateOrderTable(order);
                                db.UpdateTableStatus(order.TableID, "תפוס");
                            }
                            else
                            {  //else the change to occupid table
                                db.UpdateTableStatus(order.TableID, "פנוי");
                                order.TableID += 200;
                                db.InsertTable(order.TableID, "עבר ל " + cbTablesList.Text);
                                db.UpdateOrderTable(order);
                            }
                            MessageBox.Show("החלפת השולחן בוצע בהצלחה");
                            this.Close();
                        }
                        else
                            MessageBox.Show("בחר שולחן מהרשימה!");
                    }
                    else
                        MessageBox.Show("ישנם מוצרים שטרם הוזמנו, מחק אותם או בצע הזמנה ולאחר מכן החלף שולחן");
                }
                else
                    MessageBox.Show("לא ניתן להחליף שולחן זמני!");
            }
            else
                MessageBox.Show("לא ניתן להחליף שולחן, בצע הזמנה קודם");
        }

        /// <summary>
        /// method wich checks if table status is availble
        /// </summary>
        /// <param name="tableId">the id of the table to check it status</param>
        /// <returns>true - if availble, false other</returns>
        private bool CheckIfTableIsAvailable(int tableId)
        {
            bool flag = true;
            string tableStatus = db.GetTableStatus(tableId);
            if (tableStatus == "תפוס")
                flag = false;
            return flag;
        }

        /// <summary>
        /// method to fill tables combo box with all tables id's
        /// </summary>
        private void FillTablesList()
        {
            Table[] tables;
            tables = db.GetTablesData();
            //cbTablesList.Items.Add("בחר שולחן");
            for (int i = 0; i < tables.Length; i++)
            {
                if (tables[i].TableStatus != "בחשבון" && tables[i].TableID != order.TableID && tables[i].TableID < 200)
                {
                    cbTablesList.Items.Add(tables[i].TableID);
                }
            }
        }

        /// <summary>
        /// method wich works when the user press on "print bill" button
        /// the method will update table status and send the order details to print the bill
        /// </summary>
        private void btnBill_Click(object sender, EventArgs e)
        {
            if(!isInBill)
            {
                if (linesInOrders.Count > 0)
                    MessageBox.Show("לא ניתן להדפיס חשבון בלי לבצע הזמנה של המוצר החדשים");
                else
                {
                    MessageBill messageBill = new MessageBill();
                    messageBill.ShowDialog();
                    if (messageBill.DialogResult == DialogResult.Yes)
                    {
                        if (table.TableStatus != "בחשבון")
                        {
                            if (order.TableID >= 200)
                            {
                                string tableStatus = db.GetTableStatus(order.TableID);
                                db.UpdateTableStatus(table.TableID, tableStatus + "-" + "בחשבון");
                            }
                            else
                                db.UpdateTableStatus(table.TableID, "בחשבון");
                            db.UpdateOrder(order);
                            this.DialogResult = DialogResult.No;
                        }
                        PrintBill();
                    }
                    else
                        this.DialogResult = DialogResult.None;
                }
            }
            else
                PrintBill();
        }

        /// <summary>
        /// method wich works when the user press on "discount" button
        /// the method will calculate the discount and enter to lines in exist order and data base
        /// </summary>
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (order.TotalPrice > 0)// check if the total price of the order bigger then 0
            {
                if (order.Discount == 0)//check if the order didnet get any discount yet
                {
                    if (linesInOrders.Count == 0)//check if there is products that is not part of the exist order
                    {
                        Product tmpProduct = db.GetProductById(((MyBtn)sender).ID);//get product details with the id (the id is in the "ID" property of the specific MyBtn object )
                        lineInOrder = new LinesInOrder();
                        lineInOrder.OrderID = order.OrderID;
                        lineInOrder.ProductID = tmpProduct.ProductID;
                        lineInOrder.ProductName = tmpProduct.Name + " " + cbDiscount.SelectedItem.ToString() + " % ";
                        double discountGiven = (order.TotalPrice * int.Parse(cbDiscount.SelectedItem.ToString()) / 100) + 1;
                        lineInOrder.TotalPrice = int.Parse(discountGiven.ToString());
                        lineInOrder.TotalPrice *= -1;
                        order.Discount = lineInOrder.TotalPrice;
                        UpdateLablPrice(lineInOrder.TotalPrice);
                        db.InsertLineInOrder(lineInOrder);
                        db.UpdateOrder(order);
                        linesInExistOrders.Add(lineInOrder);
                        FillOrderList();
                    }
                    else
                        MessageBox.Show("ישנם מוצרים שטרם הוזמנו, מחק אותם או בצע הזמנה ולאחר מכן לחץ על הנחה");
                }
                else
                    MessageBox.Show("ישנה הנחה להזמנה זו, אם ברצונך להזין הנחה חדשה בטל/י את הישנה");
            }
            else
                MessageBox.Show("לא ניתן לבצע הנחה על הזמנה שסכומה הוא 0");

        }

        /// <summary>
        /// method wich works when the user press on "cancle product" button
        /// the method will cancle the chosen line in order only exist line or discount
        /// </summary>
        private void btnCancelProductFromOrder_Click(object sender, EventArgs e)
        {
            int index;
            int sumOfCancelsAndExistProducts = linesInExistOrders.Count + cancelsInOrder.Count;
            if (dgvOrderList.SelectedRows.Count > 0)//check if the user choose product to cancle from the list
            {
                index = dgvOrderList.CurrentCell.RowIndex;
                if (index > sumOfCancelsAndExistProducts - 1)//check if the row index equal or less then the exist lines so this is a new product
                {
                    MessageBox.Show("לא ניתן לבטל מוצר שרק נוסף ", "הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(index < linesInExistOrders.Count)
                    {
                        if (linesInExistOrders[index].ProductID == 66)
                        {
                            CancleDiscount(index);
                            MessageBox.Show("ההנחה בוטלה בהצלחה והחשבון התעדכן");
                        }
                        else if (linesInExistOrders[index].ProductID == 117)
                        {
                            CanclePayInAdvenced(index);
                            MessageBox.Show("שורת התשלום מראש בוטלה בהצלחה והחשבון התעדכן");
                        }
                        else
                            CancleProduct(index);
                    }
                    else
                        MessageBox.Show("לא ניתן לבטל מוצר שכבר בוטל ", "הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("בחר מוצר לביטול ");
        }

        /// <summary>
        /// method to cancle discount line from exsit order
        /// </summary>
        /// <param name="index">the index of the row of the discount to cancle</param>
        private void CancleDiscount(int index)
        {
            db.RemoveLineOfOrder(order.OrderID, 66);
            linesInExistOrders = new List<LinesInOrder>(db.GetLinesOfOrder(order.OrderID));
            UpdateLablPrice(order.Discount * -1);
            order.Discount = 0;
            db.UpdateOrder(order);
            dgvOrderList.Rows.RemoveAt(index);
        }

        /// <summary>
        /// method to cancle pay in advenced line from exsit order
        /// </summary>
        /// <param name="index">the index of the row of the pay in advenced to cancle</param>
        private void CanclePayInAdvenced(int index)
        {
            int sumOfPayInAdvenced = int.Parse(dgvOrderList.Rows[index].Cells[2].Value.ToString());
            db.RemoveLineOfOrder(order.OrderID, 117);
            linesInExistOrders = new List<LinesInOrder>(db.GetLinesOfOrder(order.OrderID));
            UpdateLablPrice(sumOfPayInAdvenced * -1);
            db.UpdateOrder(order);
            dgvOrderList.Rows.RemoveAt(index);
        }

        /*
        /// <summary>
        /// method to cancle product from exist order
        /// </summary>
        /// <param name="index">the index of the row of the product to cancle</param>
        private void CancleProduct(int index)
        {
            if (MessageBox.Show("האם אתה בטוח שברצונך לבטל מוצר זה ", "הודעת מערכת ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FillLineToCancel(linesInExistOrders[index]);
                CancelProductFromOrder cancelProduct = new CancelProductFromOrder();
                cancelProduct.ShowDialog();
                if (cancelProduct.DialogResult == DialogResult.OK)
                {
                    if (linesInExistOrders[index].Amount > 1)
                        lineInOrder.TotalPrice = (linesInExistOrders[index].TotalPrice / linesInExistOrders[index].Amount) * -1;
                    else
                        lineInOrder.TotalPrice = linesInExistOrders[index].TotalPrice * -1;

                    lineInOrder.Cancels = cancelProduct.CancellationReason;
                    order.TotalPrice += lineInOrder.TotalPrice;
                    db.UpdateOrder(order);
                    linesInExistOrders.Add(lineInOrder);
                    db.InsertLineInOrder(lineInOrder);
                    FillOrderList();
                }
            }
            else
                MessageBox.Show("המוצר לא בוטל");
        }
        */

        /// <summary>
        /// method to cancle product from exist order
        /// </summary>
        /// <param name="index">the index of the row of the product to cancle</param>
        private void CancleProduct(int index)
        {
            if (MessageBox.Show("האם אתה בטוח שברצונך לבטל מוצר זה ", "הודעת מערכת ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lineInOrder = linesInExistOrders[index];
                cancelLine = new CancellationsInOrder();
                cancelLine.PriceToSub = db.GetProductPriceByID(lineInOrder.ProductID);

                if(cancelLine.PriceToSub <= order.TotalPrice)
                {
                    cancelLine.OrderId = lineInOrder.OrderID;
                    cancelLine.ProductId = lineInOrder.ProductID;
                    cancelLine.ProductName = lineInOrder.ProductName;

                    if (lineInOrder.Amount > 1)//check if ordered more then one from this product
                    {
                        lineInOrder.Amount--;
                        if (lineInOrder.TotalPrice > cancelLine.PriceToSub)
                            lineInOrder.TotalPrice -= cancelLine.PriceToSub;
                        db.UpdateLineInOrder(lineInOrder);
                    }
                    else//if there is only one from the product remove the line
                        db.RemoveLineOfOrder(lineInOrder.OrderID, lineInOrder.ProductID);

                    db.InsertCancelOfOrder(cancelLine);
                    order.TotalPrice -= cancelLine.PriceToSub;
                    order.Cancels = "Yes";
                    db.UpdateOrder(order);
                    linesInExistOrders = new List<LinesInOrder>(db.GetLinesOfOrder(order.OrderID));
                    FillOrderList();
                }
                else
                    MessageBox.Show("מחיר ההזמנה קטן ממחיר המוצר, לא ניתן לבטל");

            }
            else
                MessageBox.Show("המוצר לא בוטל");
        }


        /// <summary>
        /// method wich create and fill the object of the line in order to cancel with the correct information
        /// </summary>
        /// <param name="linesToCancel">the object of the line to cancel</param>
        private void FillLineToCancel(LinesInOrder linesToCancel)
        {
            lineInOrder = new LinesInOrder();
            lineInOrder.OrderID = linesToCancel.OrderID;
            lineInOrder.ProductID = linesToCancel.ProductID;
            lineInOrder.ProductName = linesToCancel.ProductName + " - בוטל - ";
            lineInOrder.TotalPrice = linesToCancel.TotalPrice;
            if (linesToCancel.Amount > 1)
                lineInOrder.Amount = linesToCancel.Amount - 1;
            else
                lineInOrder.Amount = 1;
        }

        /// <summary>
        /// method wich works when the user press on "pay / close table" button
        /// the method will update stock, table status, order details
        /// </summary>
        private void btnPay_Click(object sender, EventArgs e)
        {
            UpdateStockByDate();
            order = db.GetOrderByTableId(table.TableID);
            order.IsPaid = true;
            db.UpdateOrder(order);
            if (order.TableID >= 200)
                db.DeleteTable(order.TableID);
        }

        /// <summary>
        /// method wich works when the user press on "sub amount" button
        /// the method will sub one from the chosen line in order amount
        /// </summary>
        private void btnSubAmount_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.SelectedRows.Count > 0)
            {
                if (int.Parse(dgvOrderList.CurrentRow.Cells[1].Value.ToString()) == 1)
                {
                    MessageBox.Show("לא ניתן להוריד כמות ממוצר שהכמות שלו 1 \n באפשרותך למחוק שורה זו", "הודעת מערכת", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int index = CheckIndex();
                    if (index != -1)
                    {
                        int amount = int.Parse(dgvOrderList.Rows[index].Cells[1].Value.ToString());
                        UpdateLablPrice((linesInOrders[index].TotalPrice / linesInOrders[index].Amount) * -1);
                        dgvOrderList.Rows[index].Cells[1].Value = amount - 1;
                        linesInOrders[index].TotalPrice -= linesInOrders[index].TotalPrice / linesInOrders[index].Amount;//product price par unit
                        linesInOrders[index].Amount -= 1;
                        FillOrderList();
                    }
                    else
                        MessageBox.Show(" לא ניתן לבצע את הפעולה על המוצר הנבחר מפני שהמוצר סופק או בוטל");
                }
            }
            else
                MessageBox.Show("יש צורך לבחור מוצר בכדי להוריד ממנו כמות", "הודעת מערכת", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// method wich works when the user press on "add amount" button
        /// the method will add one to amount of the chosen line in order
        /// </summary>
        private void btnAddAmount_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.SelectedRows.Count > 0)
            {
                int index = CheckIndex();
                if (index != -1)
                {
                    int amount = int.Parse(dgvOrderList.Rows[index].Cells[1].Value.ToString());
                    UpdateLablPrice(linesInOrders[index].TotalPrice / linesInOrders[index].Amount);
                    dgvOrderList.Rows[index].Cells[1].Value = amount + 1;
                    linesInOrders[index].TotalPrice += linesInOrders[index].TotalPrice / linesInOrders[index].Amount;//product price par unit
                    linesInOrders[index].Amount += 1;
                    FillOrderList();
                }
                else
                    MessageBox.Show(" לא ניתן לבצע את הפעולה על המוצר הנבחר מפני שהמוצר סופק או בוטל");
            }
            else
                MessageBox.Show("יש צורך לבחור מוצר בכדי להוסיף לו כמות", "הודעת מערכת", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// method to check the index of the selected row
        /// </summary>
        /// <returns>int index - the index of the chosen row</returns>
        private int CheckIndex()
        {
            int index = dgvOrderList.CurrentCell.RowIndex;
            int sumOfCancelsAndExistProducts = linesInExistOrders.Count + cancelsInOrder.Count;
            if (isExistOrder)
            {
                if (index < sumOfCancelsAndExistProducts)
                    index = -1;
                else
                    index -= sumOfCancelsAndExistProducts;
            }
            return index;
        }

        /// <summary>
        /// method wich update the text of label price and the order totoal price with the priceToAddOrSub
        /// </summary>
        /// <param name="priceToAddOrSub">the price to add to total price</param>
        private void UpdateLablPrice(int priceToAddOrSub)
        {
            order.TotalPrice += priceToAddOrSub;
            lblPrice.Text = order.TotalPrice.ToString();
        }

        /// <summary>
        /// method wich print the bill of the current order details
        /// </summary>
        private void PrintBill()
        {
            PrintBon printBon = new PrintBon();
            printBon.PrintReceipt(linesInExistOrders.ToArray(),order.TableID , order);
        }

        /// <summary>
        /// method wich works when the user press on the upward arrow picture
        /// the method will pass the selected line one line up
        /// </summary>
        private void picUp_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.RowCount > 0)
            {
                if (dgvOrderList.SelectedRows.Count > 0)
                {
                    int index = dgvOrderList.SelectedCells[0].OwningRow.Index;
                    if (index > 0)
                    {
                        dgvOrderList.ClearSelection();
                        dgvOrderList.CurrentCell = dgvOrderList[0, index - 1];
                    }
                }
            }
        }

        /// <summary>
        /// method wich works when the user press on the down arrow picture
        /// the method will pass the selected line one line down
        /// </summary>
        private void picDown_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.RowCount > 0)
            {
                if (dgvOrderList.SelectedRows.Count > 0)
                {
                    int index = dgvOrderList.SelectedCells[0].OwningRow.Index;
                    if (index < dgvOrderList.RowCount - 1)
                    {
                        dgvOrderList.ClearSelection();
                        dgvOrderList.CurrentCell = dgvOrderList[0, index + 1];
                    }
                }
            }
        }

        /// <summary>
        /// method wich works when new row add to the order list
        /// the method will update total products label
        /// </summary>
        private void dgvOrderList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotalProduct.Text = dgvOrderList.RowCount.ToString();
        }

        /// <summary>
        /// method wich works when new row romve from the order list
        /// the method will update total products label
        /// </summary>
        private void dgvOrderList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotalProduct.Text = dgvOrderList.RowCount.ToString();
        }

        /// <summary>
        /// method wich works when the lblTotalProduct TextChanged
        /// the method will update the status of "make order" button
        /// </summary>
        private void lblTotalProduct_TextChanged(object sender, EventArgs e)
        {
            if (isExistOrder)
            {
                if (int.Parse(lblTotalProduct.Text) - linesInExistOrders.Count > 0)
                    btnAddOrder.Enabled = true;
                else
                    btnAddOrder.Enabled = false;
            }
            else
            {
                if (lblTotalProduct.Text != "0")
                    btnAddOrder.Enabled = true;
                else
                    btnAddOrder.Enabled = false;
            }
        }

        /// <summary>
        /// method wich works when the user press on "OTH" button
        /// the method will update the chosen line in order to price of 0
        /// </summary>
        private void btnOTH_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.SelectedRows.Count > 0)
            {
                int index = dgvOrderList.CurrentCell.RowIndex;
                if (index < linesInExistOrders.Count)
                {

                    int price = int.Parse(dgvOrderList.Rows[index].Cells[2].Value.ToString());
                    UpdateLablPrice(price * -1);
                    dgvOrderList.Rows[index].Cells[2].Value = 0;
                    linesInExistOrders[index].TotalPrice -= price;//product price par unit
                    linesInExistOrders[index].ProductName += " - על חשבון הבית";
                    db.UpdateLineInOrder(linesInExistOrders[index]);
                    db.UpdateOrder(order);
                    FillOrderList();
                }
                else
                {
                    if (index >= linesInExistOrders.Count + cancelsInOrder.Count)
                        MessageBox.Show("יש להזמין מוצר זה", "הודעת מערכת", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("לא ניתו לבצע פעול זו על מוצר שבוטל!", "הודעת מערכת", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// timer method to update the clock label
        /// </summary>
        void tmr_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void btnPayPartOfBill_Click_1(object sender, EventArgs e)
        {
            int sumToPay = int.Parse(nudSumToPay.Value.ToString());

            if (isExistOrder)
            {
                if (sumToPay > 0)
                {
                    if (order.TotalPrice > 0)
                    {
                        if (sumToPay <= order.TotalPrice)
                        {
                            if (linesInOrders.Count == 0)//check if there is products that is not part of the exist order
                            {
                                Product tmpProduct = db.GetProductById(((MyBtn)sender).ID);//get product details with the id (the id is in the "ID" property of the specific MyBtn object )
                                sumToPay *= -1;
                                if (CheckIfPartOfBillAllreadyPaid(tmpProduct.ProductID))
                                {
                                    lineInOrder.TotalPrice += sumToPay;
                                    db.UpdateLineInOrder(lineInOrder);
                                }
                                else
                                {
                                    lineInOrder = new LinesInOrder();
                                    lineInOrder.OrderID = order.OrderID;
                                    lineInOrder.ProductID = tmpProduct.ProductID;
                                    lineInOrder.ProductName = tmpProduct.Name;
                                    lineInOrder.TotalPrice = sumToPay;
                                    db.InsertLineInOrder(lineInOrder);
                                    linesInExistOrders.Add(lineInOrder);
                                }
                                UpdateLablPrice(sumToPay);
                                db.UpdateOrder(order);
                                FillOrderList();
                            }
                            else
                                MessageBox.Show("ישנם מוצרים שטרם הוזמנו, מחק אותם או בצע הזמנה");
                        }
                        else
                            MessageBox.Show("הסכום שהוכנס גדול מסכום ההזמנה !");
                    }
                    else
                        MessageBox.Show("לא ניתן לשלם חלק מהזמנה שסכומה הוא 0 !");
                }
                else
                    MessageBox.Show("הכנס סכום לתשלום !");
            }
            else
                MessageBox.Show("לא ניתן לבצע תשלום חלקי לפני ביצוע הזמנה !");
        }

        /// <summary>
        /// method wich checks in the lines of exists order
        /// if there is line of "paid in advenced "  or this is the first time
        /// that the user press on this button
        /// </summary>
        private bool CheckIfPartOfBillAllreadyPaid(int id)
        {
            bool flag = false;
            for(int i = 0; i < linesInExistOrders.Count; i++)
            {
                if (linesInExistOrders[i].ProductID == id)
                {
                    lineInOrder = linesInExistOrders[i];
                    flag = true;
                }
                    
            }
            return flag;
        }
    }
}

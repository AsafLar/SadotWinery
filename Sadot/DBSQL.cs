/*
 * Data Base class code
 * class wich include all the functions to communicate with the data base
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Sadot
{
    class DBSQL
    {
        /*private static string connectionString = "SERVER = 185.224.137.225 ;PORT=3306;DATABASE=u691360607_sadot;UID=u691360607_admin;PASSWORD=admin1234;SslMode=none;";*/ //regular data base
        private static string connectionString = "SERVER = 185.224.137.225 ;PORT=3306;DATABASE=u691360607_test;UID=u691360607_asaf;PASSWORD=sadottest;SslMode=none;"; //test data base for development
        MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        #region DataBase Functions **Login** ( CheckLogin )

        /// <summary>
        /// The method returns user information to check login information 
        /// </summary>
        /// <returns> User </returns>
        public User CheckLogin(string userNameToCheck, string passwordToCheck)
        {
            User newUser = null;
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `userName` = @userName AND password = @password", databaseConnection);
            cmd.Parameters.AddWithValue("@userName", userNameToCheck);
            cmd.Parameters.AddWithValue("@password", passwordToCheck);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    newUser = new User();
                    newUser.UserID = int.Parse(reader["user_id"].ToString());
                    newUser.UserName = reader["UserName"].ToString();
                    newUser.Password = reader["password"].ToString();
                    newUser.Permission = reader["permission"].ToString();
                }
            }
            databaseConnection.Close();
            return newUser;
        }

        #endregion

        #region DataBase Functions **User** ( InsertNewUser , GetUsersData , UpdateUserPassword , UpdateUser)


        /// <summary>
        /// Method to insert new user into the data base
        /// </summary>
        /// <param name="newUser"></param>
        public void InsertNewUser(User newUser)
        {
            string query = "INSERT INTO `users` (userName,password,permission) VALUES (@userName , @password , @permission)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@userName", newUser.UserName);
            cmd.Parameters.AddWithValue("@password", newUser.Password);
            cmd.Parameters.AddWithValue("@permission", newUser.Permission);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Method to get users data from the data base
        /// </summary>
        public User[] GetUsersData()
        {
            string query = "SELECT* FROM users";
            ArrayList users = new ArrayList();
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    User user = new User();
                    user.UserID = int.Parse(reader["user_id"].ToString());
                    user.UserName = reader["UserName"].ToString();
                    user.Password = reader["password"].ToString();
                    user.Permission = reader["permission"].ToString();
                    users.Add(user);
                }
                databaseConnection.Close();
            }
            return (User[])users.ToArray(typeof(User));
        }

        /// <summary>
        /// Method to update user password
        /// </summary>
        public void UpdateUserPassword(User userToUpdate)
        {
            string query = "UPDATE `users` SET `password`=@password WHERE `user_id` = @userId";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@password", userToUpdate.Password);
            cmd.Parameters.AddWithValue("@userId", userToUpdate.UserID);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = cmd.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Method to update user details
        /// </summary>
        public void UpdateUser(User userToUpdate)
        {
            string query = "UPDATE `users` SET `password`=@password, `permission` =@permission WHERE `user_id` = @userId";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@password", userToUpdate.Password);
            cmd.Parameters.AddWithValue("@permission", userToUpdate.Permission);
            cmd.Parameters.AddWithValue("@userId", userToUpdate.UserID);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = cmd.ExecuteReader();
                databaseConnection.Close();
            }
            catch { }
        }

        #endregion

        #region DataBase Functions **Employee** ( GetEmployeesData , GetEmployeeById , InsertNewEmployee , UpdateEmployee , GetEmployeeDataSearch , GetActiveEmployeesData)

        /// <summary>
        /// Method to get employees data from the data base
        /// </summary>
        /// <returns>array of all the employess details in the data base</returns>
        public Employee[] GetEmployeesData()
        {
            string query = "SELECT * FROM employees";
            ArrayList employees = new ArrayList();
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.ID = int.Parse(reader["e_id"].ToString());
                    employee.FirstName = reader["firstName"].ToString();
                    employee.LastName = reader["lastName"].ToString();
                    employee.Status = int.Parse(reader["status"].ToString());
                    employees.Add(employee);
                }
                databaseConnection.Close();
            }
            return (Employee[])employees.ToArray(typeof(Employee));
        }

        /// <summary>
        /// method to get spicific employee details by his id
        /// </summary>
        /// <param name="employeeID">the id of the employee to search</param>
        /// <returns> the employee object with all the details </returns>
        public Employee GetEmployeeById(int employeeID)
        {
            Employee employee = null;
            string query = "SELECT * FROM `employees` WHERE `e_id` = @employeeID";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@employeeID", employeeID);

            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    employee = new Employee();
                    employee.ID = int.Parse(reader["e_id"].ToString());
                    employee.FirstName = reader["firstName"].ToString();
                    employee.LastName = reader["lastName"].ToString();
                    employee.Status = int.Parse(reader["status"].ToString());
                }
                databaseConnection.Close();
            }
            return employee;
        }

        /// <summary>
        /// metchod wich insert new employee to the data base
        /// </summary>
        /// <param name="newEmployee">the spicific employee details to insert</param>
        public void InsertNewEmployee(Employee newEmployee)
        {
            string query = "INSERT INTO employees(`e_id`, `firstName`, `lastName`, `status`) VALUES (@employeeId , @fname , @lname, @status)";

            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@employeeId", null);
            cmd.Parameters.AddWithValue("@fname", newEmployee.FirstName);
            cmd.Parameters.AddWithValue("@lname", newEmployee.LastName);
            cmd.Parameters.AddWithValue("@status", newEmployee.Status);

            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Metchod wich update exists employee details in the data base
        /// </summary>
        /// <param name="employeeToUpdate">the details to update the employee with</param>
        public void UpdateEmployee(Employee employeeToUpdate)
        {
            string query = "UPDATE `employees` SET `firstName` = @fname, `lastName` = @lname, `status` = @status WHERE `e_id` = @employeeId";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@fname", employeeToUpdate.FirstName);
            cmd.Parameters.AddWithValue("@lname", employeeToUpdate.LastName);
            cmd.Parameters.AddWithValue("@status", employeeToUpdate.Status);
            cmd.Parameters.AddWithValue("@employeeId", employeeToUpdate.ID);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Method wich get employees data from the data base
        /// the method get query to search spsific employees by user parameters
        /// </summary>
        /// <param name="query">the query which include the spsific parameters to search by</param>
        /// <returns>array of the employess that found </returns>
        public Employee[] GetEmployeeDataSearch(string query)
        {
            ArrayList employees = new ArrayList();
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.ID = int.Parse(reader["e_id"].ToString());
                    employee.FirstName = reader["firstName"].ToString();
                    employee.LastName = reader["lastName"].ToString();
                    employee.Status = int.Parse(reader["status"].ToString());
                    employees.Add(employee);
                }
                databaseConnection.Close();
            }
            return (Employee[])employees.ToArray(typeof(Employee));
        }
        
        /// <summary>
        /// Method to get all active employees data from the data base
        /// </summary>
        /// <returns>Array of all the active employess details in the data base</returns>
        public Employee[] GetActiveEmployeesData()
        {
            string query = "SELECT * FROM `employees` WHERE `status` = 1"; 
            ArrayList employees = new ArrayList();
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.ID = int.Parse(reader["e_id"].ToString());
                    employee.FirstName = reader["firstName"].ToString();
                    employee.LastName = reader["lastName"].ToString();
                    employee.Status = int.Parse(reader["status"].ToString());
                    employees.Add(employee);
                }
                databaseConnection.Close();
            }
            return (Employee[])employees.ToArray(typeof(Employee));
        }

        #endregion

        #region DataBase Functions **Ingredients** ( GetIngredientsData , GetIngredientNameByID , InsertNewIngredient , IsIngredientShow , RemoveIngredientByName , UpdateIngredientById , IsIngredientPartOfDish , UpdateIngredientStock)

        /// <summary>
        /// Method to get Ingredients Data from the database
        /// </summary>
        /// <returns></returns>
        public Ingredients[] GetIngredientsData()
        {
            ArrayList ingredients = new ArrayList();
            string query = "SELECT * FROM dish_ingredients";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Ingredients ingredient = new Ingredients();
                    ingredient.ID = int.Parse(reader["di_id"].ToString());
                    ingredient.Name = reader["di_name"].ToString();
                    ingredients.Add(ingredient);
                }
                databaseConnection.Close();
            }
            return (Ingredients[])ingredients.ToArray(typeof(Ingredients));
        }

        /// <summary>
        /// Method to get ingredient name by ingredient id
        /// </summary>
        /// <returns></returns>
        public string GetIngredientNameByID(int ingredientID)
        {
            string result = string.Empty;
            string query = "SELECT di_name FROM dish_ingredients WHERE di_id = @ingredientID";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@ingredientID", ingredientID);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                    result = reader["di_name"].ToString();
                databaseConnection.Close();
            }
            return result;
        }

        
        /// <summary>
        /// Method to insert new ingredient into the data base
        /// </summary>
        public void InsertNewIngredient(string newIngredientName)
        {
            string query = "INSERT INTO dish_ingredients(`di_id`, `di_name`, `di_quantity`) VALUES (@id , @name , @quantity)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@id", null);//null for auto increment
            cmd.Parameters.AddWithValue("@name", newIngredientName);
            cmd.Parameters.AddWithValue("@quantity", 0);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch
            { }
        }

        /// <summary>
        /// method wich checks if ingredient shows in the data base
        /// </summary>
        /// <param name="ingredientName">the ingredient name to search</param>
        /// <returns>true if show false if not shows</returns>
        public bool IsIngredientShow(string ingredientName)
        {
            int count = 0;
            bool res;
            string query = "SELECT COUNT(`di_name`) FROM dish_ingredients WHERE `di_name` = @iName";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@iName", ingredientName);
            try
            {
                databaseConnection.Open();
                count = int.Parse(cmd.ExecuteScalar().ToString());
                databaseConnection.Close();
            }
            catch { }

            if (count == 1)
                res = true;
            else
                res = false;
            return res;
        }

        /// <summary>
        /// Method to remove ingredient from the database
        /// </summary>
        /// <param name="ingredientName"></param>
        public void RemoveIngredientByName(string ingredientName) 
        {
            string query = "DELETE FROM dish_ingredients WHERE `di_name` = @iName";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@iName", ingredientName);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }

        }


        /// <summary>
        /// Method to update ingredient name by ingredient id 
        /// </summary>
        public void UpdateIngredientById(string newIngredientName, int idToUpdate) 
        {
            string query = "UPDATE `dish_ingredients` SET `di_name` = @newName WHERE `di_id` = @idToUpdate";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@newName", newIngredientName);
            cmd.Parameters.AddWithValue("@idToUpdate", idToUpdate);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }

        }

        /// <summary>
        ///Method that return if the ingredient is part of dish
        /// </summary>
        /// <returns>
        /// res = true - ingredient is part of dish
        /// res = false - ingredient is not part of dish
        /// </returns>
        public bool IsIngredientPartOfDish(int ingredientID)
        {
            int count = 0;
            bool res;
            string query = "SELECT COUNT(`di_id`) FROM dishingredients_in_dish WHERE `di_id` = @ingredientID";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@ingredientID", ingredientID);
            try
            {
                databaseConnection.Open();
                count = int.Parse(cmd.ExecuteScalar().ToString());
                databaseConnection.Close();
            }
            catch { }

            if (count > 0)
                res = true;
            else
                res = false;
            return res;
        }

        /// <summary>
        /// Method which update ingredient stock
        /// </summary>
        public void UpdateIngredientStock(int dishID, int amountToUpdate)
        {
            string query = "UPDATE `dish_ingredients` SET `di_quantity` = di_quantity + @di_quantity WHERE `di_id` = @idToUpdate";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@di_quantity", amountToUpdate);
            cmd.Parameters.AddWithValue("@idToUpdate", dishID);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        #endregion

        #region DataBase Functions **Tables** (InsertTable , UpdateTableStatus , GetTablesData)


        /// <summary>
        /// Method to insert tables in to the database
        /// </summary>
        public void InsertTable(int id, string status)
        {
            string query = "INSERT INTO `tables` (`tableID`, `tableStatus`) VALUES(@tableId, @tablestatus) ";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@tableId", id);
            cmd.Parameters.AddWithValue("@tablestatus", status);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }


        /// <summary>
        /// Method to update tables status in to the database
        /// </summary>
        public void UpdateTableStatus(int id, string status)
        {
            string query = "UPDATE `tables` SET `tableStatus`=@status WHERE `tableID` = @id";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Method to get tables data from the database
        /// </summary>
        public Table[] GetTablesData()
        {
            ArrayList tables = new ArrayList();
            string query = "SELECT * FROM tables";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Table table = new Table();
                    table.TableID = int.Parse(reader["tableID"].ToString());
                    table.TableStatus = reader["tableStatus"].ToString();
                    tables.Add(table);
                }
                databaseConnection.Close();
            }
            return (Table[])tables.ToArray(typeof(Table));
        }

        /// <summary>
        /// Method to Delete table for database
        /// </summary>
        /// <param name="tableID"></param>
        public void DeleteTable(int tableID)
        {
            string query = "DELETE FROM `tables` WHERE `tableID` = @tableId";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@tableId", tableID);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }


        // SELECT `tableStatus` FROM `tables` WHERE `tableID` = 7

        /// <summary>
        /// Method to get the table status by table ID
        /// </summary>
        /// <param name="tableID"></param>
        /// <returns></returns>
        public string GetTableStatus(int tableID)
        {
            string res = string.Empty;
            string query = "SELECT `tableStatus` FROM `tables` WHERE `tableID` = @tableID";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@tableID", tableID);
            try
            {
                databaseConnection.Open();
                res = cmd.ExecuteScalar().ToString();
                databaseConnection.Close();
            }
            catch { }
            
            return res;
        }


        #endregion

        #region DataBase Functions **Wine** (InsertNewWine,UpdateWine,GetWinesData,GetWineById,IsWineNameAndYearAlreadyExists,GetWineDataSearch)

        /// <summary>
        /// Method to insert new wine in to the database
        /// </summary>
        /// <param name="newWine"></param>
        public void InsertNewWine(Wine newWine)
        {
            string query = "INSERT INTO wine(wineID , wineName , wineYear , winePriceBottle , winePriceGlass , wineStatus)  VALUES (@wineID , @wineName , @wineYear , @winePriceBottle , @winePriceGlass , @wineStatus)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@wineID", newWine.WineID);
            cmd.Parameters.AddWithValue("@wineName", newWine.Name);
            cmd.Parameters.AddWithValue("@wineYear", newWine.Year);
            cmd.Parameters.AddWithValue("@winePriceBottle", newWine.PriceBottle);
            cmd.Parameters.AddWithValue("@winePriceGlass", newWine.PriceGlass);
            cmd.Parameters.AddWithValue("@wineStatus", newWine.Status);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Method to update wine info in to the database
        /// </summary>
        /// <param name="wineToUpdate"></param>
        public void UpdateWine(Wine wineToUpdate)
        {
            string query = "UPDATE `wine` SET `wineName`= @wineName , `wineYear`= @wineYear, `winePriceBottle`= @winePriceBottle , `winePriceGlass`= @winePriceGlass , `wineStatus`= @wineStatus WHERE `wineID` = @wineID ";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@wineName", wineToUpdate.Name);
            cmd.Parameters.AddWithValue("@wineYear", wineToUpdate.Year);
            cmd.Parameters.AddWithValue("@winePriceBottle", wineToUpdate.PriceBottle);
            cmd.Parameters.AddWithValue("@winePriceGlass", wineToUpdate.PriceGlass);
            cmd.Parameters.AddWithValue("@wineStatus", wineToUpdate.Status);
            cmd.Parameters.AddWithValue("@wineID", wineToUpdate.WineID);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Method to get wines info from the database
        /// </summary>
        /// <returns></returns>
        public Wine[] GetWinesData()
        {
            string query = "SELECT * FROM wine";
            ArrayList wines = new ArrayList();
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Wine wine = new Wine();
                    wine.WineID = int.Parse(reader["wineID"].ToString());
                    wine.Name = reader["wineName"].ToString();
                    wine.Year = reader["wineYear"].ToString();
                    wine.PriceBottle = int.Parse(reader["winePriceBottle"].ToString());
                    wine.PriceGlass = int.Parse(reader["winePriceGlass"].ToString());
                    wine.Status = bool.Parse(reader["wineStatus"].ToString());
                    wines.Add(wine);
                }
                databaseConnection.Close();
            }
            return (Wine[])wines.ToArray(typeof(Wine));
        }

        //הוספה חדשה 26.8
        /// <summary>
        /// Method to get wine info by id from the database
        /// </summary>
        public Wine GetWineById(int id)
        {
            string query = "SELECT * FROM wine WHERE wineID = @wineID";
            Wine wine = null;
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@wineID", id);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    wine = new Wine();
                    wine.WineID = int.Parse(reader["wineID"].ToString());
                    wine.Name = reader["wineName"].ToString();
                    wine.Year = reader["wineYear"].ToString();
                    wine.PriceBottle = int.Parse(reader["winePriceBottle"].ToString());
                    wine.PriceGlass = int.Parse(reader["winePriceGlass"].ToString());
                    wine.Status = bool.Parse(reader["wineStatus"].ToString());
                }
                databaseConnection.Close();
            }
            return wine;
        }

        /// <summary>
        /// Method to check if the wine already exists by name and year
        /// </summary>
        public bool IsWineNameAndYearAlreadyExists(string wineNameToCheck , string wineYearToCheck)
        {
            int count = 0;
            bool res;
            string query = "SELECT COUNT(`wineName`) FROM wine WHERE `wineName` = @wineName AND `wineYear` = @wineYear";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@wineName", wineNameToCheck);
            cmd.Parameters.AddWithValue("@wineYear", wineYearToCheck);
            try
            {
                databaseConnection.Open();
                count = int.Parse(cmd.ExecuteScalar().ToString());
                databaseConnection.Close();
            }
            catch { }

            if (count > 0)
                res = true;
            else
                res = false;
            return res;
        }

        /// <summary>
        /// Method to get wines data according to the search
        /// </summary>
        public Wine[] GetWineDataSearch(string query)
        {
            ArrayList wines = new ArrayList();
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Wine wine = new Wine();
                    wine.WineID = int.Parse(reader["wineID"].ToString());
                    wine.Name = reader["wineName"].ToString();
                    wine.Year = reader["wineYear"].ToString();
                    wine.PriceBottle = int.Parse(reader["winePriceBottle"].ToString());
                    wine.PriceGlass = int.Parse(reader["winePriceGlass"].ToString());
                    wine.Status = bool.Parse(reader["wineStatus"].ToString());
                    wines.Add(wine);
                }
                databaseConnection.Close();
            }
            return (Wine[])wines.ToArray(typeof(Wine));
        }

        #endregion

        #region DataBase Functions **Product**( InsertNewProduct, UpdateProduct ,GetProductIdByName ,GetProductsData ,GetProductsDataByType ,  GetProductById ,IsProductNameAlreadyExists , GetProductDataSearch , GetProdductDepartmentByID , GetProductTypeByID ,  GetProductNameByID )

        /// <summary>
        /// Method to insert new product to the database
        /// </summary>
        public void InsertNewProduct(Product newProduct)
        {
            string query = "INSERT INTO product(id,name,price,type,department,status)  VALUES (@id , @name , @price , @type , @department , @status)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@id", null);//null for auto increment
            cmd.Parameters.AddWithValue("@name", newProduct.Name);
            cmd.Parameters.AddWithValue("@price", newProduct.Price);
            cmd.Parameters.AddWithValue("@type", newProduct.Type);
            cmd.Parameters.AddWithValue("@department", newProduct.Department);
            cmd.Parameters.AddWithValue("@status", newProduct.Status);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Method to update product info 
        /// </summary>
        /// <param name="productToUpdate"></param>
        public void UpdateProduct(Product productToUpdate)
        {
            string query = "UPDATE `product` SET `name`= @productName , `price`= @productPrice, `type`= @productType , `department`= @productDepartment , `status` = @status WHERE `id` = @productId ";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@productName", productToUpdate.Name);
            cmd.Parameters.AddWithValue("@productPrice", productToUpdate.Price);
            cmd.Parameters.AddWithValue("@productType", productToUpdate.Type);
            cmd.Parameters.AddWithValue("@productDepartment", productToUpdate.Department);
            cmd.Parameters.AddWithValue("@status", productToUpdate.Status);
            cmd.Parameters.AddWithValue("@productId", productToUpdate.ProductID);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Method to get product ID by poduct name
        /// </summary>
        public int GetProductIdByName(string name)
        {
            int result = -1;
            string query = "SELECT id FROM product WHERE name = @productName";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@productName", name);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                    result = int.Parse(reader["id"].ToString());
                databaseConnection.Close();
            }
            return result;
        }

        /// <summary>
        /// Method to get all products data from the database
        /// </summary>
        /// <returns></returns>
        public Product[] GetProductsData()
        {
            ArrayList products = new ArrayList();
            string query = "SELECT * FROM product";// WHERE type = @General";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@General", "General");
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    Product product = new Product();
                    product.ProductID = int.Parse(reader["id"].ToString());
                    product.Name = reader["name"].ToString();
                    product.Price = int.Parse(reader["price"].ToString());
                    product.Type = reader["type"].ToString();
                    product.Department = reader["department"].ToString();
                    product.Status = bool.Parse(reader["status"].ToString());
                    products.Add(product);
                }
                databaseConnection.Close();
            }
            return (Product[])products.ToArray(typeof(Product));
        }


        /// <summary>
        /// Method to get product info by product type
        /// </summary>
        public Product[] GetProductsDataByType(string type)
        {
            ArrayList products = new ArrayList();
            string query = "SELECT * FROM product WHERE type = @type AND status = 1";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@type", type);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductID = int.Parse(reader["id"].ToString());
                    product.Name = reader["name"].ToString();
                    product.Price = int.Parse(reader["price"].ToString());
                    product.Type = reader["type"].ToString();
                    product.Department = reader["department"].ToString();
                    product.Status = bool.Parse(reader["status"].ToString());
                    products.Add(product);
                }
                databaseConnection.Close();
            }
            return (Product[])products.ToArray(typeof(Product));
        }

        /// <summary>
        /// Method to get procduct info by product ID
        /// </summary>
        public Product GetProductById(int id)
        {
            Product product = null;
            string query = "SELECT * FROM product WHERE id = @productID";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@productID", id);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    product = new Product();
                    product.ProductID = int.Parse(reader["id"].ToString());
                    product.Name = reader["name"].ToString();
                    product.Price = int.Parse(reader["price"].ToString());
                    product.Type = reader["type"].ToString();
                    product.Department = reader["department"].ToString();
                    product.Status = bool.Parse(reader["status"].ToString());
                }
                databaseConnection.Close();
            }
            return product;
        }

        /// <summary>
        /// Method to check if the product alrady exists in the database
        /// </summary>
        /// <param name="productNameToCheck"></param>
        /// <returns></returns>
        public bool IsProductNameAlreadyExists(string productNameToCheck)
        {
            int count = 0;
            bool res;
            string query = "SELECT COUNT(`name`) FROM product WHERE `name` = @productName";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@productName", productNameToCheck);//null for auto increment
            try
            {
                databaseConnection.Open();
                count = int.Parse(cmd.ExecuteScalar().ToString());
                databaseConnection.Close();
            }
            catch { }
            if (count > 0)
                res = true;
            else
                res = false;
            return res;
        }

        /// <summary> 
        /// Method to get product data by other parameters   
        /// </summary>
        public Product[] GetProductDataSearch(string query)
        {
            ArrayList products = new ArrayList();
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductID = int.Parse(reader["id"].ToString());
                    product.Name = reader["name"].ToString();
                    product.Price = int.Parse(reader["price"].ToString());
                    product.Type = reader["type"].ToString();
                    product.Department = reader["department"].ToString();
                    product.Status = bool.Parse(reader["status"].ToString());
                    products.Add(product);
                }
                databaseConnection.Close();
            }
            return (Product[])products.ToArray(typeof(Product));
        }



        /// <summary>
        /// Method to get product departmen  by product id
        /// </summary>
        public string GetProdductDepartmentByID(int productId)
        {
            string productDepartment = string.Empty;
            string query = "SELECT `department` FROM product WHERE `id` = @productId";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@productId", productId);
            try
            {
                databaseConnection.Open();
                productDepartment = cmd.ExecuteScalar().ToString();
                databaseConnection.Close();
            }
            catch { }
            return productDepartment;
        }


        /// <summary>
        /// Method to get product type by product id
        /// </summary>
        public bool GetProductTypeByID(int productId)
        {
            string productType = string.Empty;
            string query = "SELECT `type` FROM product WHERE `id` = @productId";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@productId", productId);
            try
            {
                databaseConnection.Open();
                productType = cmd.ExecuteScalar().ToString();
                databaseConnection.Close();
            }
            catch { }

            if (productType == "Wine")
                return true;
            else
                return false;
        }

        /// <summary>
        /// Method to get product name by product id
        /// </summary>
        public string GetProductNameByID(int productId)
        {
            string productName = string.Empty;
            string query = "SELECT `name` FROM product WHERE `id` = @productId";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@productId", productId);
            try
            {
                databaseConnection.Open();
                productName = cmd.ExecuteScalar().ToString();
                databaseConnection.Close();
            }
            catch { }

            return productName;
        }

        /// <summary>
        /// Method to get product price by product id
        /// </summary>
        public int GetProductPriceByID(int productId)
        {
            int price = 0;
            string query = "SELECT `price` FROM product WHERE `id` = @productId";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@productId", productId);
            try
            {
                databaseConnection.Open();
                price = int.Parse(cmd.ExecuteScalar().ToString());
                databaseConnection.Close();
            }
            catch { }

            return price;
        }
        #endregion


        #region DataBase Functions **Dish**(InsertNewDish ,InserIngredientsOfDish ,DeleteIngredientsOfDish ,UpdateIngredientsOfDish , UpdateDish ,GetDishIdByName ,GetDishIngredientsByID ,GetDishIngredientsByID2 ,GetDishData ,IsDishNameAlreadyExists ,InsertIngredientsOfDish

        /// <summary>
        /// Method to insert new dish into the database
        /// </summary>
        public void InsertNewDish(Dish newDish)
        {
            string query = "INSERT INTO dish(dishID,dishName,dishPrice,dishStatus)  VALUES (@dishID , @dishName , @dishPrice , @dishStatus)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@dishID", newDish.ID);//null for auto increment
            cmd.Parameters.AddWithValue("@dishName", newDish.Name);
            cmd.Parameters.AddWithValue("@dishPrice", newDish.Price);
            cmd.Parameters.AddWithValue("@dishStatus", newDish.Status);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Method to insert new ingredient to be part of dish 
        /// </summary>
        /// <param name="ingredientToInsert"></param>
        public void InserIngredientsOfDish(IngredientsInDish ingredientToInsert)
        {
            string query = "INSERT INTO `dishingredients_in_dish` (`d_id`, `di_id`, `quantity`)  VALUES (@dishID , @ingredientID , @quantity)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@dishID", ingredientToInsert.DishID);
            cmd.Parameters.AddWithValue("@ingredientID", ingredientToInsert.IngredientID);
            cmd.Parameters.AddWithValue("@quantity", ingredientToInsert.Quantity);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }


        /// <summary>
        /// Methos to delete ingridient part of a dish 
        /// </summary>
        public void DeleteIngredientsOfDish(IngredientsInDish ingredientToDelete)
        {
            string query = "DELETE FROM `dishingredients_in_dish` WHERE `d_id` = @dishID AND `di_id` = @ingredientID";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@dishID", ingredientToDelete.DishID);
            cmd.Parameters.AddWithValue("@ingredientID", ingredientToDelete.IngredientID);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }


        /// <summary>
        /// Methos to update the ingridient of a dish
        /// </summary>
        public void UpdateIngredientsOfDish(IngredientsInDish ingredientToInsert)
        {
            string query = "UPDATE `dishingredients_in_dish` SET `quantity`= @quantity  WHERE `d_id` = @dishID AND `di_id`= @ingredientID ";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@dishID", ingredientToInsert.DishID);
            cmd.Parameters.AddWithValue("@ingredientID", ingredientToInsert.IngredientID);
            cmd.Parameters.AddWithValue("@quantity", ingredientToInsert.Quantity);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }


        /// <summary>
        /// Methos to update dish data 
        /// </summary>
        /// <param name="dishToUpdate">the dish to update</param>
        public void UpdateDish(Dish dishToUpdate)
        {
            string query = "UPDATE `dish` , `product` SET `dish`.`dishName` = @dishName , `dish`.`dishPrice` = @dishPrice  , `dish`.`dishStatus` = @status , `product`.`name` = @dishName , `product`.`price` = @dishPrice" +
                "  WHERE `dish`.`dishID` = @dishID AND `product`.`id` = @dishID";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@dishName", dishToUpdate.Name);
            cmd.Parameters.AddWithValue("@dishPrice", dishToUpdate.Price);
            cmd.Parameters.AddWithValue("@status", dishToUpdate.Status);
            cmd.Parameters.AddWithValue("@dishID", dishToUpdate.ID);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Method to get dish info by dish id
        /// </summary>
        public int GetDishIdByName(string dishName)
        {
            DataSet ds = new DataSet();
            int result = -1;
            string query = "SELECT dishID FROM dish WHERE dishName = @dishName";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@dishName", dishName);//null for auto increment
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                    result = int.Parse(reader["dishID"].ToString());
                databaseConnection.Close();
            }
            return result;
        }

        /// <summary>
        /// Method to get all the ingredients of the dish by the dish id
        /// </summary>
        public IngredientsInDish[] GetDishIngredientsByID(int dishID)
        {
            ArrayList dishIngredients = new ArrayList();
            string query = "SELECT * FROM dishingredients_in_dish WHERE d_id = @dishID";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@dishID", dishID);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    IngredientsInDish ingredient = new IngredientsInDish();
                    ingredient.DishID = int.Parse(reader["d_id"].ToString());
                    ingredient.IngredientID = int.Parse(reader["di_id"].ToString());
                    ingredient.Quantity = double.Parse(reader["quantity"].ToString());

                    dishIngredients.Add(ingredient);
                }
                databaseConnection.Close();
            }
            return (IngredientsInDish[])dishIngredients.ToArray(typeof(IngredientsInDish));
        }

        /// <summary>
        /// Method to get all the ingredients of the dish by the dish id 
        /// </summary>
        /// <param name="dishID"></param>
        /// <returns></returns>
        public Ingredients[] GetDishIngredientsByID2(int dishID)
        {
            ArrayList dishIngredientsInDish = new ArrayList();
            string query = "SELECT * FROM `dish_ingredients` WHERE `di_id` IN (SELECT `di_id` FROM `dishingredients_in_dish` WHERE `d_id` = @dishID)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@dishID", dishID);

            databaseConnection.Open();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Ingredients ingredient = new Ingredients();
                    ingredient.ID = int.Parse(reader["di_id"].ToString());
                    ingredient.Name = reader["di_name"].ToString();
                    ingredient.Quantity = int.Parse(reader["di_quantity"].ToString());
                    dishIngredientsInDish.Add(ingredient);
                }
                databaseConnection.Close();
            }
            return (Ingredients[])dishIngredientsInDish.ToArray(typeof(Ingredients));
        }


        /// <summary>
        /// Method to get dush data from the database
        /// </summary>
        /// <returns></returns>
        public Dish[] GetDishData()
        {
            ArrayList dishes = new ArrayList();
            string query = "SELECT * FROM dish";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Dish dish  = new Dish();
                    dish.ID = int.Parse(reader["dishID"].ToString());
                    dish.Name = reader["dishName"].ToString();
                    dish.Price = int.Parse(reader["dishPrice"].ToString());
                    dish.Status = int.Parse(reader["dishStatus"].ToString());
                    dishes.Add(dish);
                }
                databaseConnection.Close();
            }
            return (Dish[])dishes.ToArray(typeof(Dish));
        }


        /// <summary> 
        /// Methos to check if the new dush us already exists
        /// </summary>
        public bool IsDishNameAlreadyExists(string dishNameToCheck)
        {
            int count = 0;
            bool res;
            string query = "SELECT COUNT(`dishName`) FROM dish WHERE `dishName` = @dishName";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@dishName", dishNameToCheck);//null for auto increment

            try
            {
                databaseConnection.Open();
                count = int.Parse(cmd.ExecuteScalar().ToString());
                databaseConnection.Close();
            }
            catch { }

            if (count > 0)
                res = true;
            else
                res = false;
            return res;
        }



        /// <summary>
        /// Method to insert new ingrident to dish
        /// </summary>
        /// <param name="ingredientToInsert"></param>
        public void InsertIngredientsOfDish(IngredientsInDish ingredientToInsert)
        {
            string query = "INSERT INTO `dishingredients_in_dish` (`d_id`, `di_id`, `quantity`)  VALUES (@dishID , @ingredientID , @quantity)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@dishID", ingredientToInsert.DishID);
            cmd.Parameters.AddWithValue("@ingredientID", ingredientToInsert.IngredientID);
            cmd.Parameters.AddWithValue("@quantity", ingredientToInsert.Quantity);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        #endregion

        #region DataBase Functions **Customer**(GetCustomersData ,InsertNewCustomer ,UpdateCustomer, GetCustomerDataSearch, GetCustomerById)


        /// <summary>
        /// Methos to get customer data
        /// </summary>
        /// <returns></returns>
        public Customer[] GetCustomersData()
        {
            ArrayList customers = new ArrayList();
            string query = "SELECT * FROM customers";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerId = int.Parse(reader["cID"].ToString());
                    customer.FirstName = reader["firstName"].ToString();
                    customer.LastName = reader["lastName"].ToString();
                    customer.Email = reader["email"].ToString();
                    customer.Phone = reader["phoneNumber"].ToString();
                    customer.DateOfBirth = reader["birthday"].ToString();
                    customer.Anniversary = reader["anniversary"].ToString();
                    customer.Status = int.Parse(reader["status"].ToString());
                    customers.Add(customer);
                }
                databaseConnection.Close();
            }
            return (Customer[])customers.ToArray(typeof(Customer));
        }

        /// <summary>
        /// Method to insert new customer to database
        /// </summary>
        public void InsertNewCustomer(Customer newCustomer)
        {
            string query = "INSERT INTO customers(`cID`, `firstName`, `lastName`, `email`, `phoneNumber`, `birthday`, `anniversary`, `status`)  VALUES (@customerId , @fname , @lname, @email, @phone, @bday, @anniversary, @status)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@customerId", null);
            cmd.Parameters.AddWithValue("@fname", newCustomer.FirstName);
            cmd.Parameters.AddWithValue("@lname", newCustomer.LastName);
            cmd.Parameters.AddWithValue("@email", newCustomer.Email);
            cmd.Parameters.AddWithValue("@phone", newCustomer.Phone);
            cmd.Parameters.AddWithValue("@bday", newCustomer.DateOfBirth);
            cmd.Parameters.AddWithValue("@anniversary", newCustomer.Anniversary);
            cmd.Parameters.AddWithValue("@status", newCustomer.Status);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Methos to get the active customer data
        /// </summary>
        /// <returns></returns>
        public Customer[] GetActiveCustomersData()
        {
            ArrayList customers = new ArrayList();
            string query = "SELECT * FROM customers WHERE `status` = 1 ";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerId = int.Parse(reader["cID"].ToString());
                    customer.FirstName = reader["firstName"].ToString();
                    customer.LastName = reader["lastName"].ToString();
                    customer.Email = reader["email"].ToString();
                    customer.Phone = reader["phoneNumber"].ToString();
                    customer.DateOfBirth = reader["birthday"].ToString();
                    customer.Anniversary = reader["anniversary"].ToString();
                    customer.Status = int.Parse(reader["status"].ToString());
                    customers.Add(customer);
                }
                databaseConnection.Close();
            }
            return (Customer[])customers.ToArray(typeof(Customer));
        }

        /// <summary>
        /// Method to update customer info
        /// </summary>
        public void UpdateCustomer(Customer customerToUpdate)
        {
            string query = "UPDATE `customers` SET `firstName`= @fname , `lastName`= @lname, `email`= @email , `phoneNumber`= @phone , `birthday` = @bday  , `anniversary` = @anniversary , `status` = @status   WHERE `cID` = @customerId ";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@customerId", customerToUpdate.CustomerId);
            cmd.Parameters.AddWithValue("@fname", customerToUpdate.FirstName);
            cmd.Parameters.AddWithValue("@lname", customerToUpdate.LastName);
            cmd.Parameters.AddWithValue("@email", customerToUpdate.Email);
            cmd.Parameters.AddWithValue("@phone", customerToUpdate.Phone);
            cmd.Parameters.AddWithValue("@bday", customerToUpdate.DateOfBirth);
            cmd.Parameters.AddWithValue("@anniversary", customerToUpdate.Anniversary);
            cmd.Parameters.AddWithValue("@status", customerToUpdate.Status);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Method to get customer by other parmeters
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public Customer[] GetCustomerDataSearch(string query)
        {
            ArrayList customers = new ArrayList();
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerId = int.Parse(reader["cID"].ToString());
                    customer.FirstName = reader["firstName"].ToString();
                    customer.LastName = reader["lastName"].ToString();
                    customer.Email = reader["email"].ToString();
                    customer.Phone = reader["phoneNumber"].ToString();
                    customer.DateOfBirth = reader["birthday"].ToString();
                    customer.Anniversary = reader["anniversary"].ToString();
                    customer.Status = int.Parse(reader["status"].ToString());
                    customers.Add(customer);
                }
                databaseConnection.Close();
            } 
            return (Customer[])customers.ToArray(typeof(Customer));
        }

        /// <summary> 
        /// Get customer by data by customer id
        /// </summary>
        public Customer GetCustomerById(int customerID)
        {
            Customer customer = null;
            string query = "SELECT * FROM customers WHERE `cID` = @customerID";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    customer = new Customer();
                    customer.CustomerId = int.Parse(reader["cID"].ToString());
                    customer.FirstName = reader["firstName"].ToString();
                    customer.LastName = reader["lastName"].ToString();
                    customer.Email = reader["email"].ToString();
                    customer.Phone = reader["phoneNumber"].ToString();
                    customer.DateOfBirth = reader["birthday"].ToString();
                    customer.Anniversary = reader["anniversary"].ToString();
                    customer.Status = int.Parse(reader["status"].ToString());
                }
                databaseConnection.Close();
            }
            return customer;
        }

        #endregion

        #region DataBase Functions **Order**(GetOrdersNumber ,

        /// <summary>
        /// Method to get order number
        /// </summary>
        /// <returns></returns>
        public int GetOrdersNumber()
        {
            int result = -1;

            string query = "SELECT COUNT(*) FROM orders ";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            try
            {
                databaseConnection.Open();
                result = int.Parse(cmd.ExecuteScalar().ToString());
                databaseConnection.Close();
            }
            catch { }

            return result;
        }

        //method to insert new order in to the data base
        public void InsertNewOrder(Order newOrder)
        {
            string query = "INSERT INTO orders(`orderID`,`tableID`, `customerID`, `orderDate`,  `isPaid`, `totalPrice` , `discount` , `employeeID`, `cancels`)  " +
                                      "VALUES (@orderID , @tableID, @customerID , @date, @isPaid, @totalPrice , @discount , @employeeID, @cancels)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@orderID", newOrder.OrderID);
            cmd.Parameters.AddWithValue("@tableID", newOrder.TableID);
            cmd.Parameters.AddWithValue("@customerID", newOrder.CustomerId);
            cmd.Parameters.AddWithValue("@date", newOrder.OrderDate);
            cmd.Parameters.AddWithValue("@isPaid", newOrder.IsPaid);
            cmd.Parameters.AddWithValue("@totalPrice", newOrder.TotalPrice);
            cmd.Parameters.AddWithValue("@discount", newOrder.Discount);
            cmd.Parameters.AddWithValue("@employeeID", newOrder.EmployeeID);
            cmd.Parameters.AddWithValue("@cancels", newOrder.Cancels);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Method to insert new line into lines in order
        /// </summary>
        /// <param name="newLine"></param>
        public void InsertLineInOrder(LinesInOrder newLine)
        {
            string query = "INSERT INTO lines_in_orders(`orderID`,`productID`, `productName`, `amount`, `totalPrice` , `notes`)  VALUES (@orderID , @productID , @productName, @amount, @totalPrice , @notes)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@orderID", newLine.OrderID);
            cmd.Parameters.AddWithValue("@productID", newLine.ProductID);
            cmd.Parameters.AddWithValue("@productName", newLine.ProductName);
            cmd.Parameters.AddWithValue("@amount", newLine.Amount);
            cmd.Parameters.AddWithValue("@totalPrice", newLine.TotalPrice);
            cmd.Parameters.AddWithValue("@notes", newLine.Notes);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        ///  Method to update  line in lines in order
        /// </summary>
        /// <param name="newLine"></param>
        public void UpdateLineInOrder(LinesInOrder newLine)
        {
            string query = "UPDATE `lines_in_orders` SET `productName`= @name , `amount`= @amount ,`totalPrice`= @totalPrice , `notes` = @notes WHERE `orderID` = @orderID AND `productID`= @productID ";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@name", newLine.ProductName);
            cmd.Parameters.AddWithValue("@amount", newLine.Amount);
            cmd.Parameters.AddWithValue("@totalPrice", newLine.TotalPrice);
            cmd.Parameters.AddWithValue("@orderID", newLine.OrderID);
            cmd.Parameters.AddWithValue("@productID", newLine.ProductID);
            cmd.Parameters.AddWithValue("@notes", newLine.Notes);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }


        /// <summary>
        /// Methos to update order info
        /// </summary>
        /// <param name="orderToUpdate"></param>
        public void UpdateOrder(Order orderToUpdate)
        {
            string query = "UPDATE `orders` SET `customerID` = @customerID , `isPaid`= @isPaid ,`totalPrice`= @totalPrice , `discount` = @discount, `cancels` = @cancels WHERE `orderID`= @orderID AND `tableID`= @tableID ";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@customerID", orderToUpdate.CustomerId);
            cmd.Parameters.AddWithValue("@isPaid", orderToUpdate.IsPaid);
            cmd.Parameters.AddWithValue("@totalPrice", orderToUpdate.TotalPrice);
            cmd.Parameters.AddWithValue("@discount", orderToUpdate.Discount);
            cmd.Parameters.AddWithValue("@orderID", orderToUpdate.OrderID);
            cmd.Parameters.AddWithValue("@tableID", orderToUpdate.TableID);
            cmd.Parameters.AddWithValue("@cancels", orderToUpdate.Cancels);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Methos to update order table  
        /// </summary>
        /// <param name="orderToUpdate"></param>
        public void UpdateOrderTable(Order orderToUpdate)
        {
            // string query = "UPDATE `orders` SET `amount`= @amount ,`totalPrice`= @totalPrice WHERE `orderID` = @orderID AND `productID`= @productID ";
            string query = "UPDATE `orders` SET `tableID`= @tableID  , `customerID` = @customerID , `isPaid`= @isPaid ,`totalPrice`= @totalPrice WHERE `orderID`= @orderID";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@tableID", orderToUpdate.TableID);
            cmd.Parameters.AddWithValue("@customerID", orderToUpdate.CustomerId);
            cmd.Parameters.AddWithValue("@isPaid", orderToUpdate.IsPaid);
            cmd.Parameters.AddWithValue("@totalPrice", orderToUpdate.TotalPrice);
            cmd.Parameters.AddWithValue("@orderID", orderToUpdate.OrderID);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Method to get order info by table id
        /// </summary>
        /// <param name="tabelID"></param>
        /// <returns></returns>
        public Order GetOrderByTableId(int tabelID)
        {
            Order order = null;
            string query = "SELECT * FROM orders WHERE `tableID` =@tableID AND `isPaid` =@isPaid";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@tableID", tabelID);
            cmd.Parameters.AddWithValue("@isPaid", 0);

            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    order = new Order();
                    order.OrderID = int.Parse(reader["orderID"].ToString());
                    order.TableID = int.Parse(reader["tableID"].ToString());
                    order.CustomerId = int.Parse(reader["customerID"].ToString());
                    order.OrderDate = DateTime.Parse(reader["orderDate"].ToString());
                    order.IsPaid = false;
                    order.TotalPrice = int.Parse(reader["totalPrice"].ToString());
                    order.Discount = int.Parse(reader["discount"].ToString());
                    order.EmployeeID = int.Parse(reader["employeeID"].ToString());
                    order.Cancels = reader["cancels"].ToString();
                }
                databaseConnection.Close();
            }
            return order;
        }

        /// <summary>
        /// Method to get all the lines of the current order
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public LinesInOrder[] GetLinesOfOrder(int orderID)
        {
            ArrayList lines = new ArrayList();
            string query = "SELECT * FROM lines_in_orders WHERE `orderID` = @orderID";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    LinesInOrder line = new LinesInOrder();
                    line.OrderID = orderID;
                    line.ProductID = int.Parse(reader["productID"].ToString());
                    line.ProductName = reader["productName"].ToString();
                    line.Amount = int.Parse(reader["amount"].ToString());
                    line.TotalPrice = int.Parse(reader["totalPrice"].ToString());
                    line.Notes = reader["notes"].ToString();
                    lines.Add(line);
                }
                databaseConnection.Close();
            }
            return (LinesInOrder[])lines.ToArray(typeof(LinesInOrder));
        }

        /// <summary>
        /// Method to get orders data between date
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public Order[] GetOrdersBetweenDates(string startDate, string endDate)
        {
            ArrayList orders = new ArrayList();
            string query = "SELECT * FROM orders WHERE `orderDate` BETWEEN @StartDate AND @EndDate";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);

            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Order order = new Order();
                    order.OrderID = int.Parse(reader["orderID"].ToString());
                    order.TableID = int.Parse(reader["tableID"].ToString());
                    order.CustomerId = int.Parse(reader["customerID"].ToString());
                    order.OrderDate = DateTime.Parse(reader["orderDate"].ToString());
                    order.IsPaid = bool.Parse(reader["isPaid"].ToString());
                    order.TotalPrice = int.Parse(reader["totalPrice"].ToString());
                    order.Discount = int.Parse(reader["discount"].ToString());
                    order.EmployeeID = int.Parse(reader["employeeID"].ToString());
                    order.Cancels = reader["cancels"].ToString();
                    orders.Add(order);
                }
                databaseConnection.Close();
            }
            return (Order[])orders.ToArray(typeof(Order));
        }

        /// <summary>
        /// method wich get orders by spcific details
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="startCustomerID"></param>
        /// <param name="endCustomerID"></param>
        /// <param name="startTableID"></param>
        /// <param name="endTableID"></param>
        /// <param name="startPrice"></param>
        /// <param name="endPrice"></param>
        /// <returns>array with the spcific orders</returns>
        public Order[] GetOrdersByParameters(string startDate, string endDate, int startCustomerID, int endCustomerID, int startTableID, int endTableID, int startPrice, int endPrice)
        {
            ArrayList orders = new ArrayList();
            string query = "SELECT * FROM `orders` " +
                "WHERE `orderDate` BETWEEN @StartDate AND @EndDate " +
                "AND `customerID` BETWEEN @StartCustomerID AND @EndCustomerID " +
                "AND `tableID` BETWEEN @StartTableID AND @EndTableID " +
                "AND `totalPrice` BETWEEN @StartPrice AND @EndPrice";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);
            cmd.Parameters.AddWithValue("@StartCustomerID", startCustomerID);
            cmd.Parameters.AddWithValue("@EndCustomerID", endCustomerID);
            cmd.Parameters.AddWithValue("@StartTableID", startTableID);
            cmd.Parameters.AddWithValue("@EndTableID", endTableID);
            cmd.Parameters.AddWithValue("@StartPrice", startPrice);
            cmd.Parameters.AddWithValue("@EndPrice", endPrice);

            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Order order = new Order();
                    order.OrderID = int.Parse(reader["orderID"].ToString());
                    order.TableID = int.Parse(reader["tableID"].ToString());
                    order.CustomerId = int.Parse(reader["customerID"].ToString());
                    order.OrderDate = DateTime.Parse(reader["orderDate"].ToString());
                    order.IsPaid = bool.Parse(reader["isPaid"].ToString());
                    order.TotalPrice = int.Parse(reader["totalPrice"].ToString());
                    order.Discount = int.Parse(reader["discount"].ToString());
                    order.EmployeeID = int.Parse(reader["employeeID"].ToString());
                    order.Cancels = reader["cancels"].ToString();
                    orders.Add(order);
                }
                databaseConnection.Close();
            }
            return (Order[])orders.ToArray(typeof(Order));
        }

        #endregion


        #region DataBase Functions **Stock**

        //method to insert new order in to the data base
        public void InsertNewProductToStock(Product newProduct , int i)
        {
            string query = "INSERT INTO stock(`productID`,`productName`, `quantity`, `department`)  VALUES (@productID , @productName, @quantity , @department)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@productID", newProduct.ProductID);
            cmd.Parameters.AddWithValue("@productName", newProduct.Name);
            cmd.Parameters.AddWithValue("@quantity", i);
            cmd.Parameters.AddWithValue("@department", newProduct.Department);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// method to insert new product to stock by data (Month)
        /// </summary>
        /// <param name="id">id of the new product to insert</param>
        /// <param name="amount">the amount to fill in the table</param>
        public void InsertNewProductToStockByDate(int id , double amount )
        {
            string query = "INSERT INTO `stockByDate`(`productID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`, `21`, `22`, `23`, `24`, `25`, `26`, `27`, `28`, `29`, `30`, `31`) VALUES " +
                "(@pid, @1 , @2 , @3 , @4, @5 , @6, @7 , @8, @9 , @10, @11 , @12, @13 , @14, @15 , @16, @17 , @18, @19 , @20, @21 , @22, @23 , @24, @25 , @26, @27 , @28, @29 , @30, @31 )";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@pid", id);
            cmd.Parameters.AddWithValue("@1", amount);
            cmd.Parameters.AddWithValue("@2", amount);
            cmd.Parameters.AddWithValue("@3", amount);
            cmd.Parameters.AddWithValue("@4", amount);
            cmd.Parameters.AddWithValue("@5", amount);
            cmd.Parameters.AddWithValue("@6", amount);
            cmd.Parameters.AddWithValue("@7", amount);
            cmd.Parameters.AddWithValue("@8", amount);
            cmd.Parameters.AddWithValue("@9", amount);
            cmd.Parameters.AddWithValue("@10", amount);
            cmd.Parameters.AddWithValue("@11", amount);
            cmd.Parameters.AddWithValue("@12", amount);
            cmd.Parameters.AddWithValue("@13", amount);
            cmd.Parameters.AddWithValue("@14", amount);
            cmd.Parameters.AddWithValue("@15", amount);
            cmd.Parameters.AddWithValue("@16", amount);
            cmd.Parameters.AddWithValue("@17", amount);
            cmd.Parameters.AddWithValue("@18", amount);
            cmd.Parameters.AddWithValue("@19", amount);
            cmd.Parameters.AddWithValue("@20", amount);
            cmd.Parameters.AddWithValue("@21", amount);
            cmd.Parameters.AddWithValue("@22", amount);
            cmd.Parameters.AddWithValue("@23", amount);
            cmd.Parameters.AddWithValue("@24", amount);
            cmd.Parameters.AddWithValue("@25", amount);
            cmd.Parameters.AddWithValue("@26", amount);
            cmd.Parameters.AddWithValue("@27", amount);
            cmd.Parameters.AddWithValue("@28", amount);
            cmd.Parameters.AddWithValue("@29", amount);
            cmd.Parameters.AddWithValue("@30", amount);
            cmd.Parameters.AddWithValue("@31", amount);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// method to insert new product to stock by year
        /// </summary>
        /// <param name="id">the id of the new product to insert</param>
        /// <param name="amount">the amount to fill in the table</param>
        /// <param name="month">the current month to fill</param>
        /// <param name="year">the current year to fill</param>
        public void InsertNewProductToStockByYear(int id, double amount , int month , int year)
        {
            string query = "INSERT INTO `stockByYear`(`productID`, `currentMonth` , `currentYear` , `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`) VALUES " +
                "(@pid,@month,@year, @1 , @2 , @3 , @4, @5 , @6, @7 , @8, @9 , @10, @11 , @12)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@pid", id);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@1", amount);
            cmd.Parameters.AddWithValue("@2", amount);
            cmd.Parameters.AddWithValue("@3", amount);
            cmd.Parameters.AddWithValue("@4", amount);
            cmd.Parameters.AddWithValue("@5", amount);
            cmd.Parameters.AddWithValue("@6", amount);
            cmd.Parameters.AddWithValue("@7", amount);
            cmd.Parameters.AddWithValue("@8", amount);
            cmd.Parameters.AddWithValue("@9", amount);
            cmd.Parameters.AddWithValue("@10", amount);
            cmd.Parameters.AddWithValue("@11", amount);
            cmd.Parameters.AddWithValue("@12", amount);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// method to rest the table of the stock by month when its new month
        /// </summary>
        public void ResetStockByDate()
        {
            string query = "UPDATE `stockByDate` SET  `1`= @1,`2` = @2,`3` = @3,`4` = @4,`5` = @5,`6` = @6,`7` = @7,`8` = @8,`9` = @9,`10` = @10,`11` = @11,`12` = @12,`13` = @13,`14` = @14,`15` = @15,`16` = @16,`17` = @17,`18` = @18,`19` = @19,`20` = @20,`21` = @21,`22` = @22,`23` = @23,`24` = @24,`25` = @25,`26` = @26,`27` = @27,`28` = @28,`29` = @29,`30` = @30,`31` = @31  WHERE `productID` > 1";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@1", 0);
            cmd.Parameters.AddWithValue("@2", 0);
            cmd.Parameters.AddWithValue("@3", 0);
            cmd.Parameters.AddWithValue("@4", 0);
            cmd.Parameters.AddWithValue("@5", 0);
            cmd.Parameters.AddWithValue("@6", 0);
            cmd.Parameters.AddWithValue("@7", 0);
            cmd.Parameters.AddWithValue("@8", 0);
            cmd.Parameters.AddWithValue("@9", 0);
            cmd.Parameters.AddWithValue("@10", 0);
            cmd.Parameters.AddWithValue("@11", 0);
            cmd.Parameters.AddWithValue("@12", 0);
            cmd.Parameters.AddWithValue("@13", 0);
            cmd.Parameters.AddWithValue("@14", 0);
            cmd.Parameters.AddWithValue("@15", 0);
            cmd.Parameters.AddWithValue("@16", 0);
            cmd.Parameters.AddWithValue("@17", 0);
            cmd.Parameters.AddWithValue("@18", 0);
            cmd.Parameters.AddWithValue("@19", 0);
            cmd.Parameters.AddWithValue("@20", 0);
            cmd.Parameters.AddWithValue("@21", 0);
            cmd.Parameters.AddWithValue("@22", 0);
            cmd.Parameters.AddWithValue("@23", 0);
            cmd.Parameters.AddWithValue("@24", 0);
            cmd.Parameters.AddWithValue("@25", 0);
            cmd.Parameters.AddWithValue("@26", 0);
            cmd.Parameters.AddWithValue("@27", 0);
            cmd.Parameters.AddWithValue("@28", 0);
            cmd.Parameters.AddWithValue("@29", 0);
            cmd.Parameters.AddWithValue("@30", 0);
            cmd.Parameters.AddWithValue("@31", 0);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// method to update spcific product in stock by month table
        /// </summary>
        /// <param name="numberOfDay">the spcific day in month</param>
        /// <param name="amount">the amount to add to stock</param>
        /// <param name="productID">the product to updtae</param>
        public void UpdateProductInStockByDate( string numberOfDay , double amount ,int productID )
        {
            string query = "UPDATE `stockByDate` SET `" + numberOfDay + "` = `" + numberOfDay + "` + @amount  WHERE `productID`= @productID ";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@productID", productID);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// method wich get the amount of product orders in spcific day
        /// </summary>
        /// <param name="productId">the product to get it amount</param>
        /// <param name="day">the day in month to get the amount</param>
        /// <returns>int - the amount of orders in spcific day</returns>
        public int GetDayStockAmount(int productId, int day)
        {
            int amount = 0;
            string query = "SELECT `" + day + "` FROM `stockByDate` WHERE `productID` = @productId";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@productId", productId);
            try
            {
                databaseConnection.Open();
                amount = int.Parse(cmd.ExecuteScalar().ToString());
                databaseConnection.Close();
            }
            catch { }
            return amount;
        }

        /// <summary>
        /// method to get the amount of product orders in the current month
        /// </summary>
        /// <param name="productId">the product to get it orders amount</param>
        /// <returns> int - the amount of orders of product in month</returns>
        public int GetMonthStockAmount(int productId)
        {
            int amount = 0;
            string query = "SELECT SUM(`1`+`2`+`3`+`4`+`5`+`6`+`7`+`8`+`9`+`10`+`11`+`12`+`13`+`14`+`15`+`16`+`17`+`18`+`19`+`20`+`21`+`22`+`23`+`24`+`25`+`26`+`27`+`28`+`29`+`30`+`31`) " +
                "FROM `stockByDate` WHERE `productID` = @productId";

            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@productId", productId);
            try
            {
                databaseConnection.Open();
                amount = int.Parse(cmd.ExecuteScalar().ToString());
                databaseConnection.Close();
            }
            catch { }
            return amount;
        }

        /// <summary>
        /// method wich get stock data by spcific query 
        /// </summary>
        /// <param name="query">the query with the spcific days and parameters</param>
        /// <returns>stock array with the product data and the total of orders</returns>
        public Stock[] GetStockDataBy(string query )
        {
            ArrayList stocks = new ArrayList();
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Stock stock = new Stock();
                    stock.ProductID = int.Parse(reader["productID"].ToString());
                    stock.Name = reader["name"].ToString();
                    stock.TotalAmount = double.Parse(reader["total"].ToString());
                    stocks.Add(stock);
                }
                databaseConnection.Close();
            }
            return (Stock[])stocks.ToArray(typeof(Stock));
        }

        /// <summary>
        /// method wich get the current month from the year stock table
        /// </summary>
        /// <returns>int month - the number of the current month</returns>
        public int GetCurrentMonth()
        {
            int month = 0;
            string query = "SELECT `currentMonth` FROM `stockByYear` WHERE 1 LIMIT 1";

            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            try
            {
                databaseConnection.Open();
                month = int.Parse(cmd.ExecuteScalar().ToString());
                databaseConnection.Close();
            }
            catch { }
            return month;
        }

        /// <summary>
        /// method wich reset the stock table of the last year and update the year column to the new year
        /// </summary>
        /// <param name="year">the new year to update the year column</param>
        public void ResetStockByYear(int year)
        {
            string query = "UPDATE `stockByYear` SET `currentMonth` = @currentMonth , `currentYear` = @currentYear ,`1`= @1,`2` = @2,`3` = @3,`4` = @4,`5` = @5,`6` = @6,`7` = @7,`8` = @8,`9` = @9,`10` = @10,`11` = @11,`12` = @12 WHERE `productID` > 1";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@currentMonth", 1);
            cmd.Parameters.AddWithValue("@currentYear", year);
            cmd.Parameters.AddWithValue("@1", 0);
            cmd.Parameters.AddWithValue("@2", 0);
            cmd.Parameters.AddWithValue("@3", 0);
            cmd.Parameters.AddWithValue("@4", 0);
            cmd.Parameters.AddWithValue("@5", 0);
            cmd.Parameters.AddWithValue("@6", 0);
            cmd.Parameters.AddWithValue("@7", 0);
            cmd.Parameters.AddWithValue("@8", 0);
            cmd.Parameters.AddWithValue("@9", 0);
            cmd.Parameters.AddWithValue("@10", 0);
            cmd.Parameters.AddWithValue("@11", 0);
            cmd.Parameters.AddWithValue("@12", 0);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// method wich update product row in the stock by year table when month passed
        /// </summary>
        /// <param name="num">the number of the month to update</param>
        /// <param name="amount">amount of the product</param>
        /// <param name="productID">the spicifc product to update </param>
        /// <param name="currentMonth">update the cureent month to the next month</param>
        public void UpdateProductInStockByYear(string num, double amount, int productID, int currentMonth)
        {
            string query = "UPDATE `stockByYear` SET  `currentMonth` = @currentMonth , `" + num + "` = `" + num + "` + @amount  WHERE `productID`= @productID ";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@currentMonth", currentMonth);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@productID", productID);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }


        /// <summary>
        /// method wich get the current year from the year stock table
        /// </summary>int year - the current year</returns>
        public int GetCurrentyYear()
        {
            int year = 0;
            string query = "SELECT `currentYear` FROM `stockByYear` WHERE 1 LIMIT 1";

            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            try
            {
                databaseConnection.Open();
                year = int.Parse(cmd.ExecuteScalar().ToString());
                databaseConnection.Close();
            }
            catch { }
            return year;
        }

        #endregion


        #region DataBase Functions **Event**

        /// <summary>
        /// method to insert new event to the data base
        /// </summary>
        /// <param name="newEvent">the event details to insert</param>
        public void InsertNewEvent(Event newEvent)
        {
            string query = "INSERT INTO events(`eventID`, `type`, `date`, `time`, `numOfParticipants`,  `ownerFname`, `ownerLname`, `ownerPhone`, `ownerMail`, `notes`)  " +
                "VALUES (@eventID, @type , @date, @time , @numOfParticipants, @ownerFname, @ownerLname, @ownerPhone, @ownerMail, @notes)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@eventID", null);
            cmd.Parameters.AddWithValue("@type", newEvent.EventType);
            cmd.Parameters.AddWithValue("@date", newEvent.EventDate);
            cmd.Parameters.AddWithValue("@time", newEvent.EventTime);
            cmd.Parameters.AddWithValue("@numOfParticipants", newEvent.NumOfParticipants);
            cmd.Parameters.AddWithValue("@ownerFname", newEvent.OwnerFname);
            cmd.Parameters.AddWithValue("@ownerLname", newEvent.OwnerLname);
            cmd.Parameters.AddWithValue("@ownerPhone", newEvent.OwnerPhone);
            cmd.Parameters.AddWithValue("@ownerMail", newEvent.OwnerEmail);
            cmd.Parameters.AddWithValue("@notes", newEvent.EventNotes);

            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// method wich update exists event details
        /// </summary>
        /// <param name="newEvent">the event with the new details to update</param>
        public void UpdateEvent(Event newEvent)
        {
            string query = "UPDATE `events` SET `type`= @type,`date`= @date,`time`= @time,`numOfParticipants`= @numOfParticipants,`ownerFname`= @ownerFname,`ownerLname`= @ownerLname,`ownerPhone`= @ownerPhone,`ownerMail`= @ownerMail,`notes`= @notes WHERE `eventID`= @eventID";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@eventID", newEvent.EventId);
            cmd.Parameters.AddWithValue("@type", newEvent.EventType);
            cmd.Parameters.AddWithValue("@date", newEvent.EventDate);
            cmd.Parameters.AddWithValue("@time", newEvent.EventTime);
            cmd.Parameters.AddWithValue("@numOfParticipants", newEvent.NumOfParticipants);
            cmd.Parameters.AddWithValue("@ownerFname", newEvent.OwnerFname);
            cmd.Parameters.AddWithValue("@ownerLname", newEvent.OwnerLname);
            cmd.Parameters.AddWithValue("@ownerPhone", newEvent.OwnerPhone);
            cmd.Parameters.AddWithValue("@ownerMail", newEvent.OwnerEmail);
            cmd.Parameters.AddWithValue("@notes", newEvent.EventNotes);

            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// method to get events data by date
        /// </summary>
        /// <param name="date">the date string to get the events data</param>
        /// <returns>array with events details from the spcific datae</returns>
        public Event[] GetEventsDataByDate(string date)
        {
            ArrayList events = new ArrayList();
            string query = "SELECT * FROM events WHERE `date` = @date ORDER BY `time`";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@date", date);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    Event event_ = new Event();
                    event_.EventId = int.Parse(reader["eventID"].ToString());
                    event_.EventType = reader["type"].ToString();
                    event_.EventDate = DateTime.Parse(reader["date"].ToString());
                    event_.EventTime = DateTime.Parse(reader["time"].ToString());
                    event_.NumOfParticipants = int.Parse(reader["numOfParticipants"].ToString());
                    event_.OwnerFname = reader["ownerFname"].ToString();
                    event_.OwnerLname = reader["ownerLname"].ToString();
                    event_.OwnerPhone = reader["ownerPhone"].ToString();
                    event_.OwnerEmail = reader["ownerMail"].ToString();
                    event_.EventNotes = reader["notes"].ToString();
                    events.Add(event_);
                }
                databaseConnection.Close();
            }
            return (Event[])events.ToArray(typeof(Event));
        }
        #endregion

        /// <summary>
        /// method to remove line from spcific order
        /// </summary>
        /// <param name="orderId">the id of the order to remove the line from</param>
        /// <param name="productId">the id of the line to remove </param>
        public void RemoveLineOfOrder(int orderId, int productId)
        {
            string query = "DELETE FROM `lines_in_orders` WHERE `orderID` = @orderId AND `productID` = @productId";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            cmd.Parameters.AddWithValue("@productId", productId);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Method to insert new cancel into cancellations in orders
        /// </summary>
        /// <param name="newLine"></param>
        public void InsertCancelOfOrder(CancellationsInOrder newCancle)
        {
            string query = "INSERT INTO cancellationsInOrders(`cancleID`,`orderID`, `productID`, `productName`, `priceToSub`)  VALUES (@cancleID , @orderID , @productID, @productName, @priceToSub)";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@cancleID", null);//null for auto increment
            cmd.Parameters.AddWithValue("@orderID", newCancle.OrderId);
            cmd.Parameters.AddWithValue("@productID", newCancle.ProductId);
            cmd.Parameters.AddWithValue("@productName", newCancle.ProductName);
            cmd.Parameters.AddWithValue("@priceToSub", newCancle.PriceToSub);
            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch { }
        }

        /// <summary>
        /// Method to get all the cancels of the givin order
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public CancellationsInOrder[] GetCancelsOfOrder(int orderID)
        {
            ArrayList cancels = new ArrayList();
            string query = "SELECT * FROM cancellationsInOrders WHERE `orderID` = @orderID";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            databaseConnection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    CancellationsInOrder cancel = new CancellationsInOrder();
                    cancel.CancleId = int.Parse(reader["cancleID"].ToString());
                    cancel.OrderId = orderID;
                    cancel.ProductId = int.Parse(reader["productID"].ToString());
                    cancel.ProductName = reader["productName"].ToString();
                    cancel.PriceToSub = int.Parse(reader["priceToSub"].ToString());
                    cancels.Add(cancel);
                }
                databaseConnection.Close();
            }
            return (CancellationsInOrder[])cancels.ToArray(typeof(CancellationsInOrder));
        }

    }
}

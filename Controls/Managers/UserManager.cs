using Newtonsoft.Json;
using Optimum_Tech.Model;
using Optimum_Tech.Models;
using Optimum_Tech.Views.Resources;
using OptimumTech.Controls;

namespace Optimum_Tech.Controls.Managers
{
    internal static class UserManager
    {
        private static readonly string usersFilePath = @"..\..\Repository\users.json";
        private static readonly string ordersFilePath = @"..\..\Repository\orders.json";
        public static List<User> users = new List<User>();
        public static List<Order> orders = new List<Order>();
        public static User? currentUser;

        public static void UpdateStatus(TextBox textBoxStatus)
        {
            textBoxStatus.ForeColor = Color.White;
            textBoxStatus.Text = $"Logged as: {currentUser.Login}";
        }
        public static void LoginAsGuest()
        {
            string json = File.ReadAllText(usersFilePath);
            List<User>? users = JsonConvert.DeserializeObject<List<User>>(json);
            User? guestUser = users.FirstOrDefault(u => u.Access == Access.Guest);
            currentUser = guestUser;
        }
        public static bool Login(TextBox textBoxLogin, TextBox textBoxPassword)
        {
            try
            {
                string login = textBoxLogin.Text;
                string password = textBoxPassword.Text;

                using (StreamReader r = new StreamReader(usersFilePath))
                {
                    string json = r.ReadToEnd();
                    User[] users = JsonConvert.DeserializeObject<User[]>(json);

                    foreach (User user in users)
                    {
                        if (user.CompareTo(new User(login, password)) == 0 && user.Password == password)
                        {
                            currentUser = user;
                            return true;
                        }
                    }
                    MessageBox.Show("There is no account with that login data");
                    textBoxLogin.Text = "Login";
                    textBoxPassword.Text = "Password";
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login: " + ex.Message);
                return false;
            }
        }
        public static bool Login(string login, string password)
        {
            try
            {
                using (StreamReader r = new StreamReader(usersFilePath))
                {
                    string json = r.ReadToEnd();
                    User[] users = JsonConvert.DeserializeObject<User[]>(json);

                    foreach (User user in users)
                    {
                        if (user.CompareTo(new User(login, password)) == 0 && user.Password == password)
                        {
                            currentUser = user;
                            return true;
                        }
                    }
                    MessageBox.Show("There is no account with that login data");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login: " + ex.Message);
                return false;
            }
        }
        public static bool Register(string login, string password)
        {
            try
            {
                if (!IsLoginUnique(login))
                {
                    MessageBox.Show("Login already exists");
                    return false;
                }

                if (string.IsNullOrEmpty(usersFilePath))
                {
                    MessageBox.Show("Invalid file path");
                    return false;
                }

                string json = File.ReadAllText(usersFilePath);
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

                User newUser = new User(login, password);
                users.Add(newUser);

                string newJson = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(usersFilePath, newJson);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during registration: " + ex.Message);
                return false;
            }
        }

        public static List<User> LoadUsers()
        {
            string json = File.ReadAllText(usersFilePath);
            users = JsonConvert.DeserializeObject<List<User>>(json);

            return users;
        }
        internal static void SaveUsers()
        {
            List<User> usersToSave = users.ToList();
            string json = JsonConvert.SerializeObject(usersToSave, Formatting.Indented);
            File.WriteAllText(usersFilePath, json);
        }

        public static void AddToFavorites(ProductControl control)
        {
            if (currentUser.Favorites == null)
            {
                currentUser.Favorites = new List<ProductControl>();
            }

            if (currentUser.Favorites.Any(p => p.ProductName == control.ProductName))
            {
                // Product already exists in favorites list, remove it first
                currentUser.Favorites.RemoveAll(p => p.ProductName == control.ProductName);
                MessageBox.Show("Its already in favorites list");
                control.pictureBoxFavorite.Image = FormsMedia.favorite_empty;
            }

            currentUser.Favorites.Add(control);

            List<User> users = LoadUsers();
            int index = users.FindIndex(u => u.Login == currentUser.Login);
            users[index] = currentUser;
        }
        public static void RemoveFromFavorites(ProductControl control)
        {
            if (currentUser.Favorites == null)
            {
                return;
            }
            currentUser.Favorites.Remove(control);

            List<User> users = LoadUsers();
            int index = users.FindIndex(u => u.Login == currentUser.Login);
            users[index] = currentUser;
        }
        public static void AddToSelections(ProductControl control)
        {
            if (currentUser.Selections == null)
            {
                currentUser.Selections = new List<ProductControl>();
            }

            if (currentUser.Selections.Any(p => p.ProductName == control.ProductName))
            {
                // Product already exists in selections list, remove it first
                currentUser.Selections.RemoveAll(p => p.ProductName == control.ProductName);
                MessageBox.Show("Its already in selections list");
                control.pictureBoxCart.Image = FormsMedia.basket_empty;
            }

            currentUser.Selections.Add(control);

            List<User> users = LoadUsers();
            int index = users.FindIndex(u => u.Login == currentUser.Login);
            users[index] = currentUser;
        }
        public static void RemoveFromSelections(ProductControl control)
        {
            if (currentUser.Selections == null)
            {
                return;
            }
            currentUser.Selections.Remove(control);

            List<User> users = LoadUsers();
            int index = users.FindIndex(u => u.Login == currentUser.Login);
            users[index] = currentUser;
        }

        public static bool IsLoginUnique(string login)
        {
            string json = File.ReadAllText(usersFilePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

            foreach (User user in users)
            {
                if (user.Login == login)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

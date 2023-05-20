using Newtonsoft.Json;
using Optimum_Tech.Model;
using Optimum_Tech.Models;
using Optimum_Tech.Views.Resources;
using OptimumTech.Controls;

namespace Optimum_Tech.Controls.Managers
{
    public static class UserManager
    {
        public static readonly string usersFilePath = @"D:\Education\Projects\Coursework-(.Net)\OptimumTech\Repository\users.json";
        public static List<User> Users = new List<User>();
        public static User? CurrentUser;

        public static void UpdateStatus(TextBox textBoxStatus)
        {
            textBoxStatus.ForeColor = Color.White;
            textBoxStatus.Text = $"Logged as: {CurrentUser.Login}";
        }
        public static void LoginAsGuest()
        {
            string json = File.ReadAllText(usersFilePath);
            List<User>? users = JsonConvert.DeserializeObject<List<User>>(json);
            User? guestUser = users.FirstOrDefault(u => u.Access == Access.Guest);
            CurrentUser = guestUser;
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
                            CurrentUser = user;
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
                            CurrentUser = user;
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
            Users = JsonConvert.DeserializeObject<List<User>>(json);

            return Users;
        }
        internal static void SaveUsers()
        {
            List<User> usersToSave = Users.ToList();
            string json = JsonConvert.SerializeObject(usersToSave, Formatting.Indented);
            File.WriteAllText(usersFilePath, json);
        }

        public static void AddToFavorites(ProductControl control)
        {
            if (CurrentUser.Favorites == null)
            {
                CurrentUser.Favorites = new List<ProductControl>();
            }

            if (CurrentUser.Favorites.Any(p => p.ProductName == control.ProductName))
            {
                CurrentUser.Favorites.RemoveAll(p => p.ProductName == control.ProductName);
                MessageBox.Show("Its already in favorites list");
                control.pictureBoxFavorite.Image = FormsMedia.favorite_empty;
            }

            CurrentUser.Favorites.Add(control);

            List<User> users = LoadUsers();
            int index = users.FindIndex(u => u.Login == CurrentUser.Login);
            users[index] = CurrentUser;
        }
        public static void RemoveFromFavorites(ProductControl control)
        {
            if (CurrentUser.Favorites == null)
            {
                return;
            }
            CurrentUser.Favorites.Remove(control);

            List<User> users = LoadUsers();
            int index = users.FindIndex(u => u.Login == CurrentUser.Login);
            users[index] = CurrentUser;
        }
        public static void AddToSelections(ProductControl control)
        {
            if (CurrentUser.Selections == null)
            {
                CurrentUser.Selections = new List<ProductControl>();
            }

            if (CurrentUser.Selections.Any(p => p.ProductName == control.ProductName))
            {
                CurrentUser.Selections.RemoveAll(p => p.ProductName == control.ProductName);
                MessageBox.Show("Its already in selections list");
                control.pictureBoxCart.Image = FormsMedia.basket_empty;
            }

            CurrentUser.Selections.Add(control);

            List<User> users = LoadUsers();
            int index = users.FindIndex(u => u.Login == CurrentUser.Login);
            users[index] = CurrentUser;
        }
        public static void RemoveFromSelections(ProductControl control)
        {
            if (CurrentUser.Selections == null)
            {
                return;
            }
            CurrentUser.Selections.Remove(control);

            List<User> users = LoadUsers();
            int index = users.FindIndex(u => u.Login == CurrentUser.Login);
            users[index] = CurrentUser;
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

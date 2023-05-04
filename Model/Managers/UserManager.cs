using Newtonsoft.Json;
using Optimum_Tech.Model.Products;
using OptimumTech.Controls;

namespace Optimum_Tech.Model.Managers
{
    internal static class UserManager
    {
        private static readonly string usersFilePath = @"..\..\Repository\users.json";
        public static List<User> users = new List<User>();
        public static User? currentUser;

        public static bool Login(TextBox textBoxLogin, TextBox textBoxPassword)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            using (StreamReader r = new StreamReader(usersFilePath))
            {
                User[] users = JsonConvert.DeserializeObject<User[]>(r.ReadToEnd());

                foreach (User user in users)
                {
                    if (user.Login == login && user.Password == password)
                    {
                        currentUser = user;
                        return true;
                    }
                }
                return false;
            }
        }
        public static bool Register(string login, string password)
        {
            if (!IsLoginUnique(login))
            {
                MessageBox.Show("Login already exists");
                return false;
            }

            string json = File.ReadAllText(usersFilePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

            User newUser = new User(login, password);
            newUser.Access = Access.User;
            users.Add(newUser);

            string newJson = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(usersFilePath, newJson);

            return true;
        }
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

        public static List<User> LoadUsers()
        {
            string json = File.ReadAllText(usersFilePath);
            users = JsonConvert.DeserializeObject<List<User>>(json);

            return users;
        }
        public static void SaveUsers()
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(usersFilePath, json);
        }

        public static void AddToFavorites(ProductControl control)
        {
            if (currentUser.Favorites == null)
            {
                currentUser.Favorites = new List<ProductControl>();
            }

            if (!currentUser.Favorites.Contains(control))
            {
                currentUser.Favorites.Add(control);

                int index = users.FindIndex(u => u.Login == currentUser.Login);
                users[index] = currentUser;

                SaveUsers();
            }
        }
        public static void RemoveFromFavorites(ProductControl control)
        {
            if (currentUser.Favorites == null)
            {
                return;
            }
            currentUser.Favorites.Remove(control);

            int index = users.FindIndex(u => u.Login == currentUser.Login);
            users[index] = currentUser;

            SaveUsers();
        }

        public static void AddToSelections(ProductControl control)
        {
            if (currentUser.Selections == null)
            {
                currentUser.Selections = new List<ProductControl>();
            }

            if (!currentUser.Selections.Contains(control))
            {
                currentUser.Selections.Add(control);

                int index = users.FindIndex(u => u.Login == currentUser.Login);
                users[index] = currentUser;

                SaveUsers();
            }
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

            SaveUsers();
        }

        public static bool IsLoginUnique(string login)
        {
            string json = File.ReadAllText(usersFilePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

            return !users.Any(u => u.Login == login);
        }
    }
}

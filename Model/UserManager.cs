using Newtonsoft.Json;
using OptimumTech.Controls;

namespace Optimum_Tech.Model
{
    internal static class UserManager
    {
        private static string usersFilePath = "D:\\Downloads\\OptimumTech\\Repository\\users.json";
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

        public static List<User> LoadUsers()
        {
            if (!File.Exists(usersFilePath))
            {
                return new List<User>();
            }

            string json = File.ReadAllText(usersFilePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

            return users;
        }
        public static bool IsLoginUnique(string login)
        {
            string json = File.ReadAllText(usersFilePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

            return !users.Any(u => u.Login == login);
        }


        public static void AddToFavorites(ProductControl control)
        {
            if (UserManager.currentUser.Favorites == null)
            {
                UserManager.currentUser.Favorites = new List<ProductControl>();
            }

            if (!UserManager.currentUser.Favorites.Contains(control))
            {
                UserManager.currentUser.Favorites.Add(control);

                List<User> users = LoadUsers();
                int index = users.FindIndex(u => u.Login == UserManager.currentUser.Login);
                users[index] = UserManager.currentUser;
            }
        }
        public static void RemoveFromFavorites(ProductControl control)
        {
            if (UserManager.currentUser.Favorites == null)
            {
                return;
            }
            UserManager.currentUser.Favorites.Remove(control);

            List<User> users = LoadUsers();
            int index = users.FindIndex(u => u.Login == UserManager.currentUser.Login);
            users[index] = UserManager.currentUser;
        }

        public static void AddToSelections(ProductControl control)
        {
            if (UserManager.currentUser.Selections == null)
            {
                UserManager.currentUser.Selections = new List<ProductControl>();
            }

            if (!UserManager.currentUser.Selections.Contains(control))
            {
                UserManager.currentUser.Selections.Add(control);

                List<User> users = LoadUsers();
                int index = users.FindIndex(u => u.Login == UserManager.currentUser.Login);
                users[index] = UserManager.currentUser;
            }
        }
        public static void RemoveFromSelections(ProductControl control)
        {
            if (UserManager.currentUser.Selections == null)
            {
                return;
            }
            UserManager.currentUser.Selections.Remove(control);

            List<User> users = LoadUsers();
            int index = users.FindIndex(u => u.Login == UserManager.currentUser.Login);
            users[index] = UserManager.currentUser;
        }
    }
}

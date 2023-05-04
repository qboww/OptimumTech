using Newtonsoft.Json;
using OptimumTech.Controls;

namespace Optimum_Tech.Model
{
    internal static class UserManager
    {
        private static string usersFilePath = @"..\..\Repository\users.json";
        public static User? currentUser = null;

        public static void UpdateStatus(TextBox textBoxStatus)
        {
            if (currentUser != null)
            {
                textBoxStatus.ForeColor = Color.White;
                textBoxStatus.Text = $"Logged as: {currentUser.Login}";
            }
        }

        public static void LoginAsGuest()
        {
            if (File.Exists(usersFilePath))
            {
                string json = File.ReadAllText(usersFilePath);
                List<User>? users = JsonConvert.DeserializeObject<List<User>>(json);
                User? guestUser = users?.FirstOrDefault(u => u.Access == Access.Guest);
                currentUser = guestUser;
            }
        }

        public static bool Login(TextBox textBoxLogin, TextBox textBoxPassword)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (File.Exists(usersFilePath))
            {
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
            else
            {
                MessageBox.Show("User file not found");
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

            if (File.Exists(usersFilePath))
            {
                string json = File.ReadAllText(usersFilePath);
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();

                User newUser = new User(login, password);
                newUser.Access = Access.User;
                users.Add(newUser);

                string newJson = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(usersFilePath, newJson);

                return true;
            }
            else
            {
                MessageBox.Show("User file not found");
                return false;
            }
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
            if (currentUser == null) return;

            currentUser.Favorites ??= new List<ProductControl>();

            if (!currentUser.Favorites.Contains(control))
            {
                currentUser.Favorites.Add(control);
            }

            List<User> users = LoadUsers();
            int index = users.FindIndex(u => u.Login == currentUser.Login);
            users[index] = currentUser;
        }

        public static void RemoveFromFavorites(ProductControl control)
        {
            currentUser?.Favorites?.Remove(control);

            List<User> users = LoadUsers();
            int index = users.FindIndex(u => u.Login == currentUser?.Login);
            if (index != -1)
            {
                users[index].Favorites = currentUser?.Favorites;
            }

            string newJson = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(usersFilePath, newJson);
        }

        public static void AddToSelections(ProductControl control)
        {
            if (currentUser == null) return;

            currentUser.Selections ??= new List<ProductControl>();

            if (!currentUser.Selections.Contains(control))
            {
                currentUser.Selections.Add(control);
            }

            List<User> users = LoadUsers();
            int index = users.FindIndex(u => u.Login == currentUser.Login);
            users[index] = currentUser;
        }

        public static void RemoveFromSelections(ProductControl control)
        {
            currentUser?.Selections?.Remove(control);

            List<User> users = LoadUsers();
            int index = users.FindIndex(u => u.Login == currentUser?.Login);
            if (index != -1)
            {
                users[index].Selections = currentUser?.Selections;
            }

            string newJson = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(usersFilePath, newJson);
        }
    }
}
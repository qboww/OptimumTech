using Newtonsoft.Json;

namespace Optimum_Tech.Model
{
    internal static class UserManager
    {
        public static User? currentUser;

        public static void UpdateStatus(TextBox textBoxStatus) => textBoxStatus.Text = $"Logged as: {currentUser.Login}";

        public static void LoginAsGuest()
        {
            string json = File.ReadAllText("D:\\Downloads\\OptimumTech\\Model\\UsersData\\users.json");
            List<User>? users = JsonConvert.DeserializeObject<List<User>>(json);
            User? guestUser = users.FirstOrDefault(u => u.Access == Status.Guest);
            currentUser = guestUser;
        }

        public static void LoginAsAdmin()
        {
            string json = File.ReadAllText("D:\\Downloads\\OptimumTech\\Model\\UsersData\\users.json");
            List<User>? users = JsonConvert.DeserializeObject<List<User>>(json);
            User? adminUser = users.FirstOrDefault(u => u.Access == Status.Admin);
            currentUser = adminUser;
        }

        public static bool Login(TextBox textBoxLogin, TextBox textBoxPassword)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            using (StreamReader r = new StreamReader("D:\\Downloads\\OptimumTech\\Model\\UsersData\\users.json"))
            {
                User[] users = JsonConvert.DeserializeObject<User[]>(r.ReadToEnd());

                foreach (User user in users)
                {
                    if (user.Login == login && user.Password == password)
                    {
                        UserManager.currentUser = user;
                        return true;
                    }
                }
                return false;
            }
        }

        public static bool Register(string login, string password)
        {
            string json = File.ReadAllText("D:\\Downloads\\OptimumTech\\Model\\UsersData\\users.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

            if (users.Any(u => u.Login == login))
            {
                throw new Exception("Login already exists");
            }

            User newUser = new User(login, password);
            newUser.Access = Status.User;
            users.Add(newUser);

            string newJson = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText("D:\\Downloads\\OptimumTech\\Model\\UsersData\\users.json", newJson);

            return true;
        }

    }
}
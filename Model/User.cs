using Optimum_Tech.Model.Interfaces;
using OptimumTech.Controls;

namespace Optimum_Tech.Model
{
    internal class User: IAccess, IDisposable
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Access Access { get; set; }

        public List<ProductControl> Favorites = new List<ProductControl>();
        public List<ProductControl> Selections = new List<ProductControl>();

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public void GrantAccessUser()
        {
            UserManager.currentUser.GrantAccessUser();
        }
        public void GrantAccessGuest()
        {
            UserManager.currentUser.GrantAccessGuest();
        }
        public void GrantAccessAdmin()
        {
            UserManager.currentUser.GrantAccessAdmin();
        }


        private bool _disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~User()
        {
            Dispose(false);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {

                }
                _disposed = true;
            }
        }
    }

    enum Access
    {
        Admin, Guest, User
    }
}

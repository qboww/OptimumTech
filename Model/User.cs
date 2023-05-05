using Optimum_Tech.Model.Interfaces;
using Optimum_Tech.Model.Managers;
using OptimumTech.Controls;
using System;
using System.Text.Json.Serialization;

namespace Optimum_Tech.Model
{
    internal class User : IAccess, IDisposable, IComparable<User>
    {
        private const int MaxLoginLength = 30;
        private const int MaxPasswordLength = 15;

        private string login;
        private string password;

        public string Login
        {
            get => login;
            set
            {
                if (value.Length > MaxLoginLength)
                    throw new ArgumentOutOfRangeException($"Login can't be longer than {MaxLoginLength} symbols!");

                login = value;
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value.Length > MaxPasswordLength)
                    throw new ArgumentOutOfRangeException($"Password can't be longer than {MaxPasswordLength} symbols!");

                password = value;
            }
        }
        public Access Access { get; set; }

        public List<ProductControl> Favorites = new List<ProductControl>();
        public List<ProductControl> Selections = new List<ProductControl>();

        public User(string login, string password)
        {
            try
            {
                Login = login;
                Password = password;
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show(e.Message);
            }
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

        [JsonIgnore]
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

        public int CompareTo(User? other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return Login.CompareTo(other.Login);
            }
        }
    }

    enum Access
    {
        Admin, Guest, User
    }
}

using Optimum_Tech.Model.Interfaces;
using Optimum_Tech.Model.Managers;
using OptimumTech.Controls;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Optimum_Tech.Model
{
    public class User : IAccess, IDisposable, IComparable<User>
    {
        public List<ProductControl> Favorites = new List<ProductControl>();
        public List<ProductControl> Selections = new List<ProductControl>();

        [JsonIgnore]
        private bool _disposed = false;
        private const int MaxLoginLength = 30;
        private const int MaxPasswordLength = 15;
        private string login;
        private string password;

        public string Login
        {
            get => login;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Login can't be null or empty value!");
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
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Login can't be null or empty value!");
                if (value.Length > MaxPasswordLength)
                    throw new ArgumentOutOfRangeException($"Password can't be longer than {MaxPasswordLength} symbols!");

                password = value;
            }
        }
        public Access Access { get; set; }

        ~User()
        {
            Dispose(false);
        }
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
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
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

    public enum Access
    {
        Admin, Guest, User
    }
}

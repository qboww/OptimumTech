using Optimum_Tech.Controls.Managers;
using OptimumTech.Controls;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Optimum_Tech.Model
{
    public class User : IDisposable, IComparable<User>
    {
        private const int MaxLoginLength = 30;
        private const int MaxPasswordLength = 15;
        private const int MinLoginLength = 5;
        private const int MinPasswordLength = 5;

        private string login;
        private string password;
        private bool disposed = false;

        public List<ProductControl> Favorites { get; internal set; } = new List<ProductControl>();
        public List<ProductControl> Selections { get; internal set; } = new List<ProductControl>();

        public string Login
        {
            get => login;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Login can't be null or empty!");
                else if (value.Length >= MinLoginLength && value.Length <= MaxLoginLength) login = value;
                else throw new ArgumentOutOfRangeException($"Login length should be in the range [{MinLoginLength},{MaxLoginLength}]");
            }
        }

        public string Password
        {
            get => password;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Password can't be null or empty!");
                else if (value.Length >= MinPasswordLength && value.Length <= MaxPasswordLength) password = value;
                else throw new ArgumentOutOfRangeException($"Password length should be in the range [{MinPasswordLength},{MaxPasswordLength}]");
            }
        }

        public Access Access { get; set; }

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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Release any managed resources here
            }

            disposed = true;
        }

        public int CompareTo(User other)
        {
            if (other == null)
                return 1;

            return string.Compare(Login, other.Login, StringComparison.Ordinal);
        }
    }

    public enum Access
    {
        Admin,
        Guest,
        User
    }
}

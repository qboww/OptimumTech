using Optimum_Tech.Controls.Managers;
using Optimum_Tech.Model.Interfaces;
using Optimum_Tech.Models;
using OptimumTech.Controls;
using System.Text.Json.Serialization;

namespace Optimum_Tech.Model
{
    public class User : IAccess, IDisposable, IComparable<User>
    {
        [JsonIgnore]
        private const int MaxLoginLength = 30;
        [JsonIgnore]
        private const int MaxPasswordLength = 15;
        [JsonIgnore]
        private const int MinLoginLength = 5;
        [JsonIgnore]
        private const int MinPasswordLength = 5;
        [JsonIgnore]
        public bool disposed = false;

        private string login;
        private string password;

       public List<Order> Orders { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
            Access = Access.User;

            Orders = new List<Order>();
        }

        [JsonIgnore]
        public List<ProductControl> Favorites { get; internal set; } = new List<ProductControl>();
        [JsonIgnore]
        public List<ProductControl> Selections { get; internal set; } = new List<ProductControl>();

        public string Login
        {
            get => login;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Login can't be null or empty!");
                else if (value.Length >= MinLoginLength && value.Length <= MaxLoginLength && value.Any(c => char.IsLetter(c)) && value.Count(c => char.IsLetter(c)) >= 3) login = value;
                else throw new ArgumentOutOfRangeException($"Login length should be in the range [{MinLoginLength},{MaxLoginLength}] and should contain at least 3 letters.");
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

        public void GrantAccessUser()
        {
           Access = Access.User;
        }
        public void GrantAccessGuest()
        {
            Access = Access.Guest;
        }
        public void GrantAccessAdmin()
        {
            Access = Access.Admin;
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
}

using Optimum_Tech.Controls.Managers;
using Optimum_Tech.Model.Interfaces;
using OptimumTech.Controls;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Optimum_Tech.Model
{
    public class User : IAccess, IDisposable, IComparable<User>
    {
        private const int MaxLoginLength = 30;
        private const int MaxPasswordLength = 15;
        private const int MinLoginLength = 5;
        private const int MinPasswordLength = 5;
        private string login;
        private string password;
        private string email;
        private string address;
        private string phoneNumber;
        private bool disposed = false;

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        // TODO: after register all that props rewrites with nulls

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
        [JsonIgnore]
        public string Email
        {
            get => email;
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Email can't be null or empty!");
                    Regex regex = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
                    if (!regex.IsMatch(value))
                        throw new ArgumentException("Invalid email format!");

                    email = value;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Invalid email: " + ex.Message);
                }
            }
        }
        [JsonIgnore]
        public string Address
        {
            get => address;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Address can't be null or empty!");
                address = value;
            }
        }
        [JsonIgnore]
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Phone number can't be null or empty!");
                    Regex regex = new Regex(@"^\+[1-9]{1}[0-9]{3,14}$");
                    if (!regex.IsMatch(value))
                        throw new ArgumentException("Invalid phone number format!");

                    phoneNumber = value;
                }
                catch (Exception ex)
                {
                    // Handle phone number validation errors
                    throw new ArgumentException("Invalid phone number: " + ex.Message);
                }
            }
        }
        public Access Access { get; set; }
        [JsonIgnore]
        public DeliverType DeliveryType { get; set; }

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

    public enum DeliverType
    {
        LocalPostOffice,
        AtTheAddress
    }

    public enum Access
    {
        Admin,
        Guest,
        User
    }
}

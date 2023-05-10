using System.Text.RegularExpressions;

namespace Optimum_Tech.Models
{
    public class Order
    {
        private string email;
        private string address;
        private string phoneNumber;
        private decimal totalPrice;
        private int totalAmount;

        public List<string> products { get; set; }

        public Order()
        {

        }
        
        public Guid Id { get; set; }
        public DeliverType DeliveryType { get; set; }
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
        public string Address
        {
            get => address;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Address can't be null or empty!");
                address = value;
            }
        }
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
        public decimal TotalPrice
        {
            get => totalPrice;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Total price cannot be less than 0!");

                totalPrice = value;
            }
        }
        public int TotalAmount
        {
            get => totalAmount;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Total amount cannot be less than 0!");

                totalAmount = value;
            }
        }

    }
    public enum DeliverType
    {
        LocalPostOffice,
        AtTheAddress
    }
}

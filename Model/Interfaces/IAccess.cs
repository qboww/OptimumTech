namespace Optimum_Tech.Model.Interfaces
{
    internal interface IAccess
    {
        public void GrantAccessUser();
        public void GrantAccessGuest();
        public void GrantAccessAdmin();
    }
}

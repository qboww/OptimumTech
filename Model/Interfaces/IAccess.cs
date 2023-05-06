namespace Optimum_Tech.Model.Interfaces
{
    public interface IAccess
    {
        public void GrantAccessUser();
        public void GrantAccessGuest();
        public void GrantAccessAdmin();
    }
}

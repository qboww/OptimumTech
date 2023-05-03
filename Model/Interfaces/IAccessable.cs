using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Optimum_Tech.Model.User;

namespace Optimum_Tech.Model.Interfaces
{
    internal interface IAccessable
    {
        public void GrantAccessUser();
        public void GrantAccessGuest();
        public void GrantAccessAdmin();
    }
}

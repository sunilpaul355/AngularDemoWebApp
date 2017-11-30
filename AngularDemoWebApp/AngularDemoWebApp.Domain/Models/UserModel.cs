using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDemoWebApp.Domain.Models
{
   public class UserModel
    {
        #region PUBLIC PROPERTY

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string MobileNumber { get; set; }

        public string Gender { get; set; }
        
        #endregion
    }
}

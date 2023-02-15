using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleProduct.Users;

namespace SampleProduct.Users.Initializers
{
    class UserDefaultInitializer : Initializer
    {
        public List<User> InitializeUserDefaultValues(List<User> userList)
        {
            foreach (var user in userList)
            {
                user.LoginEffectiveDate = DateTime.Now;
                user.LoginExpiryDate = DateTime.Now;
                user.IsLoginBlocked = 1;
                user.IsAdminBlocked = 0;
                user.LoginBlockedTime = DateTime.Now;
                user.ForcePasswordReset = 0;
                user.CreationDate = DateTime.Now;
                user.ActivationDate = DateTime.Now;
                user.DeactivationDate = DateTime.Now;
                user.CanLogin = 0;
                user.LoginFailureCounter = 0;
                user.ApprovalStatus = "Approved";
                user.CreatedById = 1;
                user.CreatedTime = DateTime.Now;
                user.UpdatedById = 1;
                user.UpdatedTime = DateTime.Now;
                user.IsFullAccess = 0;
                user.DefaultBusinessUnitId = 0;
                user.AdminUserId = 0;
                user.IsFactorAuthenticationEnabled = 0;
                user.MultiFactorAuthenticationId = 0;
                user.ContractId = 0;
                user.ExternalUserId = "0";
                user.DomainId = 0;             
            }
            return userList;
        }
    }
}

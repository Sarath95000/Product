
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProduct.Users
{
    class User
    {
        public static List<User> user = new List<User>();
        internal long Id { get; set; }
        public string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string FullName { get; set; }
        internal string LoginName { get; set; }
        internal short IsWindowsAuthenticated { get; set; }
        internal string Password { get; set; }
        internal string PhoneNumber { get; set; }
        internal string FaxNumber { get; set; }
        internal string PhoneExtensionNumber { get; set; }
        internal string Email { get; set; }
        internal short IsEmailNotificationAllowed { get; set; }
        internal DateTime LoginEffectiveDate { get; set; }
        internal DateTime LoginExpiryDate { get; set; }
        internal short IsLoginBlocked { get; set; }
        internal short IsAdminBlocked { get; set; }
        internal DateTime LoginBlockedTime { get; set; }
        internal short ForcePasswordReset { get; set; }
        internal DateTime CreationDate { get; set; }
        internal DateTime ActivationDate { get; set; }
        internal DateTime DeactivationDate { get; set; }
        internal short CanLogin { get; set; }
        internal int LoginFailureCounter { get; set; }
        internal string ApprovalStatus { get; set; }
        internal string Title { get; set; }
        internal long CreatedById { get; set; }
        internal DateTime CreatedTime { get; set; }
        internal long UpdatedById { get; set; }
        internal DateTime UpdatedTime { get; set; }
        internal int IsFullAccess { get; set; }
        internal long DefaultBusinessUnitId { get; set; }
        internal long AdminUserId { get; set; }
        internal short IsFactorAuthenticationEnabled { get; set; }
        internal short MultiFactorAuthenticationId { get; set; }
        internal short ContractId { get; set; }
        internal string ExternalUserId { get; set; }
        internal long DomainId { get; set; }
    }
}

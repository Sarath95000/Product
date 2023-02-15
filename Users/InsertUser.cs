using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SampleProduct;
using System.Data;
using SampleProduct.Users.Initializers;

namespace SampleProduct.Users
{
    class InsertUser
    {
        private SqlConnection connection = DBConnect.connectionObject;


        public void InsertUserData(List<User> userList)
        {

            UserDefaultInitializer intializeValue = new UserDefaultInitializer();
            userList = intializeValue.InitializeUserDefaultValues(userList);
            try {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "EXECUTE InsertUserData @FirstName,@LastName,@FullName,@LoginName,@IsWindowsAuthenticated," +
                    "@Password,@PhoneNumber,@FaxNumber,@PhoneExtensionNumber,@Email,@IsEmailNotificationAllowed,@LoginEffectiveDate," +
                    "@LoginExpiryDate,@IsLoginBlocked,@IsAdminBlocked,@LoginBlockedTime,@ForcePasswordReset,@CreationDate,@ActivationDate," +
                    "@DeactivationDate,@CanLogin,@LoginFailureCounter,@ApprovalStatus ,@Title,@CreatedById,@CreatedTime,@UpdatedById," +
                    "@UpdatedTime,@IsFullAccess,@DefaultBusinessUnitId,@AdminUserId,@IsFactorAuthenticationEnabled," +
                    "@MultiFactorAuthenticationId,@ContractId,@ExternalUserId,@DomainId";

                foreach (var user in userList)
                {
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = user.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = user.LastName;
                    cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = user.FullName;
                    cmd.Parameters.Add("@LoginName", SqlDbType.NVarChar).Value = user.LoginName;
                    cmd.Parameters.Add("@IsWindowsAuthenticated", SqlDbType.Bit).Value = user.IsWindowsAuthenticated;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = user.Password;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 12).Value = user.PhoneNumber;
                    cmd.Parameters.Add("@FaxNumber", SqlDbType.NVarChar, 15).Value = user.FaxNumber;
                    cmd.Parameters.Add("@PhoneExtensionNumber", SqlDbType.NVarChar, 5).Value = user.PhoneExtensionNumber;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = user.Email;
                    cmd.Parameters.Add("@IsEmailNotificationAllowed", SqlDbType.Bit).Value = user.IsEmailNotificationAllowed;
                    cmd.Parameters.Add("@LoginEffectiveDate", SqlDbType.Date).Value = user.LoginEffectiveDate;
                    cmd.Parameters.Add("@LoginExpiryDate", SqlDbType.Date).Value = user.LoginExpiryDate;
                    cmd.Parameters.Add("@IsLoginBlocked", SqlDbType.Bit).Value = user.IsLoginBlocked;
                    cmd.Parameters.Add("@IsAdminBlocked", SqlDbType.Bit).Value = user.IsAdminBlocked;
                    cmd.Parameters.Add("@LoginBlockedTime", SqlDbType.DateTime).Value = user.LoginBlockedTime;
                    cmd.Parameters.Add("@ForcePasswordReset", SqlDbType.Bit).Value = user.ForcePasswordReset;
                    cmd.Parameters.Add("@CreationDate", SqlDbType.Date).Value = user.CreationDate;
                    cmd.Parameters.Add("@ActivationDate", SqlDbType.Date).Value = user.ActivationDate;
                    cmd.Parameters.Add("@DeactivationDate", SqlDbType.Date).Value = user.DeactivationDate;
                    cmd.Parameters.Add("@CanLogin", SqlDbType.Bit).Value = user.CanLogin;
                    cmd.Parameters.Add("@LoginFailureCounter", SqlDbType.Int).Value = user.LoginFailureCounter;
                    cmd.Parameters.Add("@ApprovalStatus", SqlDbType.NVarChar, 50).Value = user.ApprovalStatus;
                    cmd.Parameters.Add("@Title", SqlDbType.NVarChar, 50).Value = user.Title;
                    cmd.Parameters.Add("@CreatedById", SqlDbType.BigInt).Value = user.CreatedById;
                    cmd.Parameters.Add("@CreatedTime", SqlDbType.DateTime).Value = user.CreatedTime;
                    cmd.Parameters.Add("@UpdatedById", SqlDbType.BigInt).Value = user.UpdatedById;
                    cmd.Parameters.Add("@UpdatedTime", SqlDbType.DateTime).Value = user.UpdatedTime;
                    cmd.Parameters.Add("@IsFullAccess", SqlDbType.Bit).Value = user.IsFullAccess;
                    cmd.Parameters.Add("@DefaultBusinessUnitId", SqlDbType.BigInt).Value = user.DefaultBusinessUnitId;
                    cmd.Parameters.Add("@AdminUserId", SqlDbType.BigInt).Value = user.AdminUserId;
                    cmd.Parameters.Add("@IsFactorAuthenticationEnabled", SqlDbType.Bit).Value = user.IsFactorAuthenticationEnabled;
                    cmd.Parameters.Add("@MultiFactorAuthenticationId", SqlDbType.Bit).Value = user.MultiFactorAuthenticationId;
                    cmd.Parameters.Add("@ContractId", SqlDbType.Bit).Value = user.ContractId;
                    cmd.Parameters.Add("@ExternalUserId", SqlDbType.NVarChar, 50).Value = user.ExternalUserId;
                    cmd.Parameters.Add("@DomainId", SqlDbType.BigInt).Value = user.DomainId;
                    cmd.ExecuteNonQuery();
                }                

                Console.WriteLine("Data Inserted");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        

        }



    }
}

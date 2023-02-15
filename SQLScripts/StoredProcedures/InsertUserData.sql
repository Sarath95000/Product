USE Product_Main
GO
CREATE PROCEDURE InsertUserData
(
	@FirstName nvarchar,
	@LastName nvarchar,
	@FullName nvarchar,
	@LoginName nvarchar,
	@IsWindowsAuthenticated bit,
	@Password nvarchar,
	@PhoneNumber nvarchar,
	@FaxNumber nvarchar,
	@PhoneExtensionNumber nvarchar,
	@Email nvarchar,
	@IsEmailNotificationAllowed bit,
	@LoginEffectiveDate date,
	@LoginExpiryDate date,
	@IsLoginBlocked bit,
	@IsAdminBlocked bit,
	@LoginBlockedTime	datetimeoffset,
	@ForcePasswordReset bit,
	@CreationDate date,
	@ActivationDate date,
	@DeactivationDate date,
	@CanLogin bit,
	@LoginFailureCounter int,
	@ApprovalStatus nvarchar,
	@Title nvarchar,
	@CreatedById bigint,
	@CreatedTime datetimeoffset,
	@UpdatedById bigint,
	@UpdatedTime datetimeoffset,
	@IsFullAccess bit,
	@DefaultBusinessUnitId bigint,
	@AdminUserId bigint,
	@IsFactorAuthenticationEnabled bit,
	@MultiFactorAuthenticationId bit,
	@ContractId bit,
	@ExternalUserId nvarchar,
	@DomainId bigint
)
AS
BEGIN
	INSERT INTO Users(FirstName,LastName,FullName,LoginName,IsWindowsAuthenticated,Password,PhoneNumber,FaxNumber,
	PhoneExtensionNumber,Email,IsEmailNotificationAllowed,LoginEffectiveDate,LoginExpiryDate,IsLoginBlocked,IsAdminBlocked,
	LoginBlockedTime,ForcePasswordReset,CreationDate,ActivationDate,DeactivationDate,CanLogin,LoginFailureCounter,ApprovalStatus ,Title,CreatedById,CreatedTime,UpdatedById,UpdatedTime,IsFullAccess,DefaultBusinessUnitId,AdminUserId,IsFactorAuthenticationEnabled,MultiFactorAuthenticationId,ContractId,ExternalUserId,DomainId)
	Values(@FirstName,@LastName,@FullName,@LoginName,@IsWindowsAuthenticated,@Password,@PhoneNumber,@FaxNumber,
	@PhoneExtensionNumber,@Email,@IsEmailNotificationAllowed,@LoginEffectiveDate,@LoginExpiryDate,@IsLoginBlocked,@IsAdminBlocked,
	@LoginBlockedTime,@ForcePasswordReset,@CreationDate,@ActivationDate,@DeactivationDate,@CanLogin,@LoginFailureCounter,@ApprovalStatus ,@Title,@CreatedById,@CreatedTime,@UpdatedById,@UpdatedTime,@IsFullAccess,@DefaultBusinessUnitId,@AdminUserId,@IsFactorAuthenticationEnabled,@MultiFactorAuthenticationId,@ContractId,@ExternalUserId,@DomainId);
END

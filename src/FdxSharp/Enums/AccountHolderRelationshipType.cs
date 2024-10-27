namespace FdxSharp.Enums;

/// <summary>
/// Title: Account Holder Relationship
/// Description: Types of relationships between accounts and holders.Suggested values
/// </summary>
public enum AccountHolderRelationshipType
{
	/// <summary>
	/// Authorized user of the account
	/// </summary>
	AUTHORIZED_USER,

	/// <summary>
	/// Business relationship with the account
	/// </summary>
	BUSINESS,

	/// <summary>
	/// For benefit of (FBO) relationship
	/// </summary>
	FOR_BENEFIT_OF,

	/// <summary>
	/// For benefit of primary holder
	/// </summary>
	FOR_BENEFIT_OF_PRIMARY,

	/// <summary>
	/// For benefit of primary joint holder with restrictions
	/// </summary>
	FOR_BENEFIT_OF_PRIMARY_JOINT_RESTRICTED,

	/// <summary>
	/// For benefit of secondary holder
	/// </summary>
	FOR_BENEFIT_OF_SECONDARY,

	/// <summary>
	/// For benefit of secondary joint holder with restrictions
	/// </summary>
	FOR_BENEFIT_OF_SECONDARY_JOINT_RESTRICTED,

	/// <summary>
	/// For benefit of sole owner with restrictions
	/// </summary>
	FOR_BENEFIT_OF_SOLE_OWNER_RESTRICTED,

	/// <summary>
	/// Power of attorney relationship
	/// </summary>
	POWER_OF_ATTORNEY,

	/// <summary>
	/// Primary joint tenants relationship
	/// </summary>
	PRIMARY_JOINT_TENANTS,

	/// <summary>
	/// Primary account holder
	/// </summary>
	PRIMARY,

	/// <summary>
	/// Primary borrower relationship
	/// </summary>
	PRIMARY_BORROWER,

	/// <summary>
	/// Primary joint account holder
	/// </summary>
	PRIMARY_JOINT,

	/// <summary>
	/// Secondary account holder
	/// </summary>
	SECONDARY,

	/// <summary>
	/// Secondary joint tenants relationship
	/// </summary>
	SECONDARY_JOINT_TENANTS,

	/// <summary>
	/// Secondary borrower relationship
	/// </summary>
	SECONDARY_BORROWER,

	/// <summary>
	/// Secondary joint account holder
	/// </summary>
	SECONDARY_JOINT,

	/// <summary>
	/// Sole owner of the account
	/// </summary>
	SOLE_OWNER,

	/// <summary>
	/// Trustee relationship
	/// </summary>
	TRUSTEE,

	/// <summary>
	/// Uniform transfer to minor relationship
	/// </summary>
	UNIFORM_TRANSFER_TO_MINOR
}

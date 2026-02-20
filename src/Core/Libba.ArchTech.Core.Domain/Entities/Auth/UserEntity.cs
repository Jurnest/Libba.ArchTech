using Libba.ArchTech.Core.Domain.Enums;

namespace Libba.ArchTech.Core.Domain.Entities.Auth;

public class UserEntity : BaseEntity
{
    #region Columns
    public string Username { get; set; }
    public PhoneCodes PhoneCode { get; set; }
    public int PhoneNumber { get; set; }
    public string EMail { get; set; }
    public string PasswordHash { get; set; }
    #endregion
}

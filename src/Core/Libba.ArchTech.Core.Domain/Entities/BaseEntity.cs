namespace Libba.ArchTech.Core.Domain.Entities;

public abstract class BaseEntity
{
    #region Columns
    public Guid Id { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? UpdatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    #endregion
}

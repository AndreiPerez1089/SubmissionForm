using SubmissionForm.Core.Interfaces.Entities;

namespace SubmissionForm.Core.Models.Entities;

public class SubmissionForm : IAuditEntity, ISoftDeleteEntity
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public Guid? TemplateSubmissionFormId { get; set; }

    public SubmissionForm? TemplateSubmissionForm { get; set; }

    public ICollection<SubmissionField> SubmissionFields { get; set; } = Array.Empty<SubmissionField>();

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = string.Empty;

    public string UpdatedBy { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}

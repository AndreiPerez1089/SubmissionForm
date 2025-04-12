namespace SubmissionForm.Core.Interfaces.Entities;

interface IAuditEntity
{
    string CreatedBy { get; set; }

    string UpdatedBy { get; set; }

    DateTime CreatedAt { get; set; }

    DateTime UpdatedAt { get; set; }
}

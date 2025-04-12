namespace SubmissionForm.Core.Interfaces.Entities;

public interface ISoftDeleteEntity
{
    bool IsDeleted { get; set; }
}

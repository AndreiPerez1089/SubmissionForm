namespace SubmissionForm.Core.Models.Entities;

public class Submission
{
    public Guid Id { get; set; }

    public string OwnerId { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;
}

using System.ComponentModel.DataAnnotations;

namespace Mission6Assignmnet.Models;

public class MovieRecord
{
    [Key]
    public int MovieRecordID { get; set; }
    public string Category { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public string DirectorFirstName { get; set; }
    public string DirectorLastName { get; set; }
    public string Rating { get; set; }
    public bool? Edited { get; set; }
    public string? LentTo { get; set; }
    [StringLength(25)]
    public string? Notes { get; set; }
    
}
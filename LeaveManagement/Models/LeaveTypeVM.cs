using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models;

public class LeaveTypeVM
{
    public int Id { get; set; }
    [Required ]
    public string Name { get; set; }
    [Display(Name = "Default Number of Days")]
    [Required]
    [Range(1,31, ErrorMessage = "Please enter valid number of days")]
    public int DefaultDays { get; set; }
}
using System.ComponentModel.DataAnnotations;

public class FizzBuzzSettings
{
    [Range(1, 1000, ErrorMessage = "MaxNumber must be between 1 and 1000.")]
    public int MaxNumber { get; set; }
}
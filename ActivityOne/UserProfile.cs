 namespace ActivityOne;

 public class UserProfile
{
    public int Id {get; set; }
    public string Username { get; set; } = string.Empty;
    public string? Location { get; set; }
    public string? Phone { get; set; }
    public string Bio { get; set; } = string.Empty; 
    public bool IsActive { get; set; }
}

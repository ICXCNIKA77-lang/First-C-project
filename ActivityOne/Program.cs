using ActivityOne;

UserProfile user = new UserProfile
{
    Id = 101,
    Username = "DevExplorer",
    Location = null,
    Phone = null,
    Bio = "Mastering modern C# apps and learning new frameworks",
    IsActive = true
};

Console.WriteLine("=== User Profile Created ===");
Console.WriteLine($"ID:        {user.Id}");
Console.WriteLine($"Username:  {user.Username}");
string safeLocation = user.Location ?? "Location not provided";
string safePhone = user.Phone ?? "No phone number registered";
Console.WriteLine($"Location:  {safeLocation}");
Console.WriteLine($"Phone:     {safePhone}");
Console.WriteLine($"Bio:       {user.Bio}");
Console.WriteLine($"Active:    {user.IsActive}");

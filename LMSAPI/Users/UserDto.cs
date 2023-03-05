namespace LMSAPI.Users;

public record UserCommand(int Id, UserType Type, string FirstName, string LastName, DateTime? DateOfBirth,
    string? UserName, string? Email, string? PhoneNumber);

public record UserDto(int Id, UserType Type, string FirstName, string LastName, DateTime? DateOfBirth,
    string? UserName, string? Email, string? PhoneNumber);

public record UserPageDto(int Id, UserType Type, string FirstName, string LastName, DateTime? DateOfBirth,
    string? UserName, string? Email, string? PhoneNumber);
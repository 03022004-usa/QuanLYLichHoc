namespace QuanLyLichHoc
{
    public class UserSession
    {
        public string Username { get; set; }

        public string Role { get; set; }

        public string MaHS { get; set; }

        public string Email { get; set; }

        public UserSession(string username, string role, string email, string maHS = null)
        {
            Username = username;
            Role = role;
            Email = email;  
            MaHS = maHS;
        }

        public override string ToString()
        {
            return $"User: {Username}, Role: {Role}, Email: {Email}, MaHS: {MaHS ?? "N/A"}";
        }
    }
}

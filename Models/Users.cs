namespace File_Acess_Management.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string HashedPassword { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool Assigned { get; set; }

        public Users(int id, string username, string hashedPassword, int roleId, string name, string email, string phoneNumber, string address, bool assigned)
        {
            Id = id;
            Username = username;
            HashedPassword = hashedPassword;
            RoleId = roleId;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Assigned = assigned;
        }
    }
}
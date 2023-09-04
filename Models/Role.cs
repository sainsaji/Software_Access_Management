namespace File_Acess_Management.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public Role(int roleId, string roleName)
        {
            RoleId = roleId;
            RoleName = roleName;
        }

        public override string ToString()
        {
            return RoleName;
        }
    }
}
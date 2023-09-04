namespace File_Acess_Management.Models
{
    public class Assignment
    {
        public int ManagerId { get; set; }
        public int UserId { get; set; }

        public Assignment(int managerId, int userId)
        {
            ManagerId = managerId;
            UserId = userId;
        }
    }
}
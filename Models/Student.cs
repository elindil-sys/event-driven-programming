namespace StudentsMvcDemo.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string RegNumber { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Programme { get; set; } = string.Empty;
    }
}

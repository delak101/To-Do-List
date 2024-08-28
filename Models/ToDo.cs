namespace To_Do_List.Models
{
    public class ToDo : IComparable<ToDo>
    {
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public bool IsDone { get; set; }
        public int CompareTo(ToDo? other)
        {
            if (other == null) return 1;
            return other.IsDone.CompareTo(this.IsDone);
        }

    }
}

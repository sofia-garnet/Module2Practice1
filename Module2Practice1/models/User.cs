namespace Module2Practice1.Models
{
    public class User
    {
        public string Phone { get; set; }
        public string Mail { get; set; }
        public object Name { get; internal set; }
    }
}
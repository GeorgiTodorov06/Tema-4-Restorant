namespace Tema_4_Restorant.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public DateTime DataTime { get; set; }
        public Table Table { get; set; }
        public int TableId { get; set; }
        public string Description { get; set; }
    }
}

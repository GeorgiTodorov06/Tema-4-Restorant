namespace Tema_4_Restorant.Models
{
    public class Customer
    {
        public Customer()
        {
            Reservations = new List<Reservation>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
    }
}

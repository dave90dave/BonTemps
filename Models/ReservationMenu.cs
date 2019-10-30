namespace BonTemps.Models
{
    public class ReservationMenu
    {
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}

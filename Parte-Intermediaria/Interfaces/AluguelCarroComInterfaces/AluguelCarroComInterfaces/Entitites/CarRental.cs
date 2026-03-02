namespace AluguelCarroComInterfaces.Entitites
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; } // Associação entre as classes CarRental e Vehicle, ou seja, um CarRental tem um Vehicle.
        public Invoice Invoice { get; set; } //Associação entre as classes CarRental e Invoice, ou seja, um CarRental tem um Invoice.

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle) // Invoice fora pois vai ser iniciado como nulo
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }
    }
}

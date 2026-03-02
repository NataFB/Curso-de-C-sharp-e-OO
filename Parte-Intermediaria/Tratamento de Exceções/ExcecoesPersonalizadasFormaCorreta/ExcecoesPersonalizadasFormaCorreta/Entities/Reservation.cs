using System;
using ExcecoesPersonalizadasFormaCorreta.Entities.Exceptions;

namespace ExcecoesPersonalizadasFormaCorreta.Entities
{
    class Reservation
    {

        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {

            if (checkOut <= checkIn)
            {
                // Lançar uma exceção personalizada para indicar que a data de check-out deve ser posterior à data de check-in (throw).
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public double Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {

            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                // Lançar uma exceção personalizada para indicar que as datas de reserva para atualização devem ser futuras (throw).
                throw new DomainException("Reservation dates for update must be future dates");
            }
            else if (checkOut <= checkIn)
            {
                // Lançar uma exceção personalizada para indicar que a data de check-out deve ser posterior à data de check-in (throw).
                throw new DomainException("Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
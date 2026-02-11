using System;
using System.Collections.Generic;
using System.Text;

namespace ExcecoesPersonalizadasParte1.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            //Calculando a duração da reserva subtraindo a data de check-in da data de check-out, o que resulta em um objeto TimeSpan que representa o intervalo de tempo entre as duas datas.
            TimeSpan duration = CheckOut.Subtract(CheckIn); 
            return (int)duration.TotalDays; //Convertendo o resultado para inteiro, pois a duração deve ser expressa em dias inteiros e não em double.
        }

        public void updateDates(DateTime checkIn, DateTime checkOut)
        {
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

using System;
using reservaHotel.Entities;
using reservaHotel.Entities.Exceptions;

namespace reservaHotel {
  class Program {
    static void Main (string[] args) {
      int number;
      DateTime checkIn, checkOut;

      Reservation reservation;
      try {
        Console.Write ("Room number: ");
        number = int.Parse (Console.ReadLine ());

        Console.Write ("Check-in date (dd/MM/yyy): ");
        checkIn = DateTime.Parse (Console.ReadLine ());

        Console.Write ("Check-out date (dd/MM/yyy): ");
        checkOut = DateTime.Parse (Console.ReadLine ());

        reservation = new Reservation (number, checkIn, checkOut);
        Console.WriteLine (reservation.ToString ());

        Console.WriteLine ("\nEnter data to update the reservation:");

        Console.Write ("Check-in date (dd/MM/yyy): ");
        checkIn = DateTime.Parse (Console.ReadLine ());

        Console.Write ("Check-out date (dd/MM/yyy): ");
        checkOut = DateTime.Parse (Console.ReadLine ());

        reservation.UpdateDates (checkIn, checkOut);
        Console.WriteLine ($"Reservation: {reservation}");

      } catch (DomainException e) {

        Console.WriteLine ($"Error in reservation: {e.Message}");
      } catch (FormatException e) {
        Console.WriteLine ($"Format error: {e.Message}");
      } catch (Exception e) {
        Console.WriteLine ($"Unexpected error: {e.Message}");
      }
    }
  }
}
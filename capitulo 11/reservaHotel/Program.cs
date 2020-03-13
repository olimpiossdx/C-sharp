using System;
using reservaHotel.Entities;

namespace reservaHotel {
  class Program {
    static void Main (string[] args) {
      int number;
      DateTime checkIn, checkOut;
      string error;

      Reservation reservation;

      Console.Write ("Room number: ");
      number = int.Parse (Console.ReadLine ());

      Console.Write ("Check-in date (dd/MM/yyy): ");
      checkIn = DateTime.Parse (Console.ReadLine ());

      Console.Write ("Check-out date (dd/MM/yyy): ");
      checkOut = DateTime.Parse (Console.ReadLine ());

      if (checkOut <= checkIn) {
        Console.WriteLine ("Error in reservation: check-out date must be after check-in date");
      } else {
        reservation = new Reservation (number, checkIn, checkOut);
        Console.WriteLine (reservation.ToString ());

        Console.WriteLine ("\nEnter data to update the reservation:");

        Console.Write ("Check-in date (dd/MM/yyy): ");
        checkIn = DateTime.Parse (Console.ReadLine ());

        Console.Write ("Check-out date (dd/MM/yyy): ");
        checkOut = DateTime.Parse (Console.ReadLine ());
        error = reservation.UpdateDates (checkIn, checkOut);
        if (error != null) {
          Console.WriteLine ($"Error in reservation: {error}");

        } else {
          reservation.UpdateDates (checkIn, checkOut);
          Console.WriteLine ($"Reservation: {reservation}");
        }
      }
    }
  }
}
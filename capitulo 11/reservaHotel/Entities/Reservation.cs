using System;
namespace reservaHotel.Entities {
  class Reservation {
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public Reservation () { }
    public Reservation (int roomNumber, DateTime checkIn, DateTime checkOut) {
      RoomNumber = roomNumber;
      CheckIn = checkIn;
      CheckOut = checkOut;
    }

    public int Duration () {
      TimeSpan duration = CheckOut.Subtract (CheckIn);
      return ((int) duration.TotalDays);
    }

    public string UpdateDates (DateTime checkIn, DateTime checkOut) {

      DateTime now = DateTime.Now;

      if (checkOut < now || checkIn < now) {
        return ("Reservation: check-out date must be futures dates");
      }
      if (checkOut <= now) {
        return ("Check-out date must be futures dates");
      }
      CheckIn = checkIn;
      CheckOut = checkOut;
      return null;
    }

    public override string ToString () {
      return ($"Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights");
    }
  }
}
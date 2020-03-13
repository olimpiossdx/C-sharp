using System;
namespace reservaHotel.Entities.Exceptions {
  class DomainException : ApplicationException {
    public DomainException (string message) : base (message) {

    }
  }
}
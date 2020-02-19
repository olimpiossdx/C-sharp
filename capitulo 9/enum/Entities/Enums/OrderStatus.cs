namespace Enumerado {
  // OrderStatus é derivado do tipo int
  enum OrderStatus : int {
    PendingPayment = 0,
    Processing = 1,
    Shipped = 2,
    Delivered = 3
  }
}
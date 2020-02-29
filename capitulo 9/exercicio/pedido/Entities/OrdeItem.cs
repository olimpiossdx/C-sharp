namespace pedido.Entities {
  class OrderItem {
    public int Quantity { get; set; }
    public double Price { get; set; }
    public Product Product { get; set; }
    public OrderItem (int quantity, double price, Product product) {
      Quantity = quantity;
      Price = price;
      Product = product;
    }
    public override string ToString () {
      return ($"{Product.ToString()}, Quantity: {Quantity}, SubTotal: ${Quantity*Price}");    }
  }
}
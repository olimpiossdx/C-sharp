using System;
using System.Collections.Generic;
using System.Text;
using pedido.Entities;
using pedido.Entities.Enums;

namespace pedido.Entities {
  class Order {
    public DateTime Moment { get; set; }
    public Client Client { get; set; }
    public OrderStatus Status { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem> ();

    public Order (OrderStatus status, Client client) {
      Status = status;
      Client = client;
      Moment = DateTime.Now;
    }
    public void AddItem (OrderItem item) {
      Items.Add (item);
    }
    public void RemoveItem (OrderItem item) {
      Items.Remove (item);
    }
    public double Total () {
      double total = 0.0;
      foreach (var item in Items)
        total += item.Price * item.Quantity;

      return total;
    }
    public override string ToString () {
      StringBuilder sb = new StringBuilder ();
      sb.AppendLine ("ORDER SUMMARY:");
      sb.Append("Oder moment: ");
      sb.AppendLine(Moment.ToString());
      sb.Append ("Order status: ");
      sb.AppendLine (Status.ToString());
      sb.Append ("CLient: ");
      sb.AppendLine (Client.ToString ());
      sb.AppendLine ("Order items:");
      
      foreach (OrderItem item in Items)
        sb.AppendLine (item.ToString ());

      sb.Append ("Total price: ");
      sb.AppendLine (Total ().ToString ("F2"));
      return sb.ToString();
    }
  }
}
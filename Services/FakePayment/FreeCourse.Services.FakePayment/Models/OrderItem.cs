﻿namespace FreeCourse.Services.FakePayment.Models;

public class OrderItem
{
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public string PictureUrl { get; set; }
    public decimal Price { get; set; }
}
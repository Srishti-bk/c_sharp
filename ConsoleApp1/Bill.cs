//Store the price and quantity of three products and calculate the total bill.
using System;
class Bill{
    public void totalBill()
    {
        string product1="noodels";
        int price1=20;
        int quantity1=3;

        string product2="soap";
        int price2=100;
        int quantity2=2;

        string product3="biscuits";
        int price3=10;
        int quantity3=5;

        double totalPrice=price1*quantity1+price2*quantity2+price3*quantity3;
        Console.WriteLine($"The total price of {product1},{product2} and {product3} is {totalPrice}");
        

    }
    
}
//15.Create variables for hours, minutes, and seconds, then convert everything into total seconds.
using System;
class Totalsecond
{
    public void Convert(){
    int hours=2;
    int minutes=120;
    int seconds = 240;

     double total=hours*60*60+minutes*60+seconds;
    Console.WriteLine($"Total second of {hours} hours,{minutes} minutes and {seconds} seconds is {total}");

}
}
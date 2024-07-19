using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("19904 Lark Ln", "Monument", "CO", "80132", "US");
        address.DisplayAddress();

        SocialEvent socialEvent = new SocialEvent("Birthday party", "Fun fun fun party with all my friends for my 30th birthday!", "April 26th, 2025", "5:00pm-8:00pm", address);
        socialEvent.DisplayEventInfo();
    }
}
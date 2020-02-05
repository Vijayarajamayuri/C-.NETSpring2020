using System;


namespace EventsAndDelegate
{
    
    class PromotionalEvent
    {
        public delegate void promotion(double totalBill, double discount);
        public event promotion thanksGiving_event;

        public void calcBillWithDiscount(double totalBill, double discount)
        {
            if (thanksGiving_event != null)
                //Event raised 
                thanksGiving_event(totalBill, discount);

            else
                //Event not raised
                Console.WriteLine("Event is not Raised Your total bill is "+totalBill);                      
        }
    }
  class EventsDriver
    {
        static void Main(string[] args) 
        {
            //Creating an object of the class
            PromotionalEvent tgSales = new PromotionalEvent();
            //Raise event
            tgSales.thanksGiving_event += new PromotionalEvent.promotion(event_totalBillAfterDiscount);
            
            tgSales.calcBillWithDiscount(1000,10);           
        }

        //Delegates calls this method when event raised.  
        static void event_totalBillAfterDiscount(double totalBill, double discount)
        {
            Console.WriteLine("Thanks Giving promotional offer is successfully Raised ");
            double result = totalBill - (totalBill * discount / 100);
            Console.WriteLine("Total Bill " + result);
         }

    }
}

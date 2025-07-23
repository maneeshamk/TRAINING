public abstract class DeliveryPlatform
{


    public string PartnerName { get; set; }


    publicvoid TrackOrder()
    {
        Console.WriteLine("Order is being tracked :" + PartnerName);


    }
    public abstract void DeliveryOrder();
    
}
class DeliveryApp
{


    static void Main()
    {
        DeliveryPlatform partner = new ZomatoPartner();
        partner.PartnerName = "Zomato";


        partner.TrackOrder();
        partner.DeliveryOrder();
    }
}
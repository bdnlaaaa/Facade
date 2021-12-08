Shop shop = new Shop();
DeliveryCompany deliveryCompany = new DeliveryCompany();
SortingCenter sortingCenter = new SortingCenter();
Courier courier = new Courier();
DeliveringOrderFacade facade1 = new DeliveringOrderFacade(shop, deliveryCompany, sortingCenter, courier);
Client client = new Client();
client.MakeAnOrder(facade1);

class Shop
{
    public void TakeOrder()
    {
        Console.WriteLine("We will send your goods soon");
    }
}
class DeliveryCompany
{
    public void DeliverOrder()
    {
        Console.WriteLine("We are delivering your order to the sorting center");
    }
}
class SortingCenter
{
    public void Sort()
    {
        Console.WriteLine("Your order will be checked and sent to your city");
    }
}
class Courier
{
    public void Give()
    {
        Console.WriteLine("Please be at home during lunch time so we can give you your goods");
    }
}
class DeliveringOrderFacade
{
    Shop shop;
    DeliveryCompany deliveryCompany;
    SortingCenter sortingCenter;
    Courier courier;
    public DeliveringOrderFacade(Shop sh, DeliveryCompany dc, SortingCenter sc, Courier co)
    {
        this.shop = sh;
        this.deliveryCompany = dc;
        this.sortingCenter = sc;
        this.courier = co;
    }
    public void DoEverything()
    {
        shop.TakeOrder();
        deliveryCompany.DeliverOrder();
        sortingCenter.Sort();
        courier.Give();
    }
}
class Client
{
    public void MakeAnOrder(DeliveringOrderFacade facade)
    {
        facade.DoEverything();
    }
}

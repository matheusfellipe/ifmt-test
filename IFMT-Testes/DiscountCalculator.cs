namespace IFMT_Testes
{
    public class DiscountCalculator
    {
        public  decimal ApplyDiscount(Item item,decimal discount)
        {
          
        

            decimal subTotal = item.Price - Math.Min(item.Price * (discount/100), item.Price); 
            return subTotal;
        }
    }
}

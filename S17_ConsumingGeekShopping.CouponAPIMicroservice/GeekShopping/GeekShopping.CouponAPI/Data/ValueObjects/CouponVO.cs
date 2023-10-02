namespace GeekShopping.CouponAPI.Data.ValueObjects
{
    public class CouponVO
    {
        public long id {  get; set; }

        public string CouponCode { get; set; }

        public decimal DiscountAmount { get; set; }
    }
}

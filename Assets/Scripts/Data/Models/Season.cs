namespace Data.Models
{
    public class ISeason : Base
    {
        public int value;
        public string name;
        public long startDate; // BigInt -> long
        public long endDate;   // BigInt -> long
    }
}

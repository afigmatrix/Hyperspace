namespace Hyperspace.Models
{
    public class AboutLoadVM
    {
        public string Name { get; set; }
        public string Desc { get; set; }

        public Address AddressInfo { get; set; }
    }



    public class Address
    {
        public string Info { get; set; }
        public bool IsActive { get; set; }
    }
}

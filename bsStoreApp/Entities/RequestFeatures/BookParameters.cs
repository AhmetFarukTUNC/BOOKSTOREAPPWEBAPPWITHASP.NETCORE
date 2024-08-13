namespace Entities.RequestFeatures
{
    public class BookParameters : RequestParameters
    {

        public uint Minprice { get; set; }

        public uint Maxprice { get; set; } = 1000;

        public bool ValidPriceRange => Maxprice >Minprice;



    }
}

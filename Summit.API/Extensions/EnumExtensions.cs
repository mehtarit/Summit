using Summit.API.Enums;

namespace Summit.API.Extensions
{
    public static class EnumExtensions
    {
        public static City ToCityEnum(this string city)
        {
            //Todo: implement this function
            return City.Austin;
        }

        public static Country ToCountryEnum(this string country)
        {
            //Todo: implement this function
            return Country.US;
        }


        public static Region ToRegionEnum(this string region)
        {
            //Todo: implement this function
            return Region.Austin;
        }

        public static TshirtSize ToTshirtSizeEnum(this string tshirtSize)
        {
            //Todo: implement this function
            return TshirtSize.M;
        }
    }
}

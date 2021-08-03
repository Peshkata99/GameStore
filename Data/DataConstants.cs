namespace GameStore.Data
{
    public class DataConstants
    {
        public class User
        {

        }

        public class Game
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;

            public const double MinPrice = 0;
            public const double MaxPrice = double.MaxValue;

            public const int DeveloperMinLength = 5;
            public const int DeveloperMaxLength = 40;

            public const int DescriptionMinLength = 20;

            public const int MinReleaseYear = 1962;
            public const int MaxReleaseYear = 2030;
        }

        public class Genre
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 25;
        }

        public class Seller
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 25;

            public const int PhoneNumberMinLength = 6;
            public const int PhoneNumberMaxLength = 30;
        }
    }
}
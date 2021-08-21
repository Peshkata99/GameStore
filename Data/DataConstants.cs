namespace GameStore.Data
{
    public class DataConstants
    {
        public class User
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 35;

            public const int PasswordMinLength = 6;
            public const int PasswordMaxLength = 100;
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
            public const int DescriptionMaxLength = 300;

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

        public class Review
        {
            public const int ContentMinLength = 10;
            public const int ContentMaxLength = 500;

            public const int StarMinCount = 1;
            public const int StarMaxCount = 5;
        }
    }
}
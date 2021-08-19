namespace GameStore.Services.Reviews
{
    using System;

    public class ReviewServiceModel
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int StarCount { get; set; }

        public string DisplayName { get; set; }

        public string UserId { get; set; }

        public DateTime PostedOn { get; set; }
    }
}

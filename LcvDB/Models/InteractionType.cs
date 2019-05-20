namespace LcvDB.Models
{
    public class InteractionType
    {
        public int Id { get; set; }

        public string InteractionTypeName { get; set; }

        public bool IsAdmin { get; set; } = false;
    }
}
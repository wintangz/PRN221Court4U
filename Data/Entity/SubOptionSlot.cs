using System.ComponentModel.DataAnnotations.Schema;

namespace Court4U_PRN.Data.Entity
{
    [Table("SubOptionSlot")]
    public class SubOptionSlot
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [ForeignKey("Slot")]
        public string SlotId { get; set; }
        public Slot Slot { get; set; }

        [ForeignKey("SubscriptionOption")]
        public string SubscriptionOptionId { get; set; }
        public SubscriptionOption SubscriptionOption { get; set; }
    }
}

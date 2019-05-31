using System;

namespace DataSources
{
    public class RecruiterInteraction
    {
        public int RecruiterInteractionId { get; set; }
        public RecruiterAgent Agent { get; set; }
        public DateTime InteractionDateTime { get; set; }
        public string Description { get; set; }
    }
}
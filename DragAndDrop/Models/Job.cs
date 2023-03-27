using System;

namespace DragAndDrop.Models
{
    public class Job
    {
        public int Id { get; set; }
        public JobStatus Status { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}

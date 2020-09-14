using System;
namespace brianwrightSite.Models
{
    public class Resume
    {
        public Resume()
        {

        }

        public int Id { get; set; }

        public string Role { get; set; }

        public string Company { get; set; }

        public string Description { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

    }
}

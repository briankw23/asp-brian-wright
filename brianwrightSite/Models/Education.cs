using System;
namespace brianwrightSite.Models
{
    public class Education
    {
        public Education()
        {

        }

        public int Id { get; set; }

        public string School { get; set; }

        public string DegreeCompleted { get; set; }

        public DateTime DateCompleted { get; set; }

        public string Image { get; set;}
        public string Url { get; set; }     

    }
}

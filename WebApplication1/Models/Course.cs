using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace WebApplication1.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public int GroupId { get; set; }

        [JsonIgnore]
        public Group? Group { get; set; }
        //public Group? Group { get; set; }
    }
}

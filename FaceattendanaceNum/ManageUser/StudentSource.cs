using System.ComponentModel;
using System.ComponentModel.Design;
namespace scanface.ManageUser
{
    public class StudentSource
    {
        [DisplayName("StudentID")]
        public int ID { get; set; }
        [DisplayName("Student Name")]
        public string Name { get; set; }
        [DisplayName("Generation")]
        public int Generation { get; set; }
        [DisplayName("Group")]
        public int Groups { get; set; }
        [DisplayName("Sex")]
        public string sex { get; set; }
        [DisplayName("Major")]
        public string MajorName { get; set; }
        [DisplayName("Image")]
        public byte[] image { get; set; }

    }
}

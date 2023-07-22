using Emgu.CV;
using Emgu.CV.Structure;

namespace FaceattendanaceNum.Model
{
    public  class UserModel
    {
        public byte[]? trainimages { get;set; }
        public int id { get;set; }
        public string? Name { get; set; }
    }
}

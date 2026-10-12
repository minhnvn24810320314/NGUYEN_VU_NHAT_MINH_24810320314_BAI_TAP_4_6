namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_4_6
{
    public class Student
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string AvatarPath { get; set; }

        public Student() { }

        public Student(string id, string name, int age, string gender, string avatarPath = "")
        {
            StudentId = id;
            FullName = name;
            Age = age;
            Gender = gender;
            AvatarPath = avatarPath;
        }
    }
}
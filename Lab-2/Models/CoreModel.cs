namespace Lab_2.Models
{
    public class CoreModel
    {
        public List<Group> Groups { get; set; } = new List<Group>();
        public Student NewStudent { get; set; } = new Student();
        public bool ShowGroups { get; set; } = false;
        public Group CurrentGroup { get; set; } = new Group();
        public string Message { get; set; } = "";

        public CoreModel(List<Group> groups)
        {
            Groups = groups;
        }

        public CoreModel()
        {
        }
    }
}

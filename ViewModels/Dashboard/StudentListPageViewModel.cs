namespace SimpleLoginUI.ViewModels.Dashboard
{
    public partial class StudentListPageViewModel : ObservableObject
    {
        public static List<StudentModel> StudentsListForSearch { get; private set; } = new List<StudentModel>();
        public ObservableCollection<StudentModel> Students { get; set; } = new ObservableCollection<StudentModel>();

        private readonly IStudentService _studentService;
        public StudentListPageViewModel(IStudentService studentService)
        {
            _studentService = studentService;
        }



        [ICommand]
        public async void GetStudentList()
        {
            Students.Clear();
            var studentList = await _studentService.GetStudentList();
            if (studentList?.Count > 0)
            {
                foreach (var student in studentList)
                {
                    Students.Add(student);
                }
                StudentsListForSearch.Clear();
                StudentsListForSearch.AddRange(studentList);
            }
        }


        [ICommand]
        public async void AddUpdateStudent()
        {
            await AppShell.Current.GoToAsync(nameof(AddUpdateStudentDetail));
        }


        [ICommand]
        public async void DisplayAction(StudentModel studentModel)
        {
            var response = await AppShell.Current.DisplayActionSheet("Select Option", "OK", null, "Details", "Edit", "Delete");
            if (response == "Details")
            {
                var navParam = new Dictionary<string, object>
                {
                    { "StudentDetail", studentModel }
                };
                await AppShell.Current.GoToAsync(nameof(StudentDetailsPage), navParam);
            }
            else if (response == "Edit")
            {
                var navParam = new Dictionary<string, object>
                {
                    { "StudentDetail", studentModel }
                };
                await AppShell.Current.GoToAsync(nameof(AddUpdateStudentDetail), navParam);
            }
            else if (response == "Delete")
            {
                var delResponse = await _studentService.DeleteStudent(studentModel);
                if (delResponse > 0)
                {
                    GetStudentList();
                }
            }
        }
    }
}

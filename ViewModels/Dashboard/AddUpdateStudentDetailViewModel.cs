namespace SimpleLoginUI.ViewModels.Dashboard
{
    [QueryProperty(nameof(StudentDetail), "StudentDetail")]
    public partial class AddUpdateStudentDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        private StudentModel _studentDetail = new StudentModel();

        private readonly IStudentService _studentService;
        public AddUpdateStudentDetailViewModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [ICommand]
        public async void AddUpdateStudent()
        {
            if (!string.IsNullOrWhiteSpace(StudentDetail.FirstName) && !string.IsNullOrWhiteSpace(StudentDetail.LastName) && !string.IsNullOrWhiteSpace(StudentDetail.Email))
            {
                AddUpdateStudentDetails();
            }
            else
            {
                await Shell.Current.DisplayAlert("Warning!", "Please Enter Required Fields", "OK");
            }


        }

        public async void AddUpdateStudentDetails()
        {
            int response = -1;
            if (StudentDetail.StudentID > 0)
            {
                response = await _studentService.UpdateStudent(StudentDetail);
            }
            else
            {
                response = await _studentService.AddStudent(new StudentModel
                {
                    Email = StudentDetail.Email,
                    FirstName = StudentDetail.FirstName,
                    LastName = StudentDetail.LastName,
                });
            }



            if (response > 0)
            {
                await Shell.Current.DisplayAlert("Student Info Saved", "Record Saved", "OK");
                await Shell.Current.GoToAsync($"StudentListPage");
                //wait AppShell.Current.GoToAsync(nameof(StudentListPage));
            }
            else
            {
                await Shell.Current.DisplayAlert("Heads Up!", "Something went wrong while adding record", "OK");
            }
        }
    }
}

namespace SimpleLoginUI.ViewModels.Dashboard
{
    [QueryProperty(nameof(StudentDetail), "StudentDetail")]
    public partial class StudentDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private StudentModel _studentDetail = new StudentModel();

        public ObservableCollection<StudentModel> Students { get; set; } = new ObservableCollection<StudentModel>();


    }
}

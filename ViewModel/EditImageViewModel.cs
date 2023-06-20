namespace MVCCRUD.ViewModel
{
    public class EditImageViewModel : UploadImageViewModel
    {
        public Guid Id { get; set; }
        public string ExistingImage { get; set; }
    }
}

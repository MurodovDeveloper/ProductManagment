using System.ComponentModel.DataAnnotations;

namespace MVCCRUD.ViewModel
{
    public class UploadImageViewModel
    {
        [Display(Name = "Picture")]
        public IFormFile ProducPicture { get; set; }
    }
}

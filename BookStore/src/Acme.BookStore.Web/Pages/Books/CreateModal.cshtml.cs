using Acme.BookStore.Books;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Acme.BookStore.Web.Pages.Books
{
    public class CreateModalModel : BookStorePageModel
    {
        //BindProperty���Խ������������ݰ󶨵�������
        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }
        public IBookAppService bookAppService;

        public CreateModalModel(IBookAppService bookAppService)
        {
            this.bookAppService = bookAppService;
        }

        public void OnGet()
        {
            Book = new CreateUpdateBookDto();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await bookAppService.CreateAsync(Book);
            return NoContent();
        }
    }
}

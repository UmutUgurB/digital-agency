using FluentValidation;

namespace digitalAgency.Application.Features.Blogs.Commands.UpdateBlog
{
    /// <summary>
    /// UpdateBlogCommand için validation kuralları
    /// </summary>
    public class UpdateBlogCommandValidator : AbstractValidator<UpdateBlogCommand>
    {
        public UpdateBlogCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Blog ID boş olamaz.");

            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Blog başlığı boş olamaz.")
                .MaximumLength(300).WithMessage("Blog başlığı maksimum 300 karakter olabilir.")
                .MinimumLength(3).WithMessage("Blog başlığı en az 3 karakter olmalıdır.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Blog açıklaması boş olamaz.")
                .MinimumLength(10).WithMessage("Blog açıklaması en az 10 karakter olmalıdır.")
                .MaximumLength(10000).WithMessage("Blog açıklaması maksimum 10000 karakter olabilir.");

            RuleFor(x => x.ImageUrl)
                .NotEmpty().WithMessage("Görsel URL'i boş olamaz.")
                .Must(BeAValidUrl).WithMessage("Geçerli bir URL giriniz.");

            RuleFor(x => x.Status)
                .IsInEnum().WithMessage("Geçersiz blog durumu.");

            RuleFor(x => x.BlogCategoryName)
                .NotEmpty().WithMessage("Blog kategorisi seçilmelidir.")
                .MaximumLength(100).WithMessage("Kategori adı maksimum 100 karakter olabilir.");

            RuleFor(x => x.TagNames)
                .NotNull().WithMessage("Tag listesi null olamaz.")
                .Must(x => x == null || x.Count <= 10)
                .WithMessage("Maksimum 10 tag ekleyebilirsiniz.");

            RuleForEach(x => x.TagNames)
                .MaximumLength(50).WithMessage("Tag adı maksimum 50 karakter olabilir.")
                .When(x => x.TagNames != null && x.TagNames.Any());
        }

        private bool BeAValidUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return false;

            return Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
    }
}




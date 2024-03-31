using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _GaleryPartial : ViewComponent
	{
		private readonly IImageService _ımageService;

		public _GaleryPartial(IImageService ımageService)
		{
			_ımageService = ımageService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _ımageService.GetListAll();
			return View(values);
		}
	}
}

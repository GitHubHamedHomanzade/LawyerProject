using Lawyer.Models.Slider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lawyer.Service.SliderService
{
    public interface ISliderService : IDisposable
    {
        Task AddSlider(Slider slider);
        void EditSlider(Slider slider);
        Task DeleteSlider(Guid Id);
        Task DeActiveSlider(Guid Id);
        Task ActiveSlider(Guid Id);
        IQueryable<Slider> GetAllSlider();
        IQueryable<Slider> GetAllActiveSliders();
        Task<Slider> GetSliderById(Guid Id);
        Task<Slider> GetSliderByImagePath(string ImagePath);
        Task<Slider> GetSliderByImageTitle(string Title);


    }
}

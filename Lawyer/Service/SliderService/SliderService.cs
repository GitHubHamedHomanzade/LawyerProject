using Lawyer.Context;
using Lawyer.Generic.Repository;
using Lawyer.Models.Account;
using Lawyer.Models.Slider;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lawyer.Service.SliderService
{
    public class SliderService : ISliderService
    {
        #region constractor
        private IGenericRepository<Slider> _sliderRepository;
        private MyContext _context;
        private DbSet<Slider> dbSet;

        public SliderService(IGenericRepository<Slider> sliderRepository, MyContext context)
        {
            _sliderRepository = sliderRepository;
            _context = context;
            this.dbSet = this._context.Set<Slider>();

        }
        #endregion

        public async Task  ActiveSlider(Guid Id)
        {
            var slider =await _sliderRepository.GetEntityById(Id);
            slider.IsActive = true;
            _sliderRepository.UpdateEntity(slider);
        }

        public async Task AddSlider(Slider slider)
        {
            await _sliderRepository.AddEntity(slider);
        }

        public async Task DeActiveSlider(Guid Id)
        {
            await _sliderRepository.RemoveEntityById(Id);
        }

        public async Task DeleteSlider(Guid Id)
        {
            await _sliderRepository.RemoveEntityById(Id);
        }

        public void Dispose()
        {
            _sliderRepository?.Dispose();
        }

        public void EditSlider(Slider slider)
        {
            _sliderRepository.UpdateEntity(slider);
        }

        public IQueryable<Slider> GetAllActiveSliders()
        {
            return _sliderRepository.GetEntitiesQuery().Where(s => s.IsActive == true);
        }

        public IQueryable<Slider> GetAllSlider()
        {
            return _sliderRepository.GetEntitiesQuery();
        }

        public async Task<Slider> GetSliderById(Guid Id)
        {
            return await _sliderRepository.GetEntityById(Id);
        }

        public Task<Slider> GetSliderByImagePath(string ImagePath)
        {
            var slider = _sliderRepository.GetEntitiesQuery().FirstOrDefaultAsync(s => s.ImagePath == ImagePath);
            return slider;
        }

        public Task<Slider> GetSliderByImageTitle(string Title)
        {
            var slider = _sliderRepository.GetEntitiesQuery().FirstOrDefaultAsync(s => s.Title == Title);
            return slider;
        }


    }
}

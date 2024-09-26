using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Database.DBcontext;
using LIMS.Infrastructure.Repository.Commands.BaseCommand;
using Microsoft.EntityFrameworkCore;

namespace LIMS.Infrastructure.Repository.Commands
{
    public class InstrumentCommandRepository : BaseCommandRepository<Instrument>, IInstrumentCommandRepository
    {
        private DataContext _dataContext;

        public InstrumentCommandRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public override async Task<Instrument> CreateAsync(Instrument entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("No Instrument data provided");
            }

            try
            {
                //var existingLab = await _dataContext.Set<Laboratory>().FindAsync(entity.LaboratoryId);
                //if (existingLab is null)
                //{
                //    throw new KeyNotFoundException("No matching Instrument found");
                //}
                //_dataContext.Entry(entity.Laboratory).State = EntityState.Unchanged;
                //// Create and add the new instrument
                //entity.Laboratory = existingLab;
                var addedInstrument = _dataContext.Instruments.Add(entity);
                await _dataContext.SaveChangesAsync();
                return addedInstrument.Entity;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw new Exception("An error occurred while adding the instrument.", ex);
            }
        }

        public override async Task<Instrument> UpdateAsync(Instrument newInstrumentData)
        {
            if (newInstrumentData is null)
            {
                throw new ArgumentNullException("No Instrument data provided");
            }

            try
            {
                var existingInstrumentData = await _dataContext.Set<Instrument>().FindAsync(newInstrumentData.InstrumentId);
                if (existingInstrumentData is null)
                {
                    throw new KeyNotFoundException("No matching Instrument found");
                }

                existingInstrumentData.Name = newInstrumentData.Name ?? existingInstrumentData.Name;
                existingInstrumentData.Manufacturer = newInstrumentData.Manufacturer ?? existingInstrumentData.Manufacturer;
                existingInstrumentData.Quantity = newInstrumentData.Quantity;
                existingInstrumentData.PurchaseDate = newInstrumentData.PurchaseDate != default ? newInstrumentData.PurchaseDate : existingInstrumentData.PurchaseDate;
                existingInstrumentData.ExpiryDate = newInstrumentData.ExpiryDate != default ? newInstrumentData.ExpiryDate : existingInstrumentData.ExpiryDate;
                existingInstrumentData.AdditionalNotes = newInstrumentData.AdditionalNotes ?? existingInstrumentData.AdditionalNotes;

                _dataContext.Set<Instrument>().Update(existingInstrumentData);
                _dataContext.Entry(existingInstrumentData).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();
                return existingInstrumentData;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}

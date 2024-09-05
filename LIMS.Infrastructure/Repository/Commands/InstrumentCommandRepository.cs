﻿using LIMS.Domain.Interfaces.Repository.Commands;
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

        public override async Task<Instrument> UpdateAsync(Instrument entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("No instrument data provided");
            }

            try
            {
                var existingInstrument = await _dataContext.Set<Instrument>().FindAsync(entity.Id);
                if (existingInstrument is null)
                {
                    throw new KeyNotFoundException("No matching Laboratory found");
                }

                existingInstrument.Name = entity.Name ?? existingInstrument.Name;
                existingInstrument.Manufacturer = entity.Manufacturer ?? existingInstrument.Manufacturer;
                existingInstrument.PurchaseDate = entity.PurchaseDate != default ? entity.PurchaseDate : existingInstrument.PurchaseDate;
                existingInstrument.ExpiryDate = entity.ExpiryDate != default ? entity.ExpiryDate : entity.ExpiryDate;
                existingInstrument.CalibrationRecord = entity.CalibrationRecord ?? existingInstrument.CalibrationRecord;
                existingInstrument.AdditionalNotes = entity.AdditionalNotes ?? existingInstrument.AdditionalNotes;

                _dataContext.Set<Instrument>().Update(existingInstrument);
                _dataContext.Entry(existingInstrument).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();
                return existingInstrument;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
using LIMS.Application.Commands.Instrument;
using LIMS.Application.Queries.Instrument;
using LIMS.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LIMS.WebAPI.Controllers
{
    public class InstrumentController : BaseController
    {
        public InstrumentController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("GetAllInstruments")]
        public async Task<IEnumerable<InstrumentResponse>> GetAllInstruments()
        {
            var instrumentData = await _mediator.Send(new GetAllInstrumentsQuery());
            return instrumentData;
        }

        [HttpGet("GetInstrument/{id}")]
        public async Task<InstrumentResponse> GetInstrument(int id)
        {
            var instrumentData = await _mediator.Send(new GetInstrumentByIdQuery(id));
            return instrumentData;
        }

        [HttpPost("CreateInstrument")]
        public async Task<InstrumentResponse> CreateInstrument(CreateInstrumentCommand newInstrumentData)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new BadHttpRequestException("Invalid data provided");
                }

                var instrument = await _mediator.Send(newInstrumentData);
                return instrument;
            }
            catch (Exception ex)
            {
                throw new BadHttpRequestException("Bad Request", ex);
            }
        }

        [HttpPost]
        [Route("UpdateInstrument")]
        public async Task<InstrumentResponse> UpdateInstrument(UpdateInstrumentCommand newInstrumentData)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new BadHttpRequestException("Invalid data provided");
                }

                var updatedInstrument = await _mediator.Send(newInstrumentData);
                return updatedInstrument;
            }
            catch (Exception ex)
            {
                throw new BadHttpRequestException("Bad Request", ex);
            }
        }

        [HttpDelete]
        [Route("DeleteInstrument/{id}")]
        public async Task<string> DeleteInstrument(int id)
        {
            try
            {
                await _mediator.Send(new DeleteInstrumentCommand(id));
                return "Instrument deleted successfully!";
            }
            catch (Exception ex)
            {
                throw new BadHttpRequestException(ex.ToString());
            }
        }
    }
}

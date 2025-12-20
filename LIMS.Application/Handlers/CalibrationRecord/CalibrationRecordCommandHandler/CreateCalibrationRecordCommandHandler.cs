using LIMS.Application.Commands.CalibrationRecord;
using LIMS.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Application.Handlers.CalibrationRecord.CalibrationRecordCommandHandler
{
    public class CreateCalibrationRecordCommandHandler : IRequestHandler<CreateCalibrationRecordCommand, CalibrationRecordResponse>
    {
        Task<CalibrationRecordResponse> IRequestHandler<CreateCalibrationRecordCommand, CalibrationRecordResponse>.Handle(CreateCalibrationRecordCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

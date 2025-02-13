using MediatR;

namespace LIMS.Application.Commands.CalibrationRecord
{
    public class DeleteCalibrationRecordCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public DeleteCalibrationRecordCommand(int Id)
        {
            this.Id = Id;
        }
    }
}

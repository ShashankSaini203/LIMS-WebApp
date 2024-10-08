﻿using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.CalibrationRecord
{
    public class DeleteCalibrationRecordCommand : IRequest<Unit>
    {
        [Required]
        public int Id { get; set; }

        public DeleteCalibrationRecordCommand(int Id)
        {
            this.Id = Id;
        }
    }
}

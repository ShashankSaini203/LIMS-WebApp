﻿using MediatR;
using LIMS.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.Laboratory
{
    public class DeleteLaboratoryCommand : IRequest<Unit>
    {
        [Required]
        public int Id { get; set; }

        public DeleteLaboratoryCommand(int Id)
        {
            this.Id = Id;
        }
    }
}

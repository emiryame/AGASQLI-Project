using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.Dto.Mapping
{
    public static class StatutMapping
    {
        public static Dto.Statut EntityToDto(Data.Statut statut)
        {
            Dto.Statut statutDto = new Statut();

            statutDto.Code = statut.Code;
            statutDto.Id = statut.Id;
            statutDto.Label = statut.Label;

            return statutDto;
        }

    }
}

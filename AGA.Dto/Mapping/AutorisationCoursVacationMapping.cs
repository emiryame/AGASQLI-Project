using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.Dto.Mapping
{
    public static class AutorisationCoursVacationMapping
    {
        public static Dto.AutorisationCoursVacation EntityToDto(Data.AutorisationCoursVacation autorisationCoursVacation)
        {
            Dto.AutorisationCoursVacation autorisationCoursVacationDto = new AutorisationCoursVacation();

            autorisationCoursVacationDto.AnneeScolaire = autorisationCoursVacation.AnneeScolaire;
            autorisationCoursVacationDto.Etablissement = autorisationCoursVacation.Etablissement;
            autorisationCoursVacationDto.Id = autorisationCoursVacation.Id;

            return autorisationCoursVacationDto;
        }
    }
}

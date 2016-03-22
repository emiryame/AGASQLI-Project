using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.Dto.Mapping
{
    public static class AutorisationPoursuiteEtudesMapping
    {
        public static Dto.AutorisationPoursuiteEtudes EntityToDto(Data.AutorisationPoursuiteEtudes autorisationPoursuiteEtudes)
        {
            Dto.AutorisationPoursuiteEtudes autorisationPoursuiteEtudesDto = new AutorisationPoursuiteEtudes();

            autorisationPoursuiteEtudesDto.AnneeScolaire = autorisationPoursuiteEtudes.AnneeScolaire;
            autorisationPoursuiteEtudesDto.Etablissement = autorisationPoursuiteEtudes.Etablissement;
            autorisationPoursuiteEtudesDto.Id = autorisationPoursuiteEtudes.Id;

            return autorisationPoursuiteEtudesDto;
        }
    }
}

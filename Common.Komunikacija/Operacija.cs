using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Komunikacija
{
    public enum Operacija
    {
        NadjiKorisnika,
        Kraj,
        ZapamtiClana,
        PretraziClanove,
        VratiClanove,
        PretraziZaduzenja, //VratiZaduzenjaClana
        IzmeniClana,
        ObrisiClana,
        ZapamtiClanarinu,
        IzbrisiClanarinu,
        VratiClanarine,
        PretraziIgrice,
        VratiIgrice,
        PretraziPrimerke,
        ZapamtiZaduzenje,
        VratiZaduzenja,
        VratiPrimerkeZaduzenja,
        IzmeniZaduzenje //izmena zaduzenja

    }
}

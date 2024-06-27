using FiscalBr.Common;
using FiscalBr.Common.Sped;
using System;

namespace FiscalBr.ECF
{
    public class BlocoV
    {
        public class RegV001 : RegistroSped
        {
            public RegV001() : base("V001")
            {
            }

            [SpedCampos(2, "IND_DAD", "N", 1, 0, true, 2)]
            public int IndDad { get; set; }
        }

        public class RegV990 : RegistroSped
        {
            public RegV990() : base("Q990")
            {
            }

            [SpedCampos(2, "QTD_LIN", "N", int.MaxValue, 0, true, 2)]
            public int QtdLin { get; set; }
        }
    }
}
using FiscalBr.Common;
using FiscalBr.Common.Sped;
using System;

namespace FiscalBr.ECF
{
    public class BlocoJ
    {
        public class RegJ001 : RegistroSped
        {
            public RegJ001() : base("J001")
            {
            }

            /// <summary>
            ///     Valores validos: [0;1]
            /// </summary>
            [SpedCampos(2, "IND_DAD", "N", 1, 0, true, 2)]
            public int IndDad { get; set; }
        }

        public class RegJ050 : RegistroSped
        {
            public RegJ050() : base("J050")
            {
            }

            [SpedCampos(2, "DT_ALT", "N", 8, 0, true, 2)]
            public DateTime DtAlt { get; set; }

            [SpedCampos(3, "COD_NAT", "C", 2, 0, true, 2)]
            public string CodNat { get; set; }

            [SpedCampos(4, "IND_CTA", "C", 1, 0, true, 2)]
            public string IndCta { get; set; }

            [SpedCampos(5, "NÍVEL", "N", 1, 0, true, 2)]
            public int Nivel { get; set; }

            [SpedCampos(6, "COD_CTA", "C", 0, 0, true, 2)]
            public string CodCta { get; set; }

            [SpedCampos(7, "COD_CTA_SUP", "C", 0, 0, false, 2)]
            public string CodCtaSup { get; set; }

            [SpedCampos(8, "CTA", "C", 0, 0, true, 2)]
            public string Cta { get; set; }
        }

        public class RegJ051 : RegistroSped
        {
            public RegJ051() : base("J051")
            {
            }

            [SpedCampos(2, "COD_CCUS", "C", 0, 0, false, 2)]
            public string CodCus { get; set; }

            [SpedCampos(3, "COD_CTA_REF", "C", 0, 0, true, 2)]
            public string CodCtaRef { get; set; }
        }

        public class RegJ053 : RegistroSped
        {
            public RegJ053() : base("J053")
            {
            }

            [SpedCampos(2, "COD_IDT", "C", 6, 0, true, 2)]
            public string CodIdt { get; set; }

            [SpedCampos(3, "COD_CNT_CORR", "C", 0, 0, true, 2)]
            public string CodCntCorr { get; set; }

            [SpedCampos(4, "NAT_SUB_CNT", "C", 2, 0, true, 2)]
            public string NatSubCnt { get; set; }
        }

        public class RegJ100 : RegistroSped
        {
            public RegJ100() : base("J100")
            {
            }

            [SpedCampos(2, "DT_ALT", "N", 8, 0, true, 2)]
            public DateTime DtAlt { get; set; }

            [SpedCampos(3, "COD_CCUS", "C", 0, 0, true, 2)]
            public string CodCus { get; set; }

            [SpedCampos(4, "CCUS", "C", 0, 0, true, 2)]
            public string CCus { get; set; }
        }

        public class RegJ990 : RegistroSped
        {
            public RegJ990() : base("J990")
            {
            }

            [SpedCampos(2, "QTD_LIN", "N", int.MaxValue, 0, true, 2)]
            public int QtdLin { get; set; }
        }
    }
}
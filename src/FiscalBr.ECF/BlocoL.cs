using FiscalBr.Common;
using FiscalBr.Common.Sped;
using System;

namespace FiscalBr.ECF
{
    public class BlocoL
    {
        public class RegL001 : RegistroSped
        {
            public RegL001() : base("L001")
            {
            }

            [SpedCampos(2, "IND_DAD", "N", 1, 0, true, 2)]
            public int IndDad { get; set; }
        }

        public class RegL030 : RegistroSped
        {
            public RegL030() : base("L030")
            {
            }

            [SpedCampos(2, "DT_INI", "N", 8, 0, true, 2)]
            public DateTime DtIni { get; set; }

            [SpedCampos(3, "DT_FIN", "N", 8, 0, true, 2)]
            public DateTime DtFin { get; set; }

            [SpedCampos(4, "PER_APUR", "C", 3, 0, true, 2)]
            public string PerApur { get; set; }
        }

        public class RegL100 : RegistroSped
        {
            public RegL100() : base("L100")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 50, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "TIPO", "C", 1, 0, true, 2)]
            public string Tipo { get; set; }

            [SpedCampos(5, "NIVEL", "N", 3, 0, false, 2)]
            public int Nivel { get; set; }

            [SpedCampos(6, "COD_NAT", "C", 2, 0, false, 2)]
            public string CodNat { get; set; }

            [SpedCampos(7, "COD_CTA_SUP", "C", 0, 0, false, 2)]
            public string CodCtaSup { get; set; }

            [SpedCampos(8, "VAL_CTA_REF_INI", "N", 19, 2, true, 2)]
            public decimal ValCtaRefIni { get; set; }

            [SpedCampos(9, "IND_VAL_CTA_REF_INI", "C", 1, 0, true, 2)]
            public string IndValCtaRefIni { get; set; }

            [SpedCampos(10, "VAL_CTA_REF_FIN", "N", 19, 2, true, 2)]
            public decimal ValCtaRefFin { get; set; }

            [SpedCampos(11, "IND_VAL_CTA_REF_FIN", "C", 1, 0, true, 2)]
            public string IndValCtaRefFin { get; set; }
        }

        public class RegL200 : RegistroSped
        {
            public RegL200() : base("L200")
            {
            }

            [SpedCampos(2, "IND_AVAL_ESTOQ", "C", 1, 0, true, 2)]
            public string IndAvalEstoq { get; set; }
        }

        public class RegL210 : RegistroSped
        {
            public RegL210() : base("L210")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal Valor { get; set; }
        }

        public class RegL300 : RegistroSped
        {
            public RegL300() : base("L300")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 50, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "TIPO", "C", 1, 0, true, 2)]
            public string Tipo { get; set; }

            [SpedCampos(5, "NIVEL", "N", 3, 0, false, 2)]
            public int Nivel { get; set; }

            [SpedCampos(6, "COD_NAT", "C", 1, 0, false, 2)]
            public string CodNat { get; set; }

            [SpedCampos(7, "COD_CTA_SUP", "C", 0, 0, false, 2)]
            public string CodCtaSup { get; set; }

            [SpedCampos(8, "VALOR", "N", 19, 2, true, 2)]
            public decimal Valor { get; set; }

            [SpedCampos(9, "IND_VALOR", "C", 1, 0, true, 2)]
            public string IndValor { get; set; }
        }

        public class RegL990 : RegistroSped
        {
            public RegL990() : base("L990")
            {
            }

            [SpedCampos(2, "QTD_LIN", "N", int.MaxValue, 0, true, 2)]
            public int QtdLin { get; set; }
        }
    }
}
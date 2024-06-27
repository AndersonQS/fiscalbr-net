using FiscalBr.Common;
using FiscalBr.Common.Sped;
using System;

namespace FiscalBr.ECF
{
    public class BlocoP
    {
        public class RegP001 : RegistroSped
        {
            public RegP001() : base("P001")
            {
            }

            [SpedCampos(2, "IND_DAD", "N", 1, 0, true, 2)]
            public int IndDad { get; set; }
        }

        public class RegP030 : RegistroSped
        {
            public RegP030() : base("P030")
            {
            }

            [SpedCampos(2, "DT_INI", "N", 8, 0, true, 2)]
            public DateTime DtIni { get; set; }

            [SpedCampos(3, "DT_FIN", "N", 8, 0, true, 2)]
            public DateTime DtFin { get; set; }

            [SpedCampos(4, "PER_APUR", "C", 3, 0, true, 2)]
            public string PerApur { get; set; }
        }

        public class RegP100 : RegistroSped
        {
            public RegP100() : base("P100")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 50, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 60, 0, false, 2)]
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

            [SpedCampos(11, "IND_ VAL_CTA_REF_FIN", "C", 1, 0, true, 2)]
            public string IndValCtaRefFin { get; set; }
        }

        public class RegP130 : RegistroSped
        {
            public RegP130() : base("P130")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 60, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 60, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegP150 : RegistroSped
        {
            public RegP150() : base("P150")
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

            [SpedCampos(9, "IND_ VALOR", "C", 1, 0, true, 2)]
            public string IndValor { get; set; }
        }

        public class RegP200 : RegistroSped
        {
            public RegP200() : base("P200")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 60, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 60, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegP230 : RegistroSped
        {
            public RegP230() : base("P230")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 60, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 60, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegP300 : RegistroSped
        {
            public RegP300() : base("P300")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 60, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 60, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegP400 : RegistroSped
        {
            public RegP400() : base("P400")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 60, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 60, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegP500 : RegistroSped
        {
            public RegP500() : base("P500")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 60, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 60, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegP990 : RegistroSped
        {
            public RegP990() : base("P990")
            {
            }

            [SpedCampos(2, "QTD_LIN", "N", int.MaxValue, 0, true, 2)]
            public int QtdLin { get; set; }
        }
    }
}
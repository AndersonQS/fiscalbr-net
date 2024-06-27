using FiscalBr.Common;
using FiscalBr.Common.Sped;
using System;

namespace FiscalBr.ECF
{
    public class BlocoU
    {
        public class RegU001 : RegistroSped
        {
            public RegU001() : base("U001")
            {
            }

            [SpedCampos(2, "IND_DAD", "N", 1, 0, true, 2)]
            public int IndDad { get; set; }
        }

        public class RegU030 : RegistroSped
        {
            public RegU030() : base("U030")
            {
            }

            [SpedCampos(2, "DT_INI", "N", 8, 0, true, 2)]
            public DateTime DtIni { get; set; }

            [SpedCampos(3, "DT_FIN", "N", 8, 0, true, 2)]
            public DateTime DtFin { get; set; }

            [SpedCampos(4, "PER_APUR", "C", 3, 0, true, 2)]
            public string PerApur { get; set; }
        }

        public class RegU100 : RegistroSped
        {
            public RegU100() : base("U100")
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

            [SpedCampos(11, "IND_ VAL_CTA_REF_FIN", "C", 1, 0, true, 2)]
            public string IndValCtaRefFin { get; set; }
        }

        public class RegU150 : RegistroSped
        {
            public RegU150() : base("U150")
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

        public class RegU180 : RegistroSped
        {
            public RegU180() : base("U180")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegU182 : RegistroSped
        {
            public RegU182() : base("U182")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegU990 : RegistroSped
        {
            public RegU990() : base("U990")
            {
            }

            [SpedCampos(2, "QTD_LIN", "N", int.MaxValue, 0, true, 2)]
            public int QtdLin { get; set; }
        }
    }
}
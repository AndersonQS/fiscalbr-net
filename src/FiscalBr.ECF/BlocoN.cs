using FiscalBr.Common;
using FiscalBr.Common.Sped;
using System;

namespace FiscalBr.ECF
{
    public class BlocoN
    {
        public class RegN001 : RegistroSped
        {
            public RegN001() : base("N001")
            {
            }

            [SpedCampos(2, "IND_DAD", "N", 1, 0, true, 2)]
            public int IndDad { get; set; }
        }

        public class RegN030 : RegistroSped
        {
            public RegN030() : base("N030")
            {
            }

            [SpedCampos(2, "DT_INI", "N", 8, 0, true, 2)]
            public DateTime DtIni { get; set; }

            [SpedCampos(3, "DT_FIN", "N", 8, 0, true, 2)]
            public DateTime DtFin { get; set; }

            [SpedCampos(4, "PER_APUR", "C", 3, 0, true, 2)]
            public string PerApur { get; set; }
        }

        public class RegN500 : RegistroSped
        {
            public RegN500() : base("N500")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegN600 : RegistroSped
        {
            public RegN600() : base("N600")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegN610 : RegistroSped
        {
            public RegN610() : base("N610")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegN615 : RegistroSped
        {
            public RegN615() : base("N615")
            {
            }

            [SpedCampos(2, "BASE_CALC", "N", 19, 2, true, 2)]
            public decimal BaseCalc { get; set; }

            [SpedCampos(3, "PER_INCEN_ FINOR", "N", 8, 1, true, 2)]
            public decimal PerIncenFinor { get; set; }

            [SpedCampos(4, "VL_LIQ_INCEN_ FINOR", "NS", 19, 2, true, 2)]
            public decimal VlLiqIncenFinor { get; set; }

            [SpedCampos(5, "PER_INCEN_ FINAM", "N", 8, 4, true, 2)]
            public decimal PerIncenFinam { get; set; }

            [SpedCampos(6, "VL_LIQ_INCEN_FINAM", "NS", 19, 2, true, 2)]
            public decimal VlLiqIncenFinam { get; set; }

            [SpedCampos(7, "VL_TOTAL", "NS", 19, 2, true, 2)]
            public decimal VlTotal { get; set; }
        }

        public class RegN620 : RegistroSped
        {
            public RegN620() : base("N620")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegN630 : RegistroSped
        {
            public RegN630() : base("N630")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegN650 : RegistroSped
        {
            public RegN650() : base("N650")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegN660 : RegistroSped
        {
            public RegN660() : base("N660")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegN670 : RegistroSped
        {
            public RegN670() : base("N670")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegN990 : RegistroSped
        {
            public RegN990() : base("N990")
            {
            }

            [SpedCampos(2, "QTD_LIN", "N", int.MaxValue, 0, true, 2)]
            public int QtdLin { get; set; }
        }
    }
}
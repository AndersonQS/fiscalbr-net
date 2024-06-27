using FiscalBr.Common;
using FiscalBr.Common.Sped;
using System;

namespace FiscalBr.ECF
{
    public class BlocoM
    {
        public class RegM001 : RegistroSped
        {
            public RegM001() : base("M001")
            {
            }

            [SpedCampos(2, "IND_DAD", "N", 1, 0, true, 2)]
            public int IndDad { get; set; }
        }

        public class RegM010 : RegistroSped
        {
            public RegM010() : base("M010")
            {
            }

            [SpedCampos(2, "COD_CTA_B", "C", 0, 0, true, 2)]
            public string CodCtaB { get; set; }

            [SpedCampos(3, "DESC_CTA_LAL", "C", 0, 0, true, 2)]
            public string DescCtaLal { get; set; }

            [SpedCampos(4, "DT_AP_LAL", "C", 8, 0, true, 2)]
            public DateTime DtApLal { get; set; }

            [SpedCampos(5, "COD_LAN_ORIG", "C", 6, 0, false, 2)]
            public string CodLanOrig { get; set; }

            [SpedCampos(6, "DESC_LAN_ORIG", "C", 0, 0, false, 2)]
            public string DescLanOrig { get; set; }

            [SpedCampos(7, "DT_LIM_LAL", "C", 8, 0, false, 2)]
            public DateTime? DtLimLal { get; set; }

            [SpedCampos(8, "COD_TRIBUTO", "C", 1, 0, true, 2)]
            public string CodTributo { get; set; }

            [SpedCampos(9, "VL_SALDO_INI", "N", 19, 2, true, 2)]
            public decimal VlSaldoIni { get; set; }

            [SpedCampos(10, "IND_VL_SALDO_INI", "C", 1, 0, true, 2)]
            public string IndVlSaldoIni { get; set; }

            [SpedCampos(11, "CNPJ_SIT_ESP", "N", 14, 0, false, 2)]
            public string CnpjSitEsp { get; set; }
        }

        public class RegM030 : RegistroSped
        {
            public RegM030() : base("M030")
            {
            }

            [SpedCampos(2, "DT_INI", "N", 8, 0, true, 2)]
            public DateTime DtIni { get; set; }

            [SpedCampos(3, "DT_FIN", "N", 8, 0, true, 2)]
            public DateTime DtFin { get; set; }

            [SpedCampos(4, "PER_APUR", "C", 3, 0, true, 2)]
            public string PerApur { get; set; }
        }

        public class RegM300 : RegistroSped
        {
            public RegM300() : base("M300")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "TIPO_LANCAMENTO", "C", 1, 0, false, 2)]
            public string TipoLancamento { get; set; }

            [SpedCampos(5, "IND_RELACAO", "N", 1, 0, false, 2)]
            public int IndRelacao { get; set; }

            [SpedCampos(6, "VALOR", "NS", 19, 2, false, 2)]
            public decimal Valor { get; set; }

            [SpedCampos(7, "HIST_LAN_LAL", "C", 500, 0, false, 2)]
            public string HistLanLal { get; set; }
        }

        public class RegM305 : RegistroSped
        {
            public RegM305() : base("M305")
            {
            }

            [SpedCampos(2, "COD_CTA_B", "C", 0, 0, true, 2)]
            public string CodCtaB { get; set; }

            [SpedCampos(3, "VL_CTA", "N", 19, 2, true, 2)]
            public decimal VlCta { get; set; }

            [SpedCampos(4, "IND_VL_CTA", "C", 1, 0, true, 2)]
            public string IndVlCta { get; set; }
        }

        public class RegM310 : RegistroSped
        {
            public RegM310() : base("M310")
            {
            }

            [SpedCampos(2, "COD_CTA", "C", 0, 0, true, 2)]
            public string CodCta { get; set; }

            [SpedCampos(3, "COD_CCUS", "C", 0, 0, false, 2)]
            public string CodCcus { get; set; }

            [SpedCampos(4, "VL_CTA", "N", 19, 2, true, 2)]
            public decimal VlCta { get; set; }

            [SpedCampos(5, "IND_VL_CTA", "C", 1, 0, true, 2)]
            public string IndVlCta { get; set; }
        }

        public class RegM312 : RegistroSped
        {
            public RegM312() : base("M312")
            {
            }

            [SpedCampos(2, "NUM_LCTO", "C", 50, 0, true, 2)]
            public string NumLcto { get; set; }
        }

        public class RegM315 : RegistroSped
        {
            public RegM315() : base("M315")
            {
            }

            [SpedCampos(2, "IND_PROC", "C", 1, 0, true, 2)]
            public int IndProc { get; set; }

            [SpedCampos(3, "NUM_PROC", "C", 20, 0, true, 2)]
            public string NumProc { get; set; }
        }

        public class RegM350 : RegistroSped
        {
            public RegM350() : base("M350")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "TIPO_LANCAMENTO", "C", 1, 0, false, 2)]
            public string TipoLancamento { get; set; }

            [SpedCampos(5, "IND_RELACAO", "N", 1, 0, false, 2)]
            public int IndRelacao { get; set; }

            [SpedCampos(6, "VALOR", "NS", 19, 2, false, 2)]
            public decimal Valor { get; set; }

            [SpedCampos(7, "HIST_LAN_LAL", "C", 500, 0, false, 2)]
            public string HistLanLal { get; set; }
        }

        public class RegM355 : RegistroSped
        {
            public RegM355() : base("M355")
            {
            }

            [SpedCampos(2, "COD_CTA_B", "C", 0, 0, true, 2)]
            public string CodCtaB { get; set; }

            [SpedCampos(3, "VL_CTA", "N", 19, 2, true, 2)]
            public decimal VlCta { get; set; }

            [SpedCampos(4, "IND_VL_CTA", "C", 1, 0, true, 2)]
            public string IndVlCta { get; set; }
        }

        public class RegM360 : RegistroSped
        {
            public RegM360() : base("M360")
            {
            }

            [SpedCampos(2, "COD_CTA", "C", 0, 0, true, 2)]
            public string CodCta { get; set; }

            [SpedCampos(3, "COD_CCUS", "C", 0, 0, false, 2)]
            public string CodCcus { get; set; }

            [SpedCampos(4, "VL_CTA", "N", 19, 2, true, 2)]
            public decimal VlCta { get; set; }

            [SpedCampos(5, "IND_VL_CTA", "C", 1, 0, true, 2)]
            public string IndVlCta { get; set; }
        }

        public class RegM362 : RegistroSped
        {
            public RegM362() : base("M362")
            {
            }

            [SpedCampos(2, "NUM_LCTO", "C", 50, 0, true, 2)]
            public string NumLcto { get; set; }
        }

        public class RegM365 : RegistroSped
        {
            public RegM365() : base("M365")
            {
            }

            [SpedCampos(2, "IND_PROC", "C", 1, 0, true, 2)]
            public int IndProc { get; set; }

            [SpedCampos(3, "NUM_PROC", "C", 20, 0, true, 2)]
            public string NumProc { get; set; }
        }

        public class RegM410 : RegistroSped
        {
            public RegM410() : base("M410")
            {
            }

            [SpedCampos(2, "COD_CTA_B", "C", 0, 0, false, 2)]
            public string CodCtaB { get; set; }

            [SpedCampos(3, "COD_TRIBUTO", "C", 1, 0, true, 2)]
            public string CodTributo { get; set; }

            [SpedCampos(4, "VAL_LAN_LALB_PB", "N", 19, 2, true, 2)]
            public decimal ValLanLalbPb { get; set; }

            [SpedCampos(5, "IND_VAL_LAN_LALB_P", "C", 0, 0, true, 2)]
            public string IndValLanLalbP { get; set; }

            [SpedCampos(6, "COD_CTA_B_CTP", "C", 0, 0, false, 2)]
            public string CodCtaBCtp { get; set; }

            [SpedCampos(7, "HIST_LAN_LALB", "C", 0, 0, true, 2)]
            public string HistLanLalb { get; set; }

            [SpedCampos(8, "IND_LAN_ANT", "C", 1, 0, true, 2)]
            public string IndLanAnt { get; set; }
        }

        public class RegM415 : RegistroSped
        {
            public RegM415() : base("M415")
            {
            }

            [SpedCampos(2, "IND_PROC", "C", 1, 0, true, 2)]
            public int IndProc { get; set; }

            [SpedCampos(3, "NUM_PROC", "C", 20, 0, true, 2)]
            public string NumProc { get; set; }
        }

        public class RegM500 : RegistroSped
        {
            public RegM500() : base("M500")
            {
            }

            [SpedCampos(2, "COD_CTA_B", "C", 0, 0, true, 2)]
            public string CodCtaB { get; set; }

            [SpedCampos(3, "COD_TRIBUTO", "C", 1, 0, true, 2)]
            public string CodTributo { get; set; }

            [SpedCampos(4, "SD_INI_LAL", "N", 19, 2, true, 2)]
            public decimal SdIniLal { get; set; }

            [SpedCampos(5, "IND_SD_INI_LAL", "C", 1, 0, true, 2)]
            public string IndSdIniLal { get; set; }

            [SpedCampos(6, "VL_LCTO_PARTE_A", "N", 19, 2, true, 2)]
            public decimal VlLctoParteA { get; set; }

            [SpedCampos(7, "IND_VL_LCTO_PARTE_A", "C", 1, 0, true, 2)]
            public string IndVlLctoParteA { get; set; }

            [SpedCampos(8, "VL_LCTO_PARTE_B", "N", 19, 2, true, 2)]
            public decimal VlLctoParteB { get; set; }

            [SpedCampos(9, "IND_VL_LCTO_PARTE_B", "C", 1, 0, true, 2)]
            public string IndVlLctoParteB { get; set; }

            [SpedCampos(10, "SD_FIM_LAL", "N", 19, 2, true, 2)]
            public decimal SdFimLal { get; set; }

            [SpedCampos(11, "IND_SD_FIM_LAL", "C", 1, 0, true, 2)]
            public string IndSdFimLal { get; set; }
        }

        public class RegM990 : RegistroSped
        {
            public RegM990() : base("M990")
            {
            }

            [SpedCampos(2, "QTD_LIN", "N", int.MaxValue, 0, true, 2)]
            public int QtdLin { get; set; }
        }
    }
}
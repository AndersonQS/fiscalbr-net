﻿using FiscalBr.Common;
using FiscalBr.Common.Sped;
using System;

namespace FiscalBr.ECF
{
    public class BlocoX
    {
        public class RegX001 : RegistroSped
        {
            public RegX001() : base("X001")
            {
            }

            [SpedCampos(2, "IND_DAD", "N", 1, 0, true, 2)]
            public int IndDad { get; set; }
        }

        public class RegX280 : RegistroSped
        {
            public RegX280() : base("X280")
            {
            }

            [SpedCampos(2, "IND_ATIV", "C", 2, 0, true, 2)]
            public string IndAtiv { get; set; }

            [SpedCampos(3, "IND_PROJ", "C", 2, 0, true, 2)]
            public string IndProj { get; set; }

            [SpedCampos(4, "ATO_CONC", "C", 30, 0, true, 2)]
            public string AtoConc { get; set; }

            [SpedCampos(5, "VIG_INI", "N", 8, 0, true, 2)]
            public string VigIni { get; set; }

            [SpedCampos(6, "VIG_FIM", "N", 8, 0, true, 2)]
            public string VigFim { get; set; }
        }

        public class RegX291 : RegistroSped
        {
            public RegX291() : base("X291")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegX292 : RegistroSped
        {
            public RegX292() : base("X292")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegX300 : RegistroSped
        {
            public RegX300() : base("X300")
            {
            }

            [SpedCampos(2, "NUM_ORDEM", "C", 0, 0, true, 2)]
            public string NumOrdem { get; set; }

            [SpedCampos(3, "TIP_EXP", "N", 2, 0, true, 2)]
            public int TipExp { get; set; }

            [SpedCampos(4, "DESC_EXP", "C", 0, 0, false, 2)]
            public string DescExp { get; set; }

            [SpedCampos(5, "TOT_OPER", "N", 19, 2, false, 2)]
            public decimal? TotOper { get; set; }

            [SpedCampos(6, "COD_NCM", "N", 8, 0, false, 2)]
            public int? CodNcm { get; set; }

            [SpedCampos(7, "QTDE", "N", 2, 0, false, 2)]
            public int? Qtde { get; set; }

            [SpedCampos(8, "UNI_MED", "C", 2, 0, false, 2)]
            public string UniMed { get; set; }

            [SpedCampos(9, "IND_OPER", "C", 1, 0, false, 2)]
            public string IndOper { get; set; }

            [SpedCampos(10, "TIP_MET", "C", 5, 0, false, 2)]
            public string TipMet { get; set; }

            [SpedCampos(11, "VL_PAR", "N", 19, 2, false, 2)]
            public decimal? VlPar { get; set; }

            [SpedCampos(12, "VL_PRAT", "N", 19, 2, false, 2)]
            public decimal? VlPrat { get; set; }

            [SpedCampos(13, "VL_AJ", "N", 19, 2, false, 2)]
            public decimal? VlAj { get; set; }

            [SpedCampos(14, "VL_JUR", "N", 19, 2, false, 2)]
            public decimal? VlJur { get; set; }

            [SpedCampos(15, "VL_JUR_MIN", "N", 19, 4, false, 2)]
            public decimal? VlJurMin { get; set; }

            [SpedCampos(16, "VL_JUR_MAX", "N", 19, 4, false, 2)]
            public decimal? VlJurMax { get; set; }

            [SpedCampos(17, "COD_CNC", "N", 5, 0, false, 2)]
            public int? CodCnc { get; set; }

            [SpedCampos(18, "TIP_MOEDA", "C", 3, 0, false, 2)]
            public string TipMoeda { get; set; }
        }

        public class RegX310 : RegistroSped
        {
            public RegX310() : base("X310")
            {
            }

            [SpedCampos(2, "NOME", "C", 0, 0, true, 2)]
            public string Nome { get; set; }

            [SpedCampos(3, "PAIS", "C", 0, 0, true, 2)]
            public string Pais { get; set; }

            [SpedCampos(4, "VL_OPER", "N", 19, 2, true, 2)]
            public decimal VlOper { get; set; }

            [SpedCampos(5, "COND_PES", "N", 2, 0, true, 2)]
            public int CondPes { get; set; }
        }

        public class RegX320 : RegistroSped
        {
            public RegX320() : base("X320")
            {
            }

            [SpedCampos(2, "NUM_ORD", "C", 0, 0, true, 2)]
            public string NumOrd { get; set; }

            [SpedCampos(3, "TIP_IMP", "N", 2, 0, true, 2)]
            public int TipImp { get; set; }

            [SpedCampos(4, "DESC_IMP", "C", 0, 0, false, 2)]
            public string DescImp { get; set; }

            [SpedCampos(5, "TOT_OPER", "N", 19, 2, false, 2)]
            public decimal? TotOper { get; set; }

            [SpedCampos(6, "COD_NCM", "N", 8, 0, false, 2)]
            public int? CodNcm { get; set; }

            [SpedCampos(7, "QTDE", "N", 19, 2, false, 2)]
            public decimal? Qtde { get; set; }

            [SpedCampos(8, "UNI_MED", "C", 2, 0, false, 2)]
            public string UniMed { get; set; }

            [SpedCampos(9, "TIP_MET", "C", 5, 0, false, 2)]
            public string TipMet { get; set; }

            [SpedCampos(10, "VL_PAR", "N", 19, 2, false, 2)]
            public decimal? VlPar { get; set; }

            [SpedCampos(11, "VL_PRAT", "N", 19, 2, false, 2)]
            public decimal? VlPrat { get; set; }

            [SpedCampos(12, "VL_AJ", "N", 19, 2, true, 2)]
            public decimal VlAj { get; set; }

            [SpedCampos(13, "VL_JUR", "N", 19, 2, false, 2)]
            public decimal? VlJur { get; set; }

            [SpedCampos(14, "VL_JUR_MIN", "N", 7, 4, false, 2)]
            public decimal? VlJurMin { get; set; }

            [SpedCampos(15, "VL_JUR_MAX", "N", 7, 4, false, 2)]
            public decimal? VlJurMax { get; set; }

            [SpedCampos(16, "COD_CNC", "C", 5, 0, false, 2)]
            public string CodCnc { get; set; }
        }

        public class RegX330 : RegistroSped
        {
            public RegX330() : base("X330")
            {
            }

            [SpedCampos(2, "NOME", "C", 0, 0, true, 2)]
            public string Nome { get; set; }

            [SpedCampos(3, "PAIS", "C", 0, 0, true, 2)]
            public string Pais { get; set; }

            [SpedCampos(4, "VL_OPER", "N", 19, 2, true, 2)]
            public decimal VlOper { get; set; }

            [SpedCampos(5, "COND_PES", "N", 2, 0, true, 2)]
            public int CondPes { get; set; }
        }

        public class RegX340 : RegistroSped
        {
            public RegX340() : base("X340")
            {
            }

            [SpedCampos(2, "RAZ_SOCIAL", "C", 0, 0, true, 2)]
            public string RazaoSocial { get; set; }

            [SpedCampos(3, "NIF", "C", 0, 0, true, 2)]
            public string Nif { get; set; }

            [SpedCampos(4, "IND_CONTROLE", "N", 2, 0, true, 2)]
            public int IndControle { get; set; }

            [SpedCampos(5, "PAIS", "N", 3, 0, true, 2)]
            public int Pais { get; set; }

            [SpedCampos(6, "IND_ISEN_PETR", "C", 0, 0, true, 2)]
            public string IndIsenPetr { get; set; }

            [SpedCampos(7, "IND_CONSOL", "C", 0, 0, true, 2)]
            public string IndConsol { get; set; }

            [SpedCampos(8, "MOT_NAO_CONSOL", "N", 0, 0, false, 2)]
            public string MotNaoConsol { get; set; }

            [SpedCampos(9, "CNPJ", "N", 14, 0, true, 2)]
            public string Cnpj { get; set; }
        }

        public class RegX350 : RegistroSped
        {
            public RegX350() : base("X350")
            {
            }

            [SpedCampos(2, "REC_LIQ", "N", 19, 2, false, 2)]
            public decimal? RecLiq { get; set; }

            [SpedCampos(3, "CUSTOS", "N", 19, 2, false, 2)]
            public decimal? Custos { get; set; }

            [SpedCampos(4, "LUC_BRUTO", "NS", 19, 2, false, 2)]
            public decimal? LucBruto { get; set; }

            [SpedCampos(5, "REC_AUFERIDAS", "N", 19, 2, false, 2)]
            public decimal? RecAuferidas { get; set; }

            [SpedCampos(6, "REC_OUTRAS_OPER", "N", 19, 2, false, 2)]
            public decimal? RecOutrasOper { get; set; }

            [SpedCampos(7, "DESP_BRASIL", "N", 19, 2, false, 2)]
            public decimal? DespBrasil { get; set; }

            [SpedCampos(8, "DESP_OPER", "N", 19, 2, false, 2)]
            public decimal? DespOper { get; set; }

            [SpedCampos(9, "LUC_OPER", "NS", 19, 2, false, 2)]
            public decimal? LucOper { get; set; }

            [SpedCampos(10, "REC_PARTIC", "NS", 19, 2, false, 2)]
            public decimal? RecPartic { get; set; }

            [SpedCampos(11, "REC_OUTRAS", "N", 19, 2, false, 2)]
            public decimal? RecOutras { get; set; }

            [SpedCampos(12, "DESP_OUTRAS", "N", 19, 2, false, 2)]
            public decimal? DespOutras { get; set; }

            [SpedCampos(13, "LUC_LIQ_ANT_IR", "NS", 19, 2, false, 2)]
            public decimal? LucLiqAntIr { get; set; }

            [SpedCampos(14, "IMP_DEV", "NS", 19, 2, false, 2)]
            public decimal? ImpDev { get; set; }

            [SpedCampos(15, "LUC_LIQ", "NS", 19, 2, false, 2)]
            public decimal? LucLiq { get; set; }
        }

        public class RegX351 : RegistroSped
        {
            public RegX351() : base("X351")
            {
            }

            [SpedCampos(2, "RES_INV_PER", "NS", 19, 2, false, 2)]
            public decimal? ResInvPer { get; set; }

            [SpedCampos(3, "RES_INV_PER_REAL", "NS", 19, 2, false, 2)]
            public decimal? ResInvPerReal { get; set; }

            [SpedCampos(4, "RES_ISEN_PETR_PER", "NS", 19, 2, false, 2)]
            public decimal? ResIsenPetrPer { get; set; }

            [SpedCampos(5, "RES_ISEN_PETR_PER_REAL", "NS", 19, 2, false, 2)]
            public decimal? ResIsenPetrPerReal { get; set; }

            [SpedCampos(6, "RES_NEG_ACUM", "N", 19, 2, false, 2)]
            public decimal? ResNegAcum { get; set; }

            [SpedCampos(7, "RES_POS_TRIB", "N", 19, 2, false, 2)]
            public decimal? ResPosTrib { get; set; }

            [SpedCampos(8, "RES_POS_TRIB_REAL", "N", 19, 2, false, 2)]
            public decimal? ResPosTribReal { get; set; }

            [SpedCampos(9, "IMP_LUCR", "N", 19, 2, false, 2)]
            public decimal? ImpLucr { get; set; }

            [SpedCampos(10, "IMP_LUCR_REAL", "N", 19, 2, false, 2)]
            public decimal? ImpLucrReal { get; set; }

            [SpedCampos(11, "IMP_PAG_REND", "N", 19, 2, false, 2)]
            public decimal? ImpPagRend { get; set; }

            [SpedCampos(12, "IMP_PAG_REND_REAL", "N", 19, 2, false, 2)]
            public decimal? ImpPagRendReal { get; set; }

            [SpedCampos(13, "IMP_RET_EXT", "N", 19, 2, false, 2)]
            public decimal? ImpRetExt { get; set; }

            [SpedCampos(14, "IMP_RET_EXT_REAL", "N", 19, 2, false, 2)]
            public decimal? ImpRetExtReal { get; set; }

            [SpedCampos(15, "IMP_RET_BR", "N", 19, 2, false, 2)]
            public decimal? ImpRetBr { get; set; }
        }

        public class RegX352 : RegistroSped
        {
            public RegX352() : base("X352")
            {
            }

            [SpedCampos(2, "RES_PER", "NS", 19, 2, false, 2)]
            public decimal? ResPer { get; set; }

            [SpedCampos(3, "RES_PER_REAL", "NS", 19, 2, false, 2)]
            public decimal? ResPerReal { get; set; }

            [SpedCampos(4, "LUC_DISP", "N", 19, 2, false, 2)]
            public decimal? LucDisp { get; set; }

            [SpedCampos(5, "LUC_DISP_REAL", "N", 19, 2, false, 2)]
            public decimal? LucDispReal { get; set; }
        }

        public class RegX353 : RegistroSped
        {
            public RegX353() : base("X353")
            {
            }

            [SpedCampos(2, "RES_NEG_UTIL", "N", 19, 2, false, 2)]
            public decimal? ResNegUtil { get; set; }

            [SpedCampos(3, "RES_NEG_UTIL_REAL", "N", 19, 2, false, 2)]
            public decimal? ResNegUtilReal { get; set; }

            [SpedCampos(4, "SALDO_RES_NEG_NAO_UTIL", "N", 19, 2, false, 2)]
            public decimal? SaldoResNegNaoUtil { get; set; }

            [SpedCampos(5, "SALDO_RES_NEG_NAO_UTIL_REAL", "N", 19, 2, false, 2)]
            public decimal? SaldoResNegNaoUtilReal { get; set; }
        }

        public class RegX354 : RegistroSped
        {
            public RegX354() : base("X354")
            {
            }

            [SpedCampos(2, "RES_NEG", "N", 19, 2, false, 2)]
            public decimal? ResNeg { get; set; }

            [SpedCampos(3, "RES_NEG_REAL", "N", 19, 2, false, 2)]
            public decimal? ResNegReal { get; set; }

            [SpedCampos(4, "SALDO_RES_NEG", "N", 19, 2, false, 2)]
            public decimal? SaldoResNeg { get; set; }
        }

        public class RegX355 : RegistroSped
        {
            public RegX355() : base("X355")
            {
            }

            [SpedCampos(2, "REND_PASS_PROP", "N", 19, 2, false, 2)]
            public decimal? RendPassProp { get; set; }

            [SpedCampos(3, "REND_PASS_PROP_REAL", "N", 19, 2, false, 2)]
            public decimal? RendPassPropReal { get; set; }

            [SpedCampos(4, "REND_TOTAL", "N", 19, 2, false, 2)]
            public decimal? RendTotal { get; set; }

            [SpedCampos(5, "REND_TOTAL_REAL", "N", 19, 2, false, 2)]
            public decimal? RendTotalReal { get; set; }

            [SpedCampos(6, "REND_ATIV_PROP", "N", 19, 2, false, 2)]
            public decimal? RendAtivProp { get; set; }

            [SpedCampos(7, "REND_ATIV_PROP_REAL", "N", 19, 2, false, 2)]
            public decimal? RendAtivPropReal { get; set; }

            [SpedCampos(8, "PERCENTUAL", "N", 8, 4, false, 2)]
            public decimal? Percentual { get; set; }
        }

        public class RegX356 : RegistroSped
        {
            public RegX356() : base("X356")
            {
            }

            [SpedCampos(2, "PERC_PART", "N", 8, 4, false, 2)]
            public decimal? PercPart { get; set; }

            [SpedCampos(3, "ATIVO_TOTAL", "N", 19, 2, false, 2)]
            public decimal? AtivoTotal { get; set; }

            [SpedCampos(4, "PAT_LIQUIDO", "NS", 19, 2, false, 2)]
            public decimal? PatLiquido { get; set; }
        }

        public class RegX390 : RegistroSped
        {
            public RegX390() : base("X390")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 0, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegX400 : RegistroSped
        {
            public RegX400() : base("X400")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 6, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegX410 : RegistroSped
        {
            public RegX410() : base("X410")
            {
            }

            [SpedCampos(2, "PAIS", "N", 3, 0, true, 2)]
            public int Pais { get; set; }

            [SpedCampos(3, "IND_HOME_DISP", "C", 1, 0, false, 2)]
            public string IndHomeDisp { get; set; }

            [SpedCampos(4, "IND_SERV_DISP", "C", 1, 0, false, 2)]
            public string IndServDisp { get; set; }
        }

        public class RegX420 : RegistroSped
        {
            public RegX420() : base("X420")
            {
            }

            [SpedCampos(2, "TIP_ROY", "C", 1, 0, true, 2)]
            public string TipRoy { get; set; }

            [SpedCampos(3, "PAIS", "N", 3, 0, true, 2)]
            public int Pais { get; set; }

            [SpedCampos(4, "VL_EXPL_DIR_SW", "N", 19, 2, false, 2)]
            public decimal? VlExplDirSw { get; set; }

            [SpedCampos(5, "VL_EXPL_DIR_AUT", "N", 19, 2, false, 2)]
            public decimal? VlExpDirAut { get; set; }

            [SpedCampos(6, "VL_EXPL_MARCA", "N", 19, 2, false, 2)]
            public decimal? VlExplMarca { get; set; }

            [SpedCampos(7, "VL_EXPL_PAT", "N", 19, 2, false, 2)]
            public decimal? VlExplPat { get; set; }

            [SpedCampos(8, "VL_EXPL_KNOW", "N", 19, 2, false, 2)]
            public decimal? VlExplKnow { get; set; }

            [SpedCampos(9, "VL_EXPL_FRANQ", "N", 19, 2, false, 2)]
            public decimal? VlExplFranq { get; set; }

            [SpedCampos(10, "VL_EXPL_INT", "N", 19, 2, false, 2)]
            public decimal? VlExplInt { get; set; }
        }

        public class RegX430 : RegistroSped
        {
            public RegX430() : base("X430")
            {
            }

            [SpedCampos(2, "PAIS", "N", 3, 0, true, 2)]
            public int Pais { get; set; }

            [SpedCampos(3, "VL_SERV_ASSIST", "N", 0, 2, false, 2)]
            public decimal? VlServAssist { get; set; }

            [SpedCampos(4, "VL_SERV_SEM_ASSIST", "N", 19, 2, false, 2)]
            public decimal? VlServSemAssist { get; set; }

            [SpedCampos(5, "VL_SERV_SEM_ASSIST_EXT", "N", 19, 2, false, 2)]
            public decimal? VlServSemAssistExt { get; set; }

            [SpedCampos(6, "VL_JURO", "N", 19, 2, false, 2)]
            public decimal? VlJuro { get; set; }

            [SpedCampos(7, "VL_DEMAIS_JUROS", "N", 19, 2, false, 2)]
            public decimal? VlDemaisJuros { get; set; }

            [SpedCampos(8, "VL_DIVID", "N", 19, 2, false, 2)]
            public decimal? VlDivid { get; set; }
        }

        public class RegX450 : RegistroSped
        {
            public RegX450() : base("X450")
            {
            }

            [SpedCampos(2, "PAIS", "N", 3, 0, true, 2)]
            public int Pais { get; set; }

            [SpedCampos(3, "VL_SERV_ASSIST", "N", 19, 2, false, 2)]
            public decimal? VlServAssist { get; set; }

            [SpedCampos(4, "VL_SERV_SEM_ASSIST", "N", 19, 2, false, 2)]
            public decimal? VlServSemAssist { get; set; }

            [SpedCampos(5, "VL_SERV_SEM_ASSIST_EXT", "N", 19, 2, false, 2)]
            public decimal? VlServSemAssistExt { get; set; }

            [SpedCampos(6, "VL_JURO_PF", "N", 19, 2, false, 2)]
            public decimal? VlJuroPf { get; set; }

            [SpedCampos(7, "VL_JURO_PJ", "N", 19, 2, false, 2)]
            public decimal? VlJuroPj { get; set; }

            [SpedCampos(8, "VL_DEMAIS_JUROS", "N", 19, 2, false, 2)]
            public decimal? VlDemaisJuros { get; set; }

            [SpedCampos(8, "VL_DIVID_PF", "N", 19, 2, false, 2)]
            public decimal? VlDividaPf { get; set; }

            [SpedCampos(8, "VL_DIVID_PJ", "N", 19, 2, false, 2)]
            public decimal? VlDividaPj { get; set; }
        }

        public class RegX460 : RegistroSped
        {
            public RegX460() : base("X460")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 6, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegX470 : RegistroSped
        {
            public RegX470() : base("X470")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 6, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegX480 : RegistroSped
        {
            public RegX480() : base("X480")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 6, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegX490 : RegistroSped
        {
            public RegX490() : base("X490")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 6, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegX500 : RegistroSped
        {
            public RegX500() : base("X500")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 6, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegX510 : RegistroSped
        {
            public RegX510() : base("X510")
            {
            }

            [SpedCampos(2, "CODIGO", "C", 6, 0, true, 2)]
            public string Codigo { get; set; }

            [SpedCampos(3, "DESCRICAO", "C", 0, 0, false, 2)]
            public string Descricao { get; set; }

            [SpedCampos(4, "VALOR", "NS", 19, 2, false, 2)]
            public decimal? Valor { get; set; }
        }

        public class RegX990 : RegistroSped
        {
            public RegX990() : base("X990")
            {
            }

            [SpedCampos(2, "QTD_LIN", "N", int.MaxValue, 0, true, 2)]
            public int QtdLin { get; set; }
        }
    }
}
﻿using FiscalBr.Common;
using FiscalBr.Common.Sped;
using System;

namespace FiscalBr.ECF
{
    public class BlocoQ
    {
        public class RegQ001 : RegistroSped
        {
            public RegQ001() : base("Q001")
            {
            }

            [SpedCampos(2, "IND_DAD", "N", 1, 0, true, 2)]
            public int IndDad { get; set; }
        }

        public class RegQ100 : RegistroSped
        {
            public RegQ100() : base("Q100")
            {
            }

            [SpedCampos(2, "DATA", "N", 8, 0, true, 2)]
            public DateTime Data { get; set; }

            [SpedCampos(3, "NUM_DOC", "C", 0, 0, false, 2)]
            public string NumDoc { get; set; }

            [SpedCampos(4, "HIST", "C", 0, 0, true, 2)]
            public string Hist { get; set; }

            [SpedCampos(5, "VL_ENTRADA", "N", 19, 2, false, 2)]
            public decimal? VlEntrada { get; set; }

            [SpedCampos(6, "VL_SAIDA", "N", 19, 2, false, 2)]
            public decimal? VlSaida { get; set; }

            [SpedCampos(7, "SLD_FIN", "NS", 19, 2, true, 2)]
            public decimal SldFin { get; set; }
        }

        public class RegQ990 : RegistroSped
        {
            public RegQ990() : base("Q990")
            {
            }

            [SpedCampos(2, "QTD_LIN", "N", int.MaxValue, 0, true, 2)]
            public int QtdLin { get; set; }
        }
    }
}
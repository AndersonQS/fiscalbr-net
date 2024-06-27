﻿using FiscalBr.Common;
using FiscalBr.Common.Sped;
using System;

namespace FiscalBr.ECF
{
    public class BlocoK
    {
        public class RegK001 : RegistroSped
        {
            public RegK001() : base("K001")
            {
            }

            [SpedCampos(2, "IND_DAD", "N", 1, 0, true, 2)]
            public int IndDad { get; set; }
        }

        public class RegK030 : RegistroSped
        {
            public RegK030() : base("K030")
            {
            }

            [SpedCampos(2, "DT_INI", "N", 8, 0, true, 2)]
            public DateTime DtIni { get; set; }

            [SpedCampos(3, "DT_FIN", "N", 8, 0, true, 2)]
            public DateTime DtFin { get; set; }

            [SpedCampos(4, "PER_APUR", "C", 3, 0, true, 2)]
            public string PerApur { get; set; }
        }

        public class RegK155 : RegistroSped
        {
            public RegK155() : base("K155")
            {
            }

            [SpedCampos(2, "COD_CTA", "C", 0, 0, true, 2)]
            public string CodCta { get; set; }

            [SpedCampos(3, "COD_CCUS", "C", 0, 0, false, 2)]
            public string CodCcus { get; set; }

            [SpedCampos(4, "VL_SLD_INI", "N", 19, 2, true, 2)]
            public decimal VlSldIni { get; set; }

            [SpedCampos(5, "IND_VL_SLD_INI", "C", 1, 0, true, 2)]
            public string IndVlSldIni { get; set; }

            [SpedCampos(6, "VL_DEB", "N", 19, 2, true, 2)]
            public decimal VlDeb { get; set; }

            [SpedCampos(7, "VL_CRED", "N", 19, 2, true, 2)]
            public decimal VlCred { get; set; }

            [SpedCampos(8, "VL_SLD_FIN", "N", 19, 2, true, 2)]
            public decimal VlSldFin { get; set; }

            [SpedCampos(9, "IND_VL_SLD_FIN", "C", 1, 0, true, 2)]
            public string IndVlSldFin { get; set; }
        }

        public class RegK156 : RegistroSped
        {
            public RegK156() : base("K156")
            {
            }

            [SpedCampos(2, "COD_CTA_REF", "C", 0, 0, true, 2)]
            public string CodCtaRef { get; set; }

            [SpedCampos(3, "VL_SLD_FIN", "N", 19, 2, true, 2)]
            public decimal VlSldFin { get; set; }

            [SpedCampos(4, "IND_VL_SLD_FIN", "C", 1, 0, true, 2)]
            public string IndVlSldFin { get; set; }
        }

        public class RegK355 : RegistroSped
        {
            public RegK355() : base("K355")
            {
            }

            [SpedCampos(2, "COD_CTA", "C", 0, 0, true, 2)]
            public string CodCta { get; set; }

            [SpedCampos(3, "COD_CCUS", "C", 0, 0, false, 2)]
            public string CodCcus { get; set; }

            [SpedCampos(4, "VL_SLD_FIN", "N", 19, 2, true, 2)]
            public decimal VlSldFin { get; set; }

            [SpedCampos(5, "IND_VL_SLD_FIN", "C", 1, 0, true, 2)]
            public string IndVlSldFin { get; set; }
        }

        public class RegK356 : RegistroSped
        {
            public RegK356() : base("K356")
            {
            }

            [SpedCampos(2, "COD_CTA_REF", "C", 0, 0, true, 2)]
            public string CodCtaRef { get; set; }

            [SpedCampos(3, "VL_SLD_FIN", "N", 19, 2, true, 2)]
            public decimal VlSldFin { get; set; }

            [SpedCampos(4, "IND_VL_SLD_FIN", "C", 1, 0, true, 2)]
            public string IndVlSldFin { get; set; }
        }

        public class RegK990 : RegistroSped
        {
            public RegK990() : base("K990")
            {
            }

            [SpedCampos(2, "QTD_LIN", "N", int.MaxValue, 0, true, 2)]
            public int QtdLin { get; set; }
        }
    }
}
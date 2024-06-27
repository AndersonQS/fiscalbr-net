﻿using FiscalBr.Common;
using FiscalBr.Common.Sped;
using System;

namespace FiscalBr.ECF
{
    public class Bloco9
    {
        public class Reg9001 : RegistroSped
        {
            public Reg9001() : base("9001")
            {
            }

            [SpedCampos(2, "IND_DAD", "N", 1, 0, true, 2)]
            public int IndDad { get; set; }
        }

        public class Reg9100 : RegistroSped
        {
            public Reg9100() : base("9100")
            {
            }

            [SpedCampos(2, "NOM_REGRA", "N", 0, 0, true, 2)]
            public string NomRegra { get; set; }

            [SpedCampos(3, "MSG_REGRA", "C", 0, 0, false, 2)]
            public string MsgRegra { get; set; }

            [SpedCampos(4, "REGISTRO", "C", 4, 0, true, 2)]
            public string Registro { get; set; }

            [SpedCampos(5, "CAMPO", "C", 0, 0, false, 2)]
            public string Campo { get; set; }

            [SpedCampos(6, "VALOR_ESPERADO", "NS", 19, 2, false, 2)]
            public decimal? ValorEsperado { get; set; }

            [SpedCampos(7, "CONTEÚDO", "NS", 19, 2, false, 2)]
            public decimal? Conteudo { get; set; }
        }

        public class Reg9900 : RegistroSped
        {
            public Reg9900() : base("9900")
            {
            }

            [SpedCampos(2, "REG_BLC", "C", 4, 0, true, 2)]
            public string RegBlc { get; set; }

            [SpedCampos(3, "QTD_REG_BLC", "N", int.MaxValue, 0, true, 2)]
            public int QtdRegBlc { get; set; }

            [SpedCampos(4, "VERSAO", "C", 4, 0, false, 2)]
            public string Versao { get; set; }

            [SpedCampos(5, "ID_TAB_DIN", "C", 0, 0, false, 2)]
            public string IdTabDin { get; set; }
        }

        public class Reg9990 : RegistroSped
        {
            public Reg9990() : base("9990")
            {
            }

            [SpedCampos(2, "QTD_LIN", "N", int.MaxValue, 0, true, 2)]
            public int QtdLin { get; set; }
        }

        public class Reg9999 : RegistroSped
        {
            public Reg9999() : base("9999")
            {
            }

            [SpedCampos(2, "QTD_LIN", "N", int.MaxValue, 0, true, 2)]
            public int QtdLin { get; set; }
        }
    }
}
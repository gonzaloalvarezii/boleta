using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenerarPDF
{
    public class XML
    {

        private string  parametros = "<Parametros>" +
"<EmpresaInicial>DL</EmpresaInicial>" +
"<EmpresaFinal>DL</EmpresaFinal>" +
"<FechaInicial>01/01/2010</FechaInicial>" +
"<FechaFinal>31/12/2012</FechaFinal>" +
"<TiposDocumentos></TiposDocumentos>" +
"<ComprobanteInicial>0</ComprobanteInicial>" +
"<ComprobanteFinal>ZZZZZZZZ</ComprobanteFinal>" +
"<RubroInicial>113106</RubroInicial>" +
"<RubroFinal>113106</RubroFinal>" +
"<FechaVencimientoInicial></FechaVencimientoInicial>" +
"<FechaVencimientoFinal></FechaVencimientoFinal>" +
"<ElementoInicial1>C004</ElementoInicial1>" +
"<ElementoFinal1>C004</ElementoFinal1>" +
"<ElementoInicial2></ElementoInicial2>" +
"<ElementoFinal2></ElementoFinal2>" +
"<ElementoInicial3></ElementoInicial3>" +
"<ElementoFinal3></ElementoFinal3>" +
"<ElementoInicial4></ElementoInicial4>" +
"<ElementoFinal4></ElementoFinal4>" +
"<SoloPendiente>True</SoloPendiente>" +
"<IncluyeCancelaciones>False</IncluyeCancelaciones>" +
"<IncluyePagosACuenta>True</IncluyePagosACuenta>" +
"<Detallado>False</Detallado>" +
"</Parametros>";



            public XML() { }

        public string Parametros   
        {
            get { return Parametros; }   
            set { Parametros = value; } 
        }

    }
}
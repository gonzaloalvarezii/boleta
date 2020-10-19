using GenerarPDF.App_Code;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GenerarPDF
{
    public partial class _Default : Page
    {
        private static int[] azul = new int[] { 62, 120, 186 };
        private static int[] blanco = new int[] { 255, 255, 255 };
        private static int[] gris = new int[] { 209, 209, 209 };
        protected void Page_Load(object sender, EventArgs e)
        {
         
         /* ServiceReference1.TSOAPWebServiceContaClient prueba = new ServiceReference1.TSOAPWebServiceContaClient();
            XML datos = new XML();            
            string retorno =   prueba.ObtenerDocumentosContables(datos.Parametros);*/
    
           
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"C:\\Users\\galvarez\\Desktop\\Ticket\\prueba.pdf", FileMode.Create));

           
            doc.AddTitle("Factura Resonance");
            doc.AddCreator("Gonzalo Alvarez");

            doc.Open();


            agregarImagen(ref doc);
            doc.Add(Chunk.NEWLINE);

            doc.Add(contenedor(crearTablaRUT(), crearTablaRUTEMPRESA()));
            doc.Add(crearTabla(crearTablaPrueba()));

            doc.Add(crearTablaItems());
            doc.Add(tablaSubtotales());

            agregarQR(ref doc);
            agregarCodigoBarras(ref doc);

            doc.Close();
            writer.Close();


        }

        private PdfPCell GetCell(string nombre,int borde , int[] color,int tipoLetra) {

            iTextSharp.text.Font _standardFont;

            if (tipoLetra == 1)
            {

              _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            }
            else if (tipoLetra == 2)
            {
               _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            }
            else {
               _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.WHITE);
            }

          
            PdfPCell columnas = new PdfPCell(new Phrase(nombre, _standardFont));
            columnas.BorderWidth = borde;
            columnas.BackgroundColor = new iTextSharp.text.BaseColor(color[0], color[1], color[2]);
            return columnas;

        }
        
        private DataTable crearTablaPrueba() {
           
            DataTable dt = new DataTable();
           
            dt.Columns.Add("codigo");
            dt.Columns.Add("fechaEmi");
            dt.Columns.Add("moneda");
            dt.Columns.Add("vendedor");
            dt.Columns.Add("pago");
            dt.Columns.Add("distribucion");


            DataRow row = dt.NewRow();
            row[0] = "123456";
            row[1] = "12/12/2020";
            row[2] = "$";
            row[3] = "Rodriguez";
            row[4] = "500";
            row[5] = "XX";

            dt.Rows.Add(row);

            return dt;
        }

        private PdfPTable contenedor(PdfPTable tbl1, PdfPTable tbl2) {

            PdfPTable contenedor = new PdfPTable(2);

            contenedor.AddCell(tbl1);
            contenedor.AddCell(tbl2);

            return contenedor;

        }

        private PdfPTable crearTablaRUT()
        {

            PdfPTable table = new PdfPTable(1);

            int[] azul = new int[] { 62, 120, 186 };
            int[] blanco = new int[] { 255, 255, 255 };


            PdfPCell[] cells = new PdfPCell[] { new PdfPCell(GetCell("RUT COMPRADOR",0,blanco,1)),                
                                    };

            PdfPCell[] cells1 = new PdfPCell[] { new PdfPCell(GetCell("110322520014",0,blanco,1)),
                                    };

            PdfPRow row = new PdfPRow(cells);
            PdfPRow row2 = new PdfPRow(cells1);

            table.Rows.Add(row);
            table.Rows.Add(row2);
            return table;

        }

        private PdfPTable crearTablaRUTEMPRESA()
        {

            PdfPTable table = new PdfPTable(1);

            int[] azul = new int[] { 62, 120, 186 };
            int[] blanco = new int[] { 255, 255, 255 };


            PdfPCell[] cells = new PdfPCell[] { new PdfPCell(GetCell("RUT",0,blanco,1)),
                                    };

            PdfPCell[] cells1 = new PdfPCell[] { new PdfPCell(GetCell("1xxxxxxxxxx",0,blanco,1)),
                                    };

            PdfPRow row = new PdfPRow(cells);
            PdfPRow row2 = new PdfPRow(cells1);

            table.Rows.Add(row);
            table.Rows.Add(row2);

            return table;

        }

        private PdfPTable crearTabla(DataTable datos) {

            PdfPTable table = new PdfPTable(5);

            PdfPCell[] cells = new PdfPCell[] { new PdfPCell(GetCell("Nombre",0,blanco,1)),
                                    new PdfPCell(GetCell("Gonzalo",0,blanco,2)),
                                    new PdfPCell(GetCell("Código Cliente",1,azul,3)),
                                    new PdfPCell(GetCell("Fecha Emisión",1,azul,3)),
                                    new PdfPCell(GetCell("Moneda",1,azul,3)),
                                    };

            PdfPRow row = new PdfPRow(cells);

            PdfPCell[] cells2 = new PdfPCell[] { new PdfPCell(GetCell("Dirección",0,blanco,1)),
                                    new PdfPCell(GetCell("Morales 2560",0,blanco,2)),
                                    new PdfPCell(GetCell(datos.Rows[0][0].ToString(),1,blanco,2)),
                                    new PdfPCell(GetCell(datos.Rows[0][1].ToString(),1,blanco,2)),
                                    new PdfPCell(GetCell(datos.Rows[0][2].ToString(),1,blanco,2)),
                                    };

            PdfPCell[] cells3 = new PdfPCell[] {  new PdfPCell(GetCell("Teléfono",0,blanco,1)),
                                    new PdfPCell(GetCell("094800577",0,blanco,2)),
                                    new PdfPCell(GetCell("Vendedor", 1,azul,3)),
                                    new PdfPCell(GetCell("Forma de Pago",1,azul,3)),
                                     new PdfPCell(GetCell("Distribuidor",1,azul,3)),
                                    };

            PdfPCell[] cells4 = new PdfPCell[] { new PdfPCell(GetCell("",0,blanco,1)),
                                    new PdfPCell(GetCell("",0,blanco,1)),
                                    new PdfPCell(GetCell(datos.Rows[0][3].ToString(),1,blanco,2)),
                                    new PdfPCell(GetCell(datos.Rows[0][4].ToString(),1,blanco,2)),
                                    new PdfPCell(GetCell(datos.Rows[0][5].ToString(),1,blanco,2)),
                                    };

            PdfPRow row2 = new PdfPRow(cells2);
            PdfPRow row3 = new PdfPRow(cells3);
            PdfPRow row4 = new PdfPRow(cells4);
            
            table.Rows.Add(row);
            table.Rows.Add(row2);
            table.Rows.Add(row3);
            table.Rows.Add(row4);
            PdfPTable table1 = new PdfPTable(2);

            
            float[] columnas = new float[] { 11, 50, 13,13,13 };

            table.SetWidths(columnas);
            table.WidthPercentage = 100;

            return table;

        }

        private PdfPTable crearTablaItems(){

            ControladorDB db = new ControladorDB();
            DataTable dt = db.getDatatable(db.queys(1, "71810"));

           return crearTablaPrincipal(dt);

  
        }

            private PdfPTable crearTablaPrincipal(DataTable datos)
           {

            PdfPTable table = new PdfPTable(datos.Columns.Count);

          
           // PdfPCell[] cells = new PdfPCell[]{ };
       
            //Cabezal
            foreach (DataColumn dc in datos.Columns) {

                PdfPCell celda = new PdfPCell(GetCell(dc.ColumnName, 1, azul, 3));
                table.AddCell(celda);
               
            }

            foreach (DataRow dr in datos.Rows)
            {
                for (int j=0; j < datos.Columns.Count;j ++)
                {
                   PdfPCell celda = new PdfPCell(GetCell(dr[j].ToString(), 1, blanco, 1));
                   table.AddCell(celda);
                }

            }

          
            PdfPCell celdaInfo = new PdfPCell(GetCell("Empresa afiliada al clearing", 1, blanco, 1));
            celdaInfo.Colspan = 5;

            table.AddCell(celdaInfo);

            PdfPCell celdaTotal = new PdfPCell(GetCell("Totales", 1, azul, 3));
            celdaTotal.Colspan = 5;

            table.AddCell(celdaTotal);


          

            return table;

        }

        private PdfPTable tablaSubtotales() {

            PdfPTable table = new PdfPTable(4);

            PdfPCell[] cells = new PdfPCell[] { new PdfPCell(GetCell("Subtotal Exento:",0,blanco,1)),
                                    new PdfPCell(GetCell("Subtotal t/bás.:",0,blanco,2)),
                                    new PdfPCell(GetCell("Iva t/bás.:",1,blanco,2)),
                                    new PdfPCell(GetCell("Sub Total:",1,gris,1)),

                                    };

            PdfPRow row = new PdfPRow(cells);

            PdfPCell[] cells2 = new PdfPCell[] { new PdfPCell(GetCell("",0,blanco,1)),
                                    new PdfPCell(GetCell("Redondeo:",0,blanco,2)),
                                    new PdfPCell(GetCell("",1,blanco,2)),
                                    new PdfPCell(GetCell("Total Impo:",1,gris,1)),

                                    };

            PdfPCell[] cells3 = new PdfPCell[] {  new PdfPCell(GetCell("",0,blanco,1)),
                                    new PdfPCell(GetCell("",0,blanco,2)),
                                    new PdfPCell(GetCell("", 1,blanco,2)),
                                    new PdfPCell(GetCell("TOTAL",1,gris,1)),

                                    };


            PdfPRow row4 = new PdfPRow(cells);
            PdfPRow row2 = new PdfPRow(cells2);
            PdfPRow row3 = new PdfPRow(cells3);


            table.Rows.Add(row);
            table.Rows.Add(row2);
            table.Rows.Add(row3);

            return table;
        }
        private void agregarImagen(ref Document doc) {
            // Creamos la imagen y le ajustamos el tamaño
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("C:\\Users\\galvarez\\Desktop\\Ticket\\logo2.jpg");
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_RIGHT;
            float percentage = 0.0f;
            percentage = 150 / imagen.Width;
            imagen.ScalePercent(percentage * 100);

            doc.Add(imagen);
        }
        private void agregarQR(ref Document doc) {

            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("C:\\Users\\galvarez\\Desktop\\Ticket\\logo.png");
            var qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            var qrCode = qrEncoder.Encode("http://blog.koalite.com");

            var renderer = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), Brushes.Black, Brushes.White);
            using (var stream = new FileStream("C:\\Users\\galvarez\\Desktop\\Ticket\\qrcode.png", FileMode.Create))
                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);

            // Creamos la imagen y le ajustamos el tamaño
            iTextSharp.text.Image imagenQR = iTextSharp.text.Image.GetInstance("C:\\Users\\galvarez\\Desktop\\Ticket\\qrcode.png");
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_BOTTOM;
            float percentageQR = 0.0f;
            percentageQR = 100 / imagen.Width;
            imagen.ScalePercent(percentageQR * 100);
            doc.Add(imagenQR);
        }
        private void agregarCodigoBarras(ref Document doc) {

       
            iTextSharp.text.pdf.BarcodePDF417 objBarcodePDF417 = new iTextSharp.text.pdf.BarcodePDF417();
            objBarcodePDF417.SetText("*7Y0012351007181031072020*");
            objBarcodePDF417.YHeight = Convert.ToSingle(1.9);
            objBarcodePDF417.Options = iTextSharp.text.pdf.BarcodePDF417.PDF417_FORCE_BINARY;
            objBarcodePDF417.ErrorLevel = 5;

            objBarcodePDF417.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White).Save("C:\\Users\\galvarez\\Desktop\\Ticket\\barritas.png", System.Drawing.Imaging.ImageFormat.Jpeg);


            // Creamos la imagen y le ajustamos el tamaño
            iTextSharp.text.Image imagenBarras = iTextSharp.text.Image.GetInstance("C:\\Users\\galvarez\\Desktop\\Ticket\\barritas.png");
            imagenBarras.BorderWidth = 0;
            imagenBarras.Alignment = Element.ALIGN_LEFT;
            float percentageBarra = 0.0f;
            percentageBarra = 100 / imagenBarras.Width;
            imagenBarras.ScalePercent(percentageBarra * 100);
            doc.Add(imagenBarras);

        }

    }
}
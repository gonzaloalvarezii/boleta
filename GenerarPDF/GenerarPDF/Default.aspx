<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GenerarPDF._Default" %>


<html>
<head><meta http-equiv=Content-Type content="text/html; charset=UTF-8">
<style type="text/css">
<!--
span.cls_002{font-family:Times,serif;font-size:7.7px;color:rgb(0,0,0);font-weight:normal;font-style:normal;text-decoration: none}
div.cls_002{font-family:Times,serif;font-size:7.7px;color:rgb(0,0,0);font-weight:normal;font-style:normal;text-decoration: none}
span.cls_003{font-family:Times,serif;font-size:8.7px;color:rgb(0,0,0);font-weight:normal;font-style:normal;text-decoration: none}
div.cls_003{font-family:Times,serif;font-size:8.7px;color:rgb(0,0,0);font-weight:normal;font-style:normal;text-decoration: none}
span.cls_004{font-family:Times,serif;font-size:9.7px;color:rgb(255,255,255);font-weight:normal;font-style:normal;text-decoration: none}
div.cls_004{font-family:Times,serif;font-size:9.7px;color:rgb(255,255,255);font-weight:normal;font-style:normal;text-decoration: none}
span.cls_005{font-family:Times,serif;font-size:7.7px;color:rgb(255,255,255);font-weight:normal;font-style:normal;text-decoration: none}
div.cls_005{font-family:Times,serif;font-size:7.7px;color:rgb(255,255,255);font-weight:normal;font-style:normal;text-decoration: none}
span.cls_006{font-family:Times,serif;font-size:6.8px;color:rgb(255,255,255);font-weight:normal;font-style:normal;text-decoration: none}
div.cls_006{font-family:Times,serif;font-size:6.8px;color:rgb(255,255,255);font-weight:normal;font-style:normal;text-decoration: none}
span.cls_007{font-family:Times,serif;font-size:8.7px;color:rgb(255,255,255);font-weight:normal;font-style:normal;text-decoration: none}
div.cls_007{font-family:Times,serif;font-size:8.7px;color:rgb(255,255,255);font-weight:normal;font-style:normal;text-decoration: none}
span.cls_008{font-family:Times,serif;font-size:9.7px;color:rgb(0,0,0);font-weight:normal;font-style:normal;text-decoration: none}
div.cls_008{font-family:Times,serif;font-size:9.7px;color:rgb(0,0,0);font-weight:normal;font-style:normal;text-decoration: none}
span.cls_009{font-family:Times,serif;font-size:11.6px;color:rgb(255,255,255);font-weight:normal;font-style:normal;text-decoration: none}
div.cls_009{font-family:Times,serif;font-size:11.6px;color:rgb(255,255,255);font-weight:normal;font-style:normal;text-decoration: none}
-->
</style>
<script type="text/javascript" src="988612d4-0eef-11eb-8b25-0cc47a792c0a_id_988612d4-0eef-11eb-8b25-0cc47a792c0a_files/wz_jsgraphics.js"></script>
</head>
    
<body>
<div style="position:absolute;left:50%;margin-left:-297px;top:0px;width:595px;height:841px;border-style:outset;overflow:hidden">
<div style="position:absolute;left:0px;top:0px">
<img src="988612d4-0eef-11eb-8b25-0cc47a792c0a_id_988612d4-0eef-11eb-8b25-0cc47a792c0a_files/background1.jpg" width=595 height=841></div>
<div style="position:absolute;left:240.00px;top:44.56px" class="cls_002"><span class="cls_002">RESONANCE URUGUAY S.A.</span></div>
<div style="position:absolute;left:240.00px;top:56.32px" class="cls_002"><span class="cls_002">26144054</span></div>
<div style="position:absolute;left:240.00px;top:68.80px" class="cls_002"><span class="cls_002">Montevideo - Uruguay</span></div>
<div style="position:absolute;left:240.00px;top:80.68px" class="cls_002"><span class="cls_002">Monzón 1839</span></div>
<div style="position:absolute;left:67.92px;top:150.16px" class="cls_003"><span class="cls_003">Ofissi SA - Servicentro San Jose</span></div>
<div style="position:absolute;left:370.21px;top:151.96px" class="cls_004"><span class="cls_004">Código Cliente</span></div>
<div style="position:absolute;left:438.61px;top:151.96px" class="cls_004"><span class="cls_004">Fecha Emision</span></div>
<div style="position:absolute;left:515.53px;top:151.96px" class="cls_004"><span class="cls_004">Moneda</span></div>
<div style="position:absolute;left:67.92px;top:165.40px" class="cls_003"><span class="cls_003">Ruta 3 Km. 93.700</span></div>
<div style="position:absolute;left:388.32px;top:167.80px" class="cls_002"><span class="cls_002">C11918</span></div>
<div style="position:absolute;left:451.22px;top:167.80px" class="cls_002"><span class="cls_002">15/07/2020</span></div>
<div style="position:absolute;left:524.88px;top:167.80px" class="cls_002"><span class="cls_002">UYU</span></div>
<div style="position:absolute;left:380.88px;top:181.12px" class="cls_004"><span class="cls_004">Vendedor</span></div>
<div style="position:absolute;left:437.04px;top:181.12px" class="cls_004"><span class="cls_004">Forma de Pago</span></div>
<div style="position:absolute;left:508.56px;top:181.12px" class="cls_004"><span class="cls_004">Distribuidor</span></div>
<div style="position:absolute;left:394.92px;top:196.96px" class="cls_002"><span class="cls_002">V08</span></div>
<div style="position:absolute;left:458.04px;top:196.96px" class="cls_002"><span class="cls_002">Crédito</span></div>
<div style="position:absolute;left:22.08px;top:212.56px" class="cls_005"><span class="cls_005">Cantidad</span></div>
<div style="position:absolute;left:78.24px;top:212.56px" class="cls_005"><span class="cls_005">Detalle</span></div>
<div style="position:absolute;left:420.72px;top:213.28px" class="cls_005"><span class="cls_005">Unitario</span></div>
<div style="position:absolute;left:463.68px;top:213.88px" class="cls_006"><span class="cls_006">I.V.A.</span></div>
<div style="position:absolute;left:499.90px;top:213.28px" class="cls_005"><span class="cls_005">Subtotal Neto</span></div>
<div style="position:absolute;left:277.92px;top:514.59px" class="cls_007"><span class="cls_007">Totales</span></div>
<div style="position:absolute;left:22.08px;top:528.04px" class="cls_002"><span class="cls_002">Subtotal Exento:</span></div>
<div style="position:absolute;left:138.96px;top:528.04px" class="cls_002"><span class="cls_002">0,00 Subtotal t/bás.:</span></div>
<div style="position:absolute;left:254.52px;top:528.04px" class="cls_002"><span class="cls_002">1.111,41 Iva t/bás.:</span></div>
<div style="position:absolute;left:328.20px;top:528.04px" class="cls_002"><span class="cls_002">22,00 %:</span></div>
<div style="position:absolute;left:401.75px;top:528.04px" class="cls_002"><span class="cls_002">244,51</span></div>
<div style="position:absolute;left:158.16px;top:544.00px" class="cls_002"><span class="cls_002">Redondeo:</span></div>
<div style="position:absolute;left:260.92px;top:544.00px" class="cls_002"><span class="cls_002">985,59 Total Recargos:</span></div>
<div style="position:absolute;left:410.42px;top:544.72px" class="cls_002"><span class="cls_002">0,08</span></div>
<div style="position:absolute;left:20.64px;top:591.64px" class="cls_002"><span class="cls_002">ESTA FACTURA PUEDE ABONARSE EN SISTARBANC (</span><A HREF="http://www.spe.com.uy/">www.spe.com.uy</A>) O EN REDPAGOS.</div>
<div style="position:absolute;left:340.68px;top:646.84px" class="cls_003"><span class="cls_003">_______________________________________________</span></div>
<div style="position:absolute;left:105.36px;top:652.00px" class="cls_002"><span class="cls_002">Puede verificar comprobante en: </span><A HREF="https://www.efactura.dgi.gub/">https://www.efactura.dgi.gub</A> </div>
<div style="position:absolute;left:339.36px;top:654.40px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:564.96px;top:654.40px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:339.36px;top:661.36px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:343.44px;top:659.32px" class="cls_002"><span class="cls_002">HORA RECIBIDO</span></div>
<div style="position:absolute;left:564.96px;top:660.64px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:105.36px;top:663.76px" class="cls_002"><span class="cls_002">IVA al día</span></div>
<div style="position:absolute;left:340.68px;top:662.79px" class="cls_003"><span class="cls_003">_______________________________________________</span></div>
<div style="position:absolute;left:339.36px;top:668.32px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:564.96px;top:667.60px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:105.36px;top:675.64px" class="cls_002"><span class="cls_002">CAE:</span></div>
<div style="position:absolute;left:126.24px;top:675.64px" class="cls_002"><span class="cls_002">90200016216</span></div>
<div style="position:absolute;left:339.36px;top:675.28px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:343.44px;top:674.56px" class="cls_002"><span class="cls_002">FIRMA</span></div>
<div style="position:absolute;left:564.96px;top:674.56px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:339.36px;top:682.12px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:564.96px;top:681.52px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:105.36px;top:687.40px" class="cls_002"><span class="cls_002">60001 - 80000</span></div>
<div style="position:absolute;left:339.36px;top:689.08px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:564.96px;top:688.48px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:339.36px;top:696.04px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:564.96px;top:695.32px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:339.36px;top:703.00px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:564.96px;top:702.28px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:265.80px;top:702.77px" class="cls_008"><span class="cls_008">Vigencia CAE</span></div>
<div style="position:absolute;left:339.36px;top:709.96px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:564.96px;top:709.24px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:20.64px;top:717.88px" class="cls_002"><span class="cls_002">Código Seguridad:  NPCFPP</span></div>
<div style="position:absolute;left:273.84px;top:714.51px" class="cls_003"><span class="cls_003">05/01/2022</span></div>
<div style="position:absolute;left:339.36px;top:716.20px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:340.68px;top:715.60px" class="cls_003"><span class="cls_003">_______________________________________________</span></div>
<div style="position:absolute;left:564.96px;top:716.20px" class="cls_002"><span class="cls_002">|</span></div>
<div style="position:absolute;left:271.20px;top:764.44px" class="cls_002"><span class="cls_002">*7Y0011918007174631072020*</span></div>
<div style="position:absolute;left:38.76px;top:778.00px" class="cls_009"><span class="cls_009">Vencimiento</span></div>
<div style="position:absolute;left:46.56px;top:794.81px" class="cls_008"><span class="cls_008">31/07/2020</span></div>
<div style="position:absolute;left:271.68px;top:798.40px" class="cls_002"><span class="cls_002">*000000000000000013560007*</span></div>
<div style="position:absolute;left:542.64px;top:797.44px" class="cls_002"><span class="cls_002">1</span></div>
<div style="position:absolute;left:555.23px;top:796.84px" class="cls_003"><span class="cls_003">1</span></div>
</div>

</body>

</html>
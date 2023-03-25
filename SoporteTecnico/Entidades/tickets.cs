using System;

namespace Entidades
{
    public class tickets
    {
        public string tiposoporte { get; set; }

        public string impuesto { get; set; }
        public String total { get; set; }
        public string descuento { get; set; }
        public string descripcionsolicitud { get; set; }
        public string respuestaSolisitud { get; set; }
        public string precio { get; set; }

        public tickets()
        {
        }

        public tickets(string tiposoporte, string impuesto, string total, string descuento, string descripcionsolicitud, string respuestaSolisitud, string precio)
        {
            this.tiposoporte = tiposoporte;
            this.impuesto = impuesto;
            this.total = total;
            this.descuento = descuento;
            this.descripcionsolicitud = descripcionsolicitud;
            this.respuestaSolisitud = respuestaSolisitud;
            this.precio = precio;
        }

    }
}

namespace Entidades
{
    public class Clientes
    {
        public string CodCliente { get; set; }
        public string NombreClie { get; set; }
        public string DireccionClie { get; set; }
        public string correoclie { get; set; }
        public string Telefono { get; set; }

        public Clientes()
        {
        }

        public Clientes(string codCliente, string nombreClie, string direccionClie, string correoclie, string telefono)
        {
            CodCliente = codCliente;
            NombreClie = nombreClie;
            DireccionClie = direccionClie;
            this.correoclie = correoclie;
            Telefono = telefono;
        }



    }
}

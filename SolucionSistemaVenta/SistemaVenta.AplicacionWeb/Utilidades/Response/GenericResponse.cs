namespace SistemaVenta.AplicacionWeb.Utilidades.Response
{
    public class GenericResponse<Tobject>
    {
        public bool Estado { get; set; }
        public string? Mensaje { get; set; }
        public Tobject? Objeto { get; set; }
        public List<Tobject>? ListaObjeto { get; set; }

    }
}

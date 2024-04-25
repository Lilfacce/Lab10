namespace Lab10
{
    public class Padre
    {
        public int Id { get; set; }
        public string Cadena { get; set; }
        public DateTime Fecha { get; set; }

        //Construxtor: se ejecuta cada vez que se crea

        private string DatoPrivado { get; set; }

        protected string DatoProtegido { get; set; }

        public Padre()
        {
            Cadena = "";
            Fecha = DateTime.Now;
        }
    }
}

namespace WebAPI.Examples
{
    public class Uno
    {
        private readonly IClases otra;
        public Uno(IClases otra)
        {
            this.otra = otra;
        }
        public void Otro()
        {
            otra.LoQueSea();
        }

        public void Mas()
        {
            otra.LoQueSea();
        }
    }
}
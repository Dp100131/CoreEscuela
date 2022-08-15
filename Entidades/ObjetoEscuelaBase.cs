using System;
namespace CorEscuela.Entidades
{
    public class ObjetoEscuelaBase
    {
        public string UniqueID { get; set; } 
        public string Nombre { get; set; }
        public ObjetoEscuelaBase()
        {
            UniqueID = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre}, {UniqueID}";
        }
    }
}
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
    }
}
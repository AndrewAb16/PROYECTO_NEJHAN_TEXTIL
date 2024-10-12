using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Proveedor
    {
        public int IdProveedor { get; set; }
        public string Ruc {  get; set; }
        public string RazonSocial_pv { get; set; }
        public string Nombres {  get; set; }
        public string Apellidos { get; set; }
        public int Codigo_Sx { get; set; }
        public int Codigo_RB {  get; set; }
        public string Correo_pv { get; set; }
        public string Telefono_pv { get; set; }
        public string Observacion_pv { get; set; }
    }
}

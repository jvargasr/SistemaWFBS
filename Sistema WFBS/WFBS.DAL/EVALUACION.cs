//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFBS.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class EVALUACION
    {
        public EVALUACION()
        {
            this.DETALLE_EVALUACION = new HashSet<DETALLE_EVALUACION>();
        }
    
        public decimal ID_EVALUACION { get; set; }
        public Nullable<decimal> ID_AREA { get; set; }
        public decimal ID_PERIODO_EVALUACION { get; set; }
        public Nullable<decimal> ID_TIPO_EVALUACION { get; set; }
        public Nullable<decimal> ID_COMPETENCIA { get; set; }
        public string RUT_EVALUADO { get; set; }
        public string RUT_EVALUADOR { get; set; }
        public Nullable<decimal> NOTA_ESPERADA_COMPETENCIA { get; set; }
        public System.DateTime FECHA_CONTESTA_ENCUESTA { get; set; }
        public decimal NOTA_ENCUESTA { get; set; }
    
        public virtual AREA AREA { get; set; }
        public virtual COMPETENCIA COMPETENCIA { get; set; }
        public virtual ICollection<DETALLE_EVALUACION> DETALLE_EVALUACION { get; set; }
        public virtual TIPO_EVALUACION TIPO_EVALUACION { get; set; }
        public virtual PERIODO_EVALUACION PERIODO_EVALUACION { get; set; }
    }
}
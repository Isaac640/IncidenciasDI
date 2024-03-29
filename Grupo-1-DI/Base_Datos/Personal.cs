﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1_DI.Base_Datos
{
    public class Personal
    {
        public long id {  get; set; }
        public string dni {  get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public string cp {  get; set; }
        public string tlf { get; set; }
        public int activo { get; set; }
        public Departamentos departamento_id { get; set; }
    }
}

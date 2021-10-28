﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaLogica
{
   public class ControladorCompra
    {
        public static void AltaCompra(string CedulaComprador, string Producto, string Precio)
        {
            ModeloCompra c = new ModeloCompra();

            c.CedulaComprador = CedulaComprador;
            c.Producto = Producto;
            c.Precio = Precio;

            c.DarAltaCompra();
        }

    }
}
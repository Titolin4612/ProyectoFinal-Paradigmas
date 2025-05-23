﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_ProyectoFinalPOO.Clases
{
    public class CartaPremio : Carta
    {
        // Atributo
        private string _bendicion;
        // Valor carta
        private static int vPremio = 5;

        // Accesor
        public string Bendicion
        {
            get => _bendicion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Error, la bendicion es inválida.");
                _bendicion = value;
            }
        }
        public static int VPremio { get => vPremio; }

        // Constructor
        public CartaPremio(string nombre, string descripcion, string mitologia, string bendicion, string imagenUrl) 
        : base(nombre, descripcion, mitologia, imagenUrl) 
        {
            Bendicion = bendicion;
        }

        public override int ObtenerPuntos()
        {
            return VPremio;
        }

    }
}

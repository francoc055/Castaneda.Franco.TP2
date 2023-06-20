﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        string nombre;
        int cantidadDePuntos = 0;
        List<Carta> mano;
        List<Carta> cartasParaPuntos;

        public string? Nombre { get => nombre; set => nombre = value; }
        public int CantidadDePuntos { get => cantidadDePuntos; set => cantidadDePuntos = value; }
        public List<Carta> Mano { get => mano; set => mano = value; }
        public List<Carta> CartasParaPuntos { get => cartasParaPuntos; set => cartasParaPuntos = value; }

        private Jugador()
        {
            Mano = new List<Carta>();
            cartasParaPuntos = new List<Carta>();
        }
        public Jugador(string nombre) : this()
        {
            this.Nombre = nombre;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}

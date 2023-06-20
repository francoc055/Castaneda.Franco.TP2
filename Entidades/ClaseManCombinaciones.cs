using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseManCombinaciones
    {

        public List<Carta> SumarTodasLasCartas(Jugador jugador, List<Carta> cartasEnMesa, List<Carta> indices)
        {
            int suma = 0;
            foreach (Carta carta in jugador.Mano)
            {
                suma = carta.Valor;
                foreach (Carta item in cartasEnMesa)
                {
                    suma += item.Valor;
                }
                if (suma == 15)
                {
                    indices.Clear();
                    indices.Add(carta);
                    break;
                }
                else
                {
                    suma = 0;
                }
            }

            if (suma == 15)
            {
                foreach (Carta item in cartasEnMesa)
                {
                    indices.Add(item);                                                           
                }
            }

            return indices;
        }

        public List<Carta> SumarPorUnaCarta(Jugador jugador, List<Carta> cartasEnMesa, List<Carta> indices)
        {
            for (int i = 0; i < jugador.Mano.Count; i++)
            {
                for (int j = 0; j < cartasEnMesa.Count; j++)
                {
                    if ((jugador.Mano[i].Valor + cartasEnMesa[j].Valor) == 15)
                    {
                        indices.Clear();
                        indices.Add(cartasEnMesa[j]);
                        indices.Add(jugador.Mano[i]);
                    }
                }
            }

            return indices;
        }

        public List<Carta> SumarPorDosCartas(Jugador jugador, List<Carta> cartasEnMesa, List<Carta> indices)
        {
            for (int i = 0; i < jugador.Mano.Count; i++)
            {
                for (int j = 0; j < cartasEnMesa.Count; j++)
                {
                    if (j == 3)
                    {
                        break;
                    }
                    for (int k = 1 + j; k < cartasEnMesa.Count; k++)
                    {
                        if ((jugador.Mano[i].Valor + cartasEnMesa[j].Valor + cartasEnMesa[k].Valor) == 15)
                        {
                            indices.Clear();
                            indices.Add(cartasEnMesa[j]);
                            indices.Add(cartasEnMesa[k]);
                            indices.Add(jugador.Mano[i]);
                        }
                    }
                }
            }

            return indices;
        }

        public List<Carta> SumarPorTresCartas(Jugador jugador, List<Carta> cartasEnMesa, List<Carta> indices)
        {
            for (int i = 0; i < jugador.Mano.Count; i++)
            {
                for (int j = 0; j < cartasEnMesa.Count; j++)
                {
                    for (int k = 1 + j; k < cartasEnMesa.Count; k++)
                    {
                        // evaluo la combinacion con el indice j en 0 -> 0 1 2, 0 2 3, 0 1 3 -> '15'
                        if (j == 0)
                        {
                            if (k == 3 && j == 0)
                            {
                                if ((jugador.Mano[i].Valor + cartasEnMesa[j].Valor + cartasEnMesa[k - 2].Valor + cartasEnMesa[k].Valor) == 15)
                                {
                                    indices.Clear();
                                    indices.Add(cartasEnMesa[j]);
                                    indices.Add(cartasEnMesa[k-2]);
                                    indices.Add(cartasEnMesa[k]);
                                    indices.Add(jugador.Mano[i]);
                                }
                            }
                            else if (k == 3)
                            {
                                break;
                            }
                            else if ((jugador.Mano[i].Valor + cartasEnMesa[j].Valor + cartasEnMesa[k].Valor + cartasEnMesa[k + 1].Valor) == 15)
                            {
                                indices.Clear();
                                indices.Add(cartasEnMesa[j]);
                                indices.Add(cartasEnMesa[k]);
                                indices.Add(cartasEnMesa[k+1]);
                                indices.Add(jugador.Mano[i]);
                            }
                        }
                        // evaluo la combinacion con el indice j en 1 -> 1 2 3 = '15'
                        else if (j == 1 && k == 2)
                        {
                            if ((jugador.Mano[i].Valor + cartasEnMesa[j].Valor + cartasEnMesa[k].Valor + cartasEnMesa[k + 1].Valor) == 15)
                            {
                                indices.Clear();
                                indices.Add(cartasEnMesa[j]);
                                indices.Add(cartasEnMesa[k]);
                                indices.Add(cartasEnMesa[k + 1]);
                                indices.Add(jugador.Mano[i]);
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return indices;
        }
    }
}

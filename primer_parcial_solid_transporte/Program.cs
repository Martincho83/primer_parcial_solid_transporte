﻿using System;
using System.Collections.Generic;

namespace primer_parcial_solid_transporte
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ITransporte> transportes = new List<ITransporte>();

            Avion avion1 = new Avion("AVION 01",0,100,0,100);
           // avion1._nombre = "AVION 01";
           // avion1._velocidadActual = 0;
           // avion1._velocidadMaxima = 100;
           // avion1._alturaActual = 0;
           // avion1._alturaMaxima = 100;
            transportes.Add(avion1);

            Avion avion2 = new Avion("AVION 02",0,100,0,100);
           // avion2._nombre = "AVION 02";
           // avion2._velocidadActual = 0;
           // avion2._velocidadMaxima = 100;
           // avion2._alturaActual = 0;
           // avion2._alturaMaxima = 100;
            transportes.Add(avion2);

            Tren tren1 = new Tren("TREN 01",0,100);
            //tren1._nombre = "TREN 01";
            //tren1._velocidadActual = 0;
            //tren1._velocidadMaxima = 100;
            transportes.Add(tren1);

            Console.WriteLine("Inicio del viaje :)");

            foreach (ITransporte transporte in transportes)
            {
                if (transporte is Avion)
                {
                    Avion avion =(Avion) transporte;
                    avion.Mover();//Llamada a metodo especifico de avion
                    avion.Volar(10);
                }
                else
                {
                    transporte.Mover();//Llamada al metodo general mover
                    transporte.Acelerar(10);
                }
            }

            Console.WriteLine("Fin del viaje :)");
        }
    }
}

﻿using CursoDesignPatterns2.Musica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Piano piano = new Piano();
            piano.Toca(Testando.DoReMiFa());
        }
    }
}

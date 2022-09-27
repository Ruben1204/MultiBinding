using MultiBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiBinding.ViewModels
{
    public class MainViewModel
    {
        public Usuario user { get; set; }

        public MainViewModel() 
        
       {
            user = new Usuario()
            {
                PrimerNombre ="Ruben",
                SegundoNombre ="Dario",
                Edad="Tengo una edad de 32 años"
            };
        
        }  
    }
}

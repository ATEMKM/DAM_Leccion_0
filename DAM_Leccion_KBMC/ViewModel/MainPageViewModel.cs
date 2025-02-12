using DAM_Leccion_KBMC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM_Leccion_KBMC.ViewModel
{
    public class MainPageViewModel
    {
        
        public PersonaModel personasModel{ get; set; }

        public MainPageViewModel() {
            Consultar();
        }


        public void Consultar()
        {
            personasModel = new PersonaModel()
            {
                Nombre = "alondra",
                Apellido="montalvo",
                Edad="98",
            };
        }


    }




}

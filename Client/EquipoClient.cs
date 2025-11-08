using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ices.client.models;

namespace ices.client.Client
{
    public static class EquipoClient
    {
        private static readonly List<Equipo> equipos = new()
        {
            new Equipo (){
                Id=1,
                clv_depto ="2",
                ns="comp-1",
                modelo="inspiron 15",
                marca="dell",
                caracteristicas="equipo porno",
                status="1",
                tipo_equipo="admin",
            },
             new Equipo (){
                Id=2,
                clv_depto ="4",
                ns="compu-255",
                modelo="razer",
                marca="amd",
                caracteristicas="equipo admin",
                status="1",
                tipo_equipo="caja",
            }
        };

        public static Equipo[] GetEquipos()
        {
            return equipos.ToArray();
        }
        public static void AddEquipo(Equipo equipo)
        {
            equipo.Id= equipos.Max(equipo=>equipo.Id)+1;
            equipos.Add(equipo);
        }

    }
}
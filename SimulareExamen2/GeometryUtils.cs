using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulareExamen2
{
    public static class GeometryUtils
    {
        public static void Translate(int ox, int oy, Triunghi[] triunghiuri)
        {
            for (int i = 0; i < triunghiuri.Length; i++)
            {
                triunghiuri[i].A.X = triunghiuri[i].A.X + ox;
                triunghiuri[i].A.Y = triunghiuri[i].A.Y + oy;
                triunghiuri[i].B.X = triunghiuri[i].B.X + ox;
                triunghiuri[i].B.Y = triunghiuri[i].B.Y + oy;
                triunghiuri[i].C.X = triunghiuri[i].C.X + ox;
                triunghiuri[i].C.Y = triunghiuri[i].C.Y + oy;
            }
        }
        public static void Translate(int ox, int oy, Dreptunghi[] dreptunghiuri)
        {
            for (int i = 0; i < dreptunghiuri.Length; i++)
            {
                dreptunghiuri[i].A.X = dreptunghiuri[i].A.X + ox;
                dreptunghiuri[i].A.Y = dreptunghiuri[i].A.Y + oy;
                dreptunghiuri[i].B.X = dreptunghiuri[i].B.X + ox;
                dreptunghiuri[i].B.Y = dreptunghiuri[i].B.Y + oy;
                dreptunghiuri[i].C.X = dreptunghiuri[i].C.X + ox;
                dreptunghiuri[i].C.Y = dreptunghiuri[i].C.Y + oy;
                dreptunghiuri[i].D.X = dreptunghiuri[i].D.X + ox;
                dreptunghiuri[i].D.Y = dreptunghiuri[i].D.Y + oy;
            }
        }
    }
}

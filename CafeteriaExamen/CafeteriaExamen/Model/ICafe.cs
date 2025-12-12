using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaExamen
{
    //todo tipo de café (simple o decorado) debe poder decir su descripción y su costo.”
    public interface ICafe
    {
        string Descripcion();
        double Costo();
    }

}

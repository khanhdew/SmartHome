using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Models;

namespace Services.Models.Devices
{
    internal class Light : Device, ILight
    {
        public int? Dim { get; set; }
        
        public void TurnOn()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void SetDim(int dim)
        {
            throw new NotImplementedException();
        }
    }
}

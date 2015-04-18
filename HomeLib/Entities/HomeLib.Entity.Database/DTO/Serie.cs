using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.DTO
{
    public class Serie : ISerie
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}

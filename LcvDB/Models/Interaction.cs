using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LcvDB.Models
{
    public class Interaction
    {
        public int Id { get; set; }

        public string InteractionName { get; set; }

        public InteractionType InteractionType { get; set; }

        public bool IsAdmin { get; set; } = false;

    }
}

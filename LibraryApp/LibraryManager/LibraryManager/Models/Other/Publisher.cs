using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models.Other
{
    public class Publisher
    {
        public string IdPublisher { get; set; } = string.Empty;
        public string NamePublisher { get; set; } = string.Empty;

        public Publisher(string idPublisher, string namePublisher)
        {
            IdPublisher = idPublisher;
            NamePublisher = namePublisher;
        }
    }
}

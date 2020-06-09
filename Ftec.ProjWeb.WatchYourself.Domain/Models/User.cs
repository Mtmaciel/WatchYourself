using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ftec.ProjWeb.WatchYourself.Domain.Models
{
    public class User
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public byte[] Password { get; set; }

        public byte[] Salt { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.Models.Interfaces
{
    public interface IBase
    {
        int ID { get; set; }
        bool CanBeDeleted();
    }
}
using System.ComponentModel.DataAnnotations;
using MobileStore.Models.Metadata;
using MobileStore.Models.Interfaces;

namespace MobileStore.Models
{
    [MetadataType(typeof(ManufacturerMetadata))]
    public partial class Manufacturer : IBase
    {
        public bool CanBeDeleted()
        {
            return true;
        }
    }
}
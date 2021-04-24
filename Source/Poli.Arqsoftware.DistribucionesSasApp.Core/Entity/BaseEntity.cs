using System;
namespace Poli.Arqsoftware.DistribucionesSasApp.Core.Entity
{
    public class BaseEntity
    {

        public bool Enable { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public DateTime? LastModifiedBy { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string DeletedBy { get; set; }
    }
}

using System;
namespace Poli.Arqsoftware.DistribucionesSasApp.Core.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public bool Enable { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string DeletedBy { get; set; }
    }
}

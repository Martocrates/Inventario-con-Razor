using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }
        [Required]
        public DateTime LastUpdate { get; set; }
        [Required]
        public int PartialQuantity { get; set; }

        //Relacion con productos
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }

        //Relacion con Bodegas - Wharehouse
        public string WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }

        //Relacion con movimientos OutputInput
        public ICollection<InputOutputEntity> InputOutputs { get; set; }


    }
}

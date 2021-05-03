namespace Exap_14
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Специальности
    {
        [Key]
        [Column("Код специальности")]
        public long Код_специальности { get; set; }

        [Column("[Наименование специальности")]
        [StringLength(50)]
        public string C_Наименование_специальности { get; set; }

        [Column("[Описание специальности")]
        public string C_Описание_специальности { get; set; }
    }
}

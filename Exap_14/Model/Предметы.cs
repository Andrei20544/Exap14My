namespace Exap_14
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Предметы
    {
        [Key]
        [Column("Код предмета")]
        public long Код_предмета { get; set; }

        [Column("Наименование предмета")]
        [StringLength(50)]
        public string Наименование_предмета { get; set; }

        [Column("Описание предмета")]
        public string Описание_предмета { get; set; }
    }
}

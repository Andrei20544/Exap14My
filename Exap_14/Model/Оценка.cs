namespace Exap_14
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Оценка
    {
        [Column("Код студента")]
        public long? Код_студента { get; set; }

        [Column("Дата экзамена", TypeName = "date")]
        public DateTime? Дата_экзамена { get; set; }

        [Column("Код предмета 1")]
        public long? Код_предмета_1 { get; set; }

        [Column("Оценка 1")]
        public byte? Оценка_1 { get; set; }

        [Key]
        [Column("Дата эказмена 2", TypeName = "date")]
        public DateTime Дата_эказмена_2 { get; set; }

        [Column("Код предмета 2")]
        public long? Код_предмета_2 { get; set; }

        [Column("Оценка 2")]
        public byte? Оценка_2 { get; set; }

        [Column("Дата экзамена 3", TypeName = "date")]
        public DateTime? Дата_экзамена_3 { get; set; }

        [Column("Код предмета")]
        public long? Код_предмета { get; set; }

        [Column("Оценка 3")]
        public byte? Оценка_3 { get; set; }

        [Column("Средний балл")]
        public float? Средний_балл { get; set; }
    }
}

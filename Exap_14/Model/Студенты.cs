namespace Exap_14
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Студенты
    {
        [Key]
        [Column("Код студента")]
        public long Код_студента { get; set; }

        [StringLength(50)]
        public string ФИО { get; set; }

        [StringLength(10)]
        public string Пол { get; set; }

        [Column("Дата рождения", TypeName = "date")]
        public DateTime? Дата_рождения { get; set; }

        [StringLength(50)]
        public string Родители { get; set; }

        public string Адрес { get; set; }

        [StringLength(15)]
        public string Телефон { get; set; }

        [Column("Паспортные данные")]
        public string Паспортные_данные { get; set; }

        [Column("Номер зачётки")]
        public long? Номер_зачётки { get; set; }

        [Column("Дата поступления", TypeName = "date")]
        public DateTime? Дата_поступления { get; set; }

        [StringLength(10)]
        public string Группа { get; set; }

        public byte? Курс { get; set; }

        [Column("Код специальности")]
        public long? Код_специальности { get; set; }

        [Column("Очная форма обучения")]
        public bool? Очная_форма_обучения { get; set; }
    }
}

namespace Exap_14
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelBD : DbContext
    {
        public ModelBD()
            : base("name=ModelBD")
        {
        }

        public virtual DbSet<Предметы> Предметы { get; set; }
        public virtual DbSet<Специальности> Специальности { get; set; }
        public virtual DbSet<Студенты> Студенты { get; set; }
        public virtual DbSet<Оценка> Оценка { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Предметы>()
                .Property(e => e.Наименование_предмета)
                .IsUnicode(false);

            modelBuilder.Entity<Предметы>()
                .Property(e => e.Описание_предмета)
                .IsUnicode(false);

            modelBuilder.Entity<Специальности>()
                .Property(e => e.C_Наименование_специальности)
                .IsUnicode(false);

            modelBuilder.Entity<Специальности>()
                .Property(e => e.C_Описание_специальности)
                .IsUnicode(false);

            modelBuilder.Entity<Студенты>()
                .Property(e => e.ФИО)
                .IsUnicode(false);

            modelBuilder.Entity<Студенты>()
                .Property(e => e.Пол)
                .IsUnicode(false);

            modelBuilder.Entity<Студенты>()
                .Property(e => e.Родители)
                .IsUnicode(false);

            modelBuilder.Entity<Студенты>()
                .Property(e => e.Адрес)
                .IsUnicode(false);

            modelBuilder.Entity<Студенты>()
                .Property(e => e.Телефон)
                .IsUnicode(false);

            modelBuilder.Entity<Студенты>()
                .Property(e => e.Паспортные_данные)
                .IsUnicode(false);

            modelBuilder.Entity<Студенты>()
                .Property(e => e.Группа)
                .IsUnicode(false);
        }
    }
}

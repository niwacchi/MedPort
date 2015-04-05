namespace LedgerStats.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class MyLedgerDb : DbContext
    {
        // コンテキストは、アプリケーションの構成ファイル (App.config または Web.config) から 'MyDB' 
        // 接続文字列を使用するように構成されています。既定では、この接続文字列は LocalDb インスタンス上
        // の 'LedgerStats.Models.MyDB' データベースを対象としています。 
        // 
        // 別のデータベースとデータベース プロバイダーまたはそのいずれかを対象とする場合は、
        // アプリケーション構成ファイルで 'MyDB' 接続文字列を変更してください。
        public MyLedgerDb()
            : base("name=MyLedgerDb")
        {
        }

        // モデルに含めるエンティティ型ごとに DbSet を追加します。Code First モデルの構成および使用の
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=390109 を参照してください。

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Patient> Patient { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    [Table("Patient")]
    public class Patient
    {
        [DisplayName("患者ID")]
        [Column("Id")]
        public int Id { get; set; }

        [DisplayName("プロフィール番号")]
        [Column("No")]
        public int No { get; set; }

        [DisplayName("患者氏名")]
        [Column("Name")]
        public string Name { get; set; }
    }
}
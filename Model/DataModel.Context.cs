﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace Model
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class OAEntities1 : DbContext
{
    public OAEntities1()
        : base("name=OAEntities1")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<ActionInfo> ActionInfo { get; set; }

    public virtual DbSet<Books> Books { get; set; }

    public virtual DbSet<Department> Department { get; set; }

    public virtual DbSet<KeyWordsRank> KeyWordsRank { get; set; }

    public virtual DbSet<R_UserInfo_ActionInfo> R_UserInfo_ActionInfo { get; set; }

    public virtual DbSet<RoleInfo> RoleInfo { get; set; }

    public virtual DbSet<SearchDetails> SearchDetails { get; set; }

    public virtual DbSet<UserInfo> UserInfo { get; set; }

    public virtual DbSet<WF_Temp> WF_TempSet { get; set; }

    public virtual DbSet<WF_Item> WF_ItemSet { get; set; }

    public virtual DbSet<FileInfo> FileInfoSet { get; set; }

    public virtual DbSet<WF_Step> WF_StepSet { get; set; }

}

}


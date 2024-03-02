﻿using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {

        }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<Anh> anhs { get; set; }
        public DbSet<MauSac> mauSacs { get; set; }
        public DbSet<LichSuMuaHang> lichSuMuaHangs { get; set; }
        public DbSet<DoiTra> doiTras { get; set; }
        public DbSet<KichCo> KichCos { get; set; }
        public DbSet<CTGioHang> CTGioHangs { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ChatLieu> chatlieus { get; set; }
        public DbSet<Voucher> vouchers { get; set; }
        public DbSet<CTHoaDon> CtHoadons { get; set; }
        public DbSet<HoaDon> hoadons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-VANLOI\\SQLEXPRESS;Initial Catalog = MenShop; Integrated Security=True;Trust Server Certificate=True");
            }
        }
    }

}

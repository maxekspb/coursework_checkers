using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
namespace MyDBNames.Scheme;
public class ChessMove
{
    public int? id { get; set; }
    public string Color { get; set; }
    public int X1 { get; set; }
    public int Y1 { get; set; }
    public int X2 { get; set; }
    public int Y2 { get; set; }
    public bool IsKill { get; set; }
}


public class ApplicationContext : DbContext
{
 
        public DbSet<ChessMove> ChessMoves { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=max-laptop;Database=coursework;Trusted_Connection=True;TrustServerCertificate=True");
        }
    public void AddChessMove( string color, int x1, int y1, int x2, int y2, bool isKill)
    {
        ChessMove chessMove = new ChessMove
        {
            
            Color = color,
            X1 = x1,
            Y1 = y1,
            X2 = x2,
            Y2 = y2,
            IsKill = isKill
        };

        ChessMoves.Add(chessMove);
        SaveChanges();
    }
}


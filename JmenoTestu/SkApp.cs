using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JmenoTestu
{
    public class SkApp
    {
        public void Run()
        {
            Create();
        }
        public void Create()
        {
            using var context = new SkDbContext();
            var film = new Skladba()
            {
                Lenght = 200,
                Name = "Sex Disco Revoluce",
                Author = "CA$HANOVA BULHAR",
                Edited = DateTime.Now,
            };
            context.Add(film);
            context.SaveChanges();
        }
        public void Filter()
        {
            var input = Console.ReadLine();
            var inputArr = input.Split(' ');
            switch (inputArr[0].ToLowerInvariant())
            {
                case "add":
                    switch (inputArr[1].ToLowerInvariant())
                    {
                        case "-skladba":
                            break;
                    }
                    break;

            }
        }
    }
}


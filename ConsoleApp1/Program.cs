using DataLayer;
using System;
using System.Linq;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            AnvisaCorrigeAcentos();
        }

        private static void AnvisaCorrigeAcentos() {
            using (var ctx = new RemediosEntities()) {
                var corrigir = ctx.Produtos.Where(p => p.Nome.Contains("+")).ToList();

                foreach (var remedio in corrigir) {
                    var nome = remedio.Nome.Replace("+", " + ").Replace("  ", " ");
                    Console.WriteLine($"{remedio.Nome}  -  {nome}");
                    remedio.Nome = nome;
                }
                ctx.SaveChanges();

                Console.ReadLine();
            }
        }

        private static void AvisacadastraPrincipios() {
            //using (var ctx = new RemediosEntities()) {
            //    var sw = new Stopwatch();
            //    var dict = new Dictionary<string, PrincipioAtivo>();
            //    var counter = 0;
            //    sw.Start();
            //    foreach (var remedio in ctx.AnvisaRemedios) {
            //        counter++;
            //        var principios = remedio.PrincipioAtivo.Split(';')
            //            .Select(x => x.Trim()).Where(x => !string.IsNullOrEmpty(x));
            //        foreach (var principio in principios) {
            //            PrincipioAtivo pa;
            //            if (dict.ContainsKey(principio)) {
            //                pa = dict[principio];
            //            }
            //            else {
            //                pa = new PrincipioAtivo() { Nome = principio };
            //                dict.Add(principio, pa);
            //            }
            //            remedio.PrincipiosAtivos.Add(pa);
            //        }
            //        Console.WriteLine($"{counter}. {remedio.Produto.Nome} {remedio.PrincipiosAtivos.Count}");
            //    }
            //    sw.Stop();
            //    Console.WriteLine($"{sw.ElapsedMilliseconds / 6000} minutos");
            //    Console.WriteLine("Salvando...");
            //    ctx.SaveChanges(out var message);
            //    Console.WriteLine(message);
            //    Console.ReadKey();
            //}
        }
    }
}
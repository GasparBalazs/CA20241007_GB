using CA20241007_GB;
using System.Buffers.Binary;
using System.Collections.Immutable;
using System.Text;

Random rnd = new();
List<Versenyzo> versenyzok = [];

using StreamReader sr = new(@"..\..\..\src\forras.txt", Encoding.UTF8);
while (!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));

Console.WriteLine($"3. feladat: az allomanyban {versenyzok.Count} recept szerepel.");

var f1 = versenyzok.Count(r => r.EletkorKategoria == "elit junior");
Console.WriteLine($"1. feladat: {f1} versenyző van az elit junior kategóriában.");

var f2 = versenyzok.Average(r => 2024 - r.VersenyzoSzulEv);
Console.WriteLine($"2. feladat: A versenyzők átlagéletkora: {f2}");

var f3 = versenyzok.Sum(r => r.FutasIdo.Hour);
Console.WriteLine($"3. feladat: A versenyzők futással töltött összideje: {f3}");

var f4 = versenyzok.Where(r => r.EletkorKategoria == "20-24").Average(r => r.FutasIdo.Hour);
Console.WriteLine($"4. feladat: Az átlagos úszási idő a 20-24 kategóriában: {f4}");

//var f5 = versenyzok.Where(r => r.VersenyzoNeme == "n").OrderByDescending(r => r.OsszIdo).ToList();
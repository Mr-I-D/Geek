using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите артикул стеклопакета:");
        string input = Console.ReadLine();

        GlassPackageInfo packageInfo = ParseGlassPackage(input);

        if (packageInfo != null)
        {
            Console.WriteLine($"Камерность: {(packageInfo.ChamberCount == 1 ? "Однокамерный" : "Двухкамерный")}");
            Console.WriteLine($"Толщина всего СП: {packageInfo.TotalThickness} мм");
            Console.WriteLine($"Толщина стекла: {packageInfo.GlassThickness} мм");
        }
        else
        {
            Console.WriteLine("Некорректный формат артикула стеклопакета.");
        }
    }

    static GlassPackageInfo ParseGlassPackage(string input)
    {
        string pattern = @"\b(\d+)\s?(Стекло|Рамка)\b";
        MatchCollection matches = Regex.Matches(input, pattern);

        if (matches.Count > 0)
        {
            int chamberCount = matches.Count(x => x.Groups[2].Value == "Рамка");

            int totalThickness = matches.Cast<Match>().Sum(m => int.Parse(m.Groups[1].Value));
            int glassThickness = int.Parse(matches[0].Groups[1].Value);

            return new GlassPackageInfo
            {
                ChamberCount = chamberCount,
                TotalThickness = totalThickness,
                GlassThickness = glassThickness
            };
        }

        return null;
    }
}

class GlassPackageInfo
{
    public int ChamberCount { get; set; }
    public int TotalThickness { get; set; }
    public int GlassThickness { get; set; }
}

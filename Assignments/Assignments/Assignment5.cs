using System;
using System.Linq;

namespace Assignments;

class RealTimeExample
{

    public void FileHandlingTask()
    {

        // Read the file as one string.
        string[] data = File.ReadAllLines("Assignment5-data-dummy.csv");

        List<Player> player = new();

        for (int i = 1; i < data.Length; i++)
        {

            var a = data[i];
            var c = a.Split(',');
            // Console.WriteLine(c[0]);
            player.Add(new Player
            {
                Id = c[0],
                Name = c[1],
                Sex = c[2],
                Age = c[3],
                Height = c[4],
                Weight = c[5],
                Team = c[6],
                NOC = c[7],
                Games = c[8],
                Year = c[9],
                Season = c[10],
                City = c[11],
                Sport = c[12],
                Event = c[13],
                Medal = c[14],
            });
        }

        // 1.List all the players participated from Nepal.
        var peopleFromNepal = player.Where(x => x.NOC.ToUpper().Contains("NEP"));
        foreach (var people in peopleFromNepal)
            Console.WriteLine(people.Name);

        // 2. List all chinese players who have won the GOLD.
        var peopleFromChina = player.Where(x => x.NOC.ToUpper().Contains("CHN"));
        var chinaGold = peopleFromChina.Where(x => x.Medal.ToUpper().Contains("GOLD"));
        foreach (var people in chinaGold)
        {
            Console.WriteLine(people.Name);
        }


    }
}

class Player
{

    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Sex { get; set; }
    public string? Age { get; set; }
    public string? Height { get; set; }
    public string? Weight { get; set; }
    public string? Team { get; set; }
    public string? NOC { get; set; }
    public string? Games { get; set; }
    public string? Year { get; set; }
    public string? Season { get; set; }
    public string? City { get; set; }
    public string? Sport { get; set; }
    public string? Event { get; set; }
    public string? Medal { get; set; }
    //Year,Season,City,Sport,Event,Medal

}
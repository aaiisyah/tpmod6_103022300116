// See https://aka.ms/new-console-template for more information
using tpmodul6_103022300116;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - AISYAH");
        video.PrintVideoDetails();

        for (int i = 0; i < 10; i++)
        {
            video.IncreasePlayCount(1000000);
        }

        video.PrintVideoDetails();
    }
}


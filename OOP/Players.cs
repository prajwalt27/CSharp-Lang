


class Players
{
    public string name;
    public int  num;

    static int numOfPlayers = 0;
    public Players()
    {
        name = "Rohit";
        num = 45;
        numOfPlayers++;
    }

    public Players(string name="dumPlayer", int num = 0 )
    {
        this.name = name;
        this.num = num;
        numOfPlayers++;
    }

    public void MakeSound()
    {
        Console.WriteLine("{0} says {1}", name, num);
    }

    public static int getNumAnimals()
    {
        return numOfPlayers;
    }

}
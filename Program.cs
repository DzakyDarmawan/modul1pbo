class Laptop
{
    protected string merk;
    protected string tipe;

    public Laptop(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }

    public virtual void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala.");
    }

    public virtual void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati.");
    }

    public virtual void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game.");
    }

    public virtual void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class Vivobook : Laptop
{
    private string vgatipe;
    private string processormerk;
    private string processortipe;

    public Vivobook(string merk, string tipe, string vgatipe, string processormerk, string processortipe) : base(merk, tipe)
    {
        this.vgatipe = vgatipe;
        this.processormerk = processormerk;
        this.processortipe = processortipe;
    }

    public override void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala.");
    }
}

class ROG : Laptop
{
    private string vgatipe;
    private string processormerk;
    private string processortipe;

    public ROG(string merk, string tipe, string vgatipe, string processormerk, string processortipe) : base(merk, tipe)
    {
        this.vgatipe = vgatipe;
        this.processormerk = processormerk;
        this.processortipe = processortipe;
    }

    public override void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala.");
    }
}

class IdeaPad : Laptop
{
    private string vgatipe;
    private string processormerk;
    private string processortipe;

    public IdeaPad(string merk, string tipe, string vgatipe, string processormerk, string processortipe) : base(merk, tipe)
    {
        this.vgatipe = vgatipe;
        this.processormerk = processormerk;
        this.processortipe = processortipe;
    }
    public override void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala.");
    }
}

class Legion : Laptop
{
    private string vgatipe;
    private string processormerk;
    private string processortipe;

    public Legion(string merk, string tipe, string vgatipe, string processormerk, string processortipe) : base(merk, tipe)
    {
        this.vgatipe = vgatipe;
        this.processormerk = processormerk;
        this.processortipe = processortipe;
    }
    public override void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala.");
    }
}

class Predator : Laptop
{
    private string vgatipe;
    private string processormerk;
    private string processortipe;

    public Predator(string merk, string tipe, string vgatipe, string processormerk, string processortipe) : base(merk, tipe)
    {
        this.vgatipe = vgatipe;
        this.processormerk = processormerk;
        this.processortipe = processortipe;
    }
    public override void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala.");
    }
    public override void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game.");
    }
    public void Spesifikasi()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menggunakan vga {vgatipe} dan processor {processormerk} {processortipe}");
    }
}

class Swift : Laptop
{
    private string vgatipe;
    private string processormerk;
    private string processortipe;

    public Swift(string merk, string tipe, string vgatipe, string processormerk, string processortipe) : base(merk, tipe)
    {
        this.vgatipe = vgatipe;
        this.processormerk = processormerk;
        this.processortipe = processortipe;
    }

    public override void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook("Asus", "Vivobook", "Nvidia", "Intel", "Core i5");
        Laptop laptop2 = new IdeaPad("Lenovo", "IdeaPad", "AMD", "AMD", "Ryzen");
        Predator predator = new Predator("Acer", "Predator", "AMD", "Intel", "Core i7");
        Predator acer = new Predator("Acer", "Predator", "AMD", "Intel", "Core i7");

        predator.BermainGame();
        laptop1.Ngoding();
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();
        predator.BermainGame();
        acer.Spesifikasi();
    }
}
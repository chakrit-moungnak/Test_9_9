public class Program {

    public static void Main(string[] args) {
        Inventory inventory = new Inventory(initializeInventory());
        stringedband guitar = new stringedband("000000000", 8254.52, new Spec("Ning", "Stratocaster", "Alder"));
        stringedband searchResultGuitar = inventory.Search(guitar);
        if (searchResultGuitar != null) {
            PrintGuitarInformation(guitar);
        } else {
            Console.WriteLine("Sorry not Found!!!");
        }

        stringedband melo = new stringedband("0000001", 8254.52, new Spec("Ning", "Stratocaster", "Alder"));
        stringedband searchResultmelo = inventory.Search(melo);
        if (searchResultGuitar != null) {
            PrintmelodinInformation(melo);
        } else {
            Console.WriteLine("Sorry not Found!!!");
    }
    }

    private static void PrintGuitarInformation(stringedband guitar) {
        Console.WriteLine("*******************************");
        Console.WriteLine("Guitar serial-number: {0}", guitar.GetSerialNumber());
        Console.WriteLine("Guitar Price: {0}", guitar.GetPrice());
        Console.WriteLine("Guitar Builder: {0}", guitar.getstringedbandspec().GetBuilder());
        Console.WriteLine("Guitar Model: {0}", guitar.getstringedbandspec().GetModel());
        Console.WriteLine("Guitar Wood: {0}", guitar.getstringedbandspec().GetWood());
        Console.WriteLine("*******************************");
    }

    private static void PrintmelodinInformation(stringedband guitar) {
        Console.WriteLine("*******************************");
        Console.WriteLine("Menlodin serial-number: {0}", guitar.GetSerialNumber());
        Console.WriteLine("Menlodin Price: {0}", guitar.GetPrice());
        Console.WriteLine("Menlodin Builder: {0}", guitar.getstringedbandspec().GetBuilder());
        Console.WriteLine("Menlodin Model: {0}", guitar.getstringedbandspec().GetModel());
        Console.WriteLine("Menlodin Wood: {0}", guitar.getstringedbandspec().GetWood());
        Console.WriteLine("*******************************");
    }

    private static stringedband[] initializeInventory() {
        stringedband[] guitars = { new stringedband("000001", 5000.52, new Spec("Nhong", "Stratocaster", "Alder")),
        new stringedband("000002", 7412.52, new Spec("Jame", "Stratocaster", "Alder")),
        new stringedband("000003", 3917.52, new Spec("Jo", "Stratocaster", "Alder")),
        new stringedband("000004", 8254.52, new Spec("Jo", "Stratocaster", "Alder")),
        new stringedband("000005", 1234.52, new Spec("Nut", "Stratocaster", "Alder"))};

        return guitars;
    }
}
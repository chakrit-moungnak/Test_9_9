public class stringedband {
    private string serialNumber;
    private double price;
    private Spec spec;

    public stringedband(string serialNumber,
     double price,
     Spec spec) {
        this.serialNumber = serialNumber;
        this.price = price;
        this.spec = spec;
    }

    public string GetSerialNumber() {
        return this.serialNumber;
    }

    public double GetPrice() {
        return this.price;
    }

    public void SetPrice(double newPrice) {
        this.price = newPrice;
    }

    public Spec getstringedbandspec() {
        return this.spec;
    }

}
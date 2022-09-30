public class Inventory {
    private stringedband[] stringband;
    public Inventory(stringedband[] stringband) {
        this.stringband = stringband;
    }

    public stringedband GetGuitar(string serialNumber) {
        foreach(stringedband sb in stringband) {
            if (sb.GetSerialNumber().Equals(serialNumber)) {
                return sb;
            }
        }
        return null;
    }

     public stringedband GetGuitar(double price) {
        foreach(stringedband sb in stringband) {
            if (sb.GetPrice().Equals(price)) {
                return sb;
            }
        }

        return null;
    } 

    public stringedband Search(stringedband searchGuitar) {
        foreach(stringedband bs in stringband) { 
            string serialNumber = searchGuitar.GetSerialNumber();
            double price = searchGuitar.GetPrice();

            if (bs.GetSerialNumber().Equals(serialNumber) && 
                bs.GetPrice().Equals(price)) {
                    return bs;
            }

        }
        return null;
    }
}
public class Spec {
    private string builder;
    private string model;
    private string wood;

    public Spec(string builder,
     string model,
     string wood) {
        this.builder = builder;
        this.model = model; 
        this.wood = wood;
     }

    public string GetBuilder() {
        return this.builder;
    }

    public string GetModel() {
        return this.model;
    }

    public string GetWood() {
        return this.wood;
    }

}
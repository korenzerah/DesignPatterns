using System;
namespace DesignPatterns {
public class Vehicle {
    private string model;
    public Vehicle(string model) {
        this.model = model;
    }

    public override string ToString() {
        return "Model: " + this.model;
    }
}
}
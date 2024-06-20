// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Define a class using the "class" keyword
public class Rectangle{

    // TODO: The constructor accepts parameters used to create the object
    public Rectangle (int h, int w) {
        height = h;
        width = w;
    }

    // TODO: For convenience, we can have a constructor that takes one value
    // for squares that have the same side size
    public Rectangle (int side) {
        height = width = side;
    }


    // TODO: Classes can define methods that return values
    public int GetArea() {
        return height * width;
    }


    // TODO: member variables hold data
    public int height;
    public int width;
}

using System.Reflection.Metadata.Ecma335;

interface IBuilder
{
    void reset();
    void setSeats(int number);
    void setEngine(string engine);

    void setTripComputer();
    void setGPS();


}


class Director
{
    public void makeSUV(IBuilder builder)
    { }

    public void makeSportsCar(IBuilder builder)
    {
        builder.reset();
        builder.setSeats(2);
        builder.setEngine("Sports Car");
        builder.setTripComputer();
        builder.setGPS();
    }
}

class CarBuilder : IBuilder
{

    private Car? car;

    public void reset()
    {
        this.car = new Car();
    }

    public void setEngine(string engine)
    {
        throw new NotImplementedException();
    }

    public void setGPS()
    {
        throw new NotImplementedException();
    }

    public void setSeats(int number)
    {
        throw new NotImplementedException();
    }

    public void setTripComputer()
    {
        throw new NotImplementedException();
    }

    public Car getResult()
    {
        return this.car;
    }
}


class CarManualBuilder : IBuilder
{

    private Manual manual;

    public void reset()
    {
        this.manual = new Manual();
    }

    public void setEngine(string engine)
    {
        throw new NotImplementedException();
    }

    public void setGPS()
    {
        throw new NotImplementedException();
    }

    public void setSeats(int number)
    {
        throw new NotImplementedException();
    }

    public void setTripComputer()
    {
        throw new NotImplementedException();
    }

    public Manual getResult()
    {
        return this.manual;
    }
}




class Car:CarBuilder
{

}


class Manual : CarManualBuilder
{

}


class Client
{
    public void Main()
    {
        Director director = new Director();
        CarBuilder builder = new CarBuilder(); 
        director.makeSportsCar(builder);
        Car car = builder.getResult();
    }
}
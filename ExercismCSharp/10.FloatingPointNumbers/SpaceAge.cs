namespace ExercismCSharp;

public class SpaceAge
{
    private readonly double _spaceAge;
    private readonly double _earthYearInSeconds = 31557600;
    private readonly Dictionary<string, double> _orbitalPeriods = new()
    {
        {"Mercury", 0.2408467},
        {"Venus", 0.61519726},
        {"Earth", 1.0},
        {"Mars", 1.8808158},
        {"Jupiter", 11.862615},
        {"Saturn", 29.447498},
        {"Uranus", 84.016846},
        {"Neptune", 164.79132}
    }; 

    public SpaceAge(int seconds)
    {
        _spaceAge = seconds;
    }

    public double CalculateAgeOnPlanet(string planet)
    {
        if (_orbitalPeriods.ContainsKey(planet))
        {
            return _spaceAge / (_earthYearInSeconds * _orbitalPeriods[planet]);
        }
        else
        {
            throw new ArgumentException("Invalid planet name");
        }
    }
    
    public double OnEarth() => CalculateAgeOnPlanet("Earth");
    public double OnMercury() => CalculateAgeOnPlanet("Mercury");
    public double OnVenus() => CalculateAgeOnPlanet("Venus");
    public double OnMars() => CalculateAgeOnPlanet("Mars");
    public double OnJupiter() => CalculateAgeOnPlanet("Jupiter");
    public double OnSaturn() => CalculateAgeOnPlanet("Saturn");
    public double OnUranus() => CalculateAgeOnPlanet("Uranus");
    public double OnNeptune() => CalculateAgeOnPlanet("Neptune");
}
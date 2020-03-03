# Orbital Plane Change Δv Calculator
Calculate orbital plane change with Δv cost

# Features
* Calculate periapsis and apoapsis velcocity
* Calculate the Δv cost needed to align the plane at periapsis and apoapsis
* Select all 8 solar system planets and the Moon as a reference body
* Dark / High contrast theme
* Save the results to a text file
* The "always on top" feature let's you keep the calculator always on top of other windows
* Enable up to 11 decimal places for precise calculations

## Keybindings
* <b>Save results to file:</b> <kbd>Ctrl+S</kbd>
* <b>Switch display mode:</b> <kbd>Ctrl+D</kbd>
* <b>Show accurate results panel:</b> <kbd>Ctrl+R</kbd>
* <b>Exit application:</b> <kbd>Ctrl+Q</kbd>

## Getting Started
These instruction will help you get the calculator up and running on your Windows machine. 

### Prerequisites

```
.NET Framework 4.7.2
```
You can download it here: https://dotnet.microsoft.com/download/dotnet-framework/net472

### Run the program
The software doesn't need installation. You can download an executable file in the [latest releases section](https://github.com/marcom42/Orbital-Plane-Change-DV-Calculator/releases/tag/1.0.0)

### Build
To build the program, open the solution using Visual Studio and build it using .NET Framework 4.7.2

### Coding style
Documentation is added to functions and methods by using Visual Studio default style
```c#
/// <summary>
/// Calculates velocity at periapsis in m/s
/// </summary>
/// <param name="apa">Apoapsis</param>
/// <param name="pea">Periapsis</param>
/// <returns>Velocity</returns>
public double CalcPeAVelocity (double apa, double pea) {
```

## Author

* **Marco Matta** - *Initial work* - [marcom42](https://github.com/marcom42)

## License

This project is licensed under the GNU General Public License v2.0 - see the [LICENSE.txt](LICENSE.txt) file for details

## Acknowledgments

* Special thanks to David Courtney for the inspiration

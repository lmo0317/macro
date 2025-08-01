# SikuliSharp Example

Example of SikuliX based automated UI testing with C#. **SikuliX** is a test automation tool, based on **image recognition**. It can find images, click on them, type text and assert images are found on the screen. It is based on OpenCV and Java Robot framework.

## Dependencies
 - **SikuliSharp.NetCore**: https://github.com/OutSystems/SikuliSharp.NetCore
 - **Java 8** (does not work with newer Java versions, only JRE is enoough): https://java.com/en/download
 - **SikuliX IDE 1.1.3** (running in interactive mode with the Python console, does not support newer versions): https://github.com/nakov/SikuliSharp-Example/tree/main/Sikuli
 - **.NET 5**: https://github.com/dotnet/runtime
 - **Windows OS**: the SikuliX IDE is compiled for Windows only.

## Running the Example
 1. Set `JAVA_HOME` to point your JRE8 installation, e.g. `C:\Program Files\Java\jre1.8.0_291`
 2. Open the project in **Visual Studio** and run the **unit tests**.
 3. Alternatively, run the unit tests from the console, using `dotnet test`

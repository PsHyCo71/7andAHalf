# 7andAHalf v1.1
![.NET](https://img.shields.io/badge/.NET-10.0-blue) ![License](https://img.shields.io/badge/license-GPLv3-blue)

## Description
7andAHalf is a digital card game based on the classic Italian game **“7 e mezzo”**, designed for a human player against a computer.  
The game runs entirely in the console and allows multiple rounds, viewing the rules, and comparing scores to determine the winner.

## Features
- Console-based gameplay
- Human vs Computer
- Multiple rounds
- Score comparison
- Built-in rules viewer

## Requirements
- Windows 10 or later
- .NET SDK 10.0 or later

## How to use
### .NET SDK Installation Guide for Windows
- From the website
    - Open your browser and go to this website ["Download Link"](https://dotnet.microsoft.com/en-us/download/dotnet)
    - Install latest version
    - Execute the downloaded file
    - Check if dotnet is installed by typing this in the Command Prompt or Powershell
    ```ps1
    dotnet --version
    ```
- With packet manager
    - Open the Command Prompt or Powershell as administrator
    
    - Choose one of the following package managers for Windows:
    ```ps1
    winget install Microsoft.DotNet.SDK.10
    ```
    ```ps1
    scoop install dotnet-sdk        (Only on powershell)
    ```
    ```ps1
    choco install dotnet-sdk -y     (Only on powershell)
    ```
    and check:
    ```ps1
    dotnet --version
    ```

## How to play
- Now to play 7andAHalf
    - Clone the repository:
    ```bat
    git clone https://github.com/PsHyCo71/7eMezzo.git
    ```
    - Open a terminal and navigate to the project directory

    - Start the program with:
    ```bat
    dotnet run
    ```
    - Read the rules and play!

    - Or download the latest `.exe` from the [Releases](https://github.com/PsHyCo71/7eMezzo/releases) page

## License
This project is licensed under the [GNU GPL v3.0](https://github.com/PsHyCo71/7andAHalf/blob/main/LICENSE.txt)
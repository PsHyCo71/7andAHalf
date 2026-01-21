# 7andAHalf v2.0
![.NET](https://img.shields.io/badge/.NET-10.0-blue) [![License](https://img.shields.io/badge/license-GPLv3-blue)](https://www.gnu.org/licenses/gpl-3.0.html?utm_source=chatgpt.com)

## Description
7andAHalf is a digital card game based on the classic Italian game **“7 e mezzo”**, designed for a human player against a computer.  
The game runs entirely in the console and allows multiple rounds, viewing the rules, and comparing scores to determine the winner.

## Features
- Console-based gameplay
- Human vs Computer
- Multiple rounds
- Score comparison
- Built-in rules viewer
- Two languages (It, Eng)

## Requirements
- Windows 10 or later
- .NET SDK 10.0 or later (If you just need to run the `.exe` you don't need it)

## How to use
### .NET SDK Installation Guide for Windows
- From the website
    - Open your browser and go to this [page](https://dotnet.microsoft.com/en-us/download/dotnet)
    - Install latest version
    - Execute the downloaded file
    - Check if dotnet is installed by typing this in the Command Prompt or Powershell
    ```powershell
    dotnet --version
    ```
- With packet manager
    - Open the Command Prompt or Powershell as administrator
    
    - Choose one of the following package managers for Windows:
    ```powershell
    winget install Microsoft.DotNet.SDK.10
    ```
    ```powershell
    scoop install dotnet-sdk      #(Only on powershell)
    ```
    ```powershell
    choco install dotnet-sdk -y   #(Only on powershell)
    ```
    - and check:
    ```powershell
    dotnet --version
    ```

## How to play
- Now to play 7andAHalf
    - Download the latest `.exe` from the [Releases](https://github.com/PsHyCo71/7eMezzo/releases) page

    - Or clone the repository:
    ```bat
    git clone https://github.com/PsHyCo71/7eMezzo.git
    ```
    - Open a terminal and navigate to the project directory

    - Start the program with:
    ```bat
    dotnet run
    ```
    - Read the rules and play!
    
## License
This project is licensed under the [GNU GPL v3.0](https://www.gnu.org/licenses/gpl-3.0.html)
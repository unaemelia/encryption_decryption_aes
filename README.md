# Encryption and Decryption using AES in C#

This project demonstrates a simple implementation of encryption and decryption using the Advanced Encryption Standard (AES) in C#. It includes two main components: the `Program.cs` file, which handles user interaction, and the `AesOperation.cs` file, which contains the encryption and decryption logic.

## Table of Contents

- [Overview](#overview)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Project Structure](#project-structure)

## Overview

The project encrypts and decrypts a given string using AES, a symmetric encryption algorithm. The program asks the user to input a string, then encrypts it using a predefined key. It then decrypts the string and displays the original text.

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/encryption_decryption_aes.git
    ```
2. Navigate to the project directory:
    ```bash
    cd encryption_decryption_aes
    ```
3. Build the project:
    ```bash
    dotnet build
    ```

## Usage

1. Run the application:
    ```bash
    dotnet run
    ```
2. Enter a string when prompted. The program will display the encrypted version of the string.
3. The program will then decrypt the string and display the original text.

### Example Output
  ```markdown
  Enter a string for encryption
  Hello, World!

  Encrypted string: 3pG9UQ/mScbLW2Bif9C8Tg== Decrypted string: Hello, World!
  ```

## Project Structure

- **Program.cs**: The main entry point of the application. It prompts the user for input, then uses the `AesOperation` class to encrypt and decrypt the string.

- **AesOperation.cs**: Contains the methods `EnryptionString` and `DecryptString` that perform AES encryption and decryption, respectively.

### Code Explanation

- **Encryption**: 
    - The `EnryptionString` method takes a key and plaintext as input and returns the encrypted text.
    - It uses a 16-byte initialization vector (IV) and a key, both of which are passed to the AES algorithm to create an encryptor.
    - The plaintext is then encrypted using the `CryptoStream` and `MemoryStream` classes.

- **Decryption**:
    - The `DecryptString` method takes a key and the encrypted text as input and returns the decrypted plaintext.
    - It uses the same IV and key to create a decryptor, which is then used to read and decrypt the data.


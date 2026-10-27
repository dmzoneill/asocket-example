# ActiveSocket Example

<p align="center">
  <img src=".github/logo.png" alt="asocket-example logo" width="128" />
</p>

A pair of VB.NET console programs showing how to use the ActiveSocket
COM library (`ASOCKETLib`) for raw TCP messaging.

## What it does

- `Server` listens on a port, waits for a connection and prints each
  message it receives until the client sends `Quit`.
- `Client` connects to a host and port, then sends a message string
  several times, printing the result and error description after each
  call.
- `Shared` holds the ActiveSocket constants and error codes compiled into
  both projects.

## Tech

- Visual Basic .NET console applications
- ActiveSocket COM library (`Interop.ASOCKETLib.dll`)

## Building

Open `Server/Server.sln` and `Client/Client.sln` in Visual Studio and
build them. The ActiveSocket component must be installed and registered
on the Windows machine. Start the server first, then the client.

## License

Licensed under the Apache License 2.0. See [LICENSE](LICENSE).

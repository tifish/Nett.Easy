# Nett.Easy

A wrapper of [Nett](https://github.com/markus-k/Nett) (.NET library for TOML) for easy reading/writing.

## Installation

```bash
dotnet add package Nett.Easy
```

## Usage

```c#
var c = Toml.ReadFile("config.toml");
var user = config.GetTable("user"); // Get or create a table
var age = user.Get("age", 0); // Get with default value
user.Set("age", age + 1); // Update or create a value
Toml.WriteFile(config, "config.toml");
```

## License

[MIT](LICENSE)

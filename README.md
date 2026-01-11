# Nett.Easy

A wrapper of [Nett](https://github.com/markus-k/Nett) (.NET library for TOML) for easy reading/writing.

## Why Nett?

Nett is no longer maintained, but it still has some advantages that libraries such as Tomlyn, Tomlet, Tommy, and CsToml cannot all satisfy:

- Serialize/deserialize objects
- Direct read/write (DOM tree)
- Preserve comments
- Format output while maintaining original order

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
var changed = user.TrySet("age", 20); // Update or create a value, return false if the value is the same
Toml.WriteFile(config, "config.toml");
```

## License

[MIT](LICENSE)

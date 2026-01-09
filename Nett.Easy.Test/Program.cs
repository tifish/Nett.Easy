// See https://aka.ms/new-console-template for more information
using Nett;

var config = Toml.ReadString(
    """
[user]
name = "John Doe"
age = 30
"""
);

var user = config.GetTable("user");
Console.WriteLine(user.Get("name", ""));
Console.WriteLine(user.Get("name1", ""));

var age = user.Get("age", 0);
user.Set("age", age + 1);
Console.WriteLine(Toml.WriteString(config));

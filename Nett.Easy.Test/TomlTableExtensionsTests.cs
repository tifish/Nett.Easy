using Xunit;

namespace Nett.Easy.Test;

public class TomlTableExtensionsTests
{
    const string ConfigString = """
        [user]
        name = "John Doe"
        age = 30
        birth_date = 1990-01-01
        friends = ["Alice", "Bob", "Charlie"]
        """;

    [Fact]
    public void Get()
    {
        var config = Toml.ReadString(ConfigString);

        var user = config.GetTable("user");
        Assert.NotNull(user);

        var weight = user.Get("weight", 50);
        Assert.Equal(50, weight);

        var user_not_exists = config.GetTable("user_not_exists");
        Assert.NotNull(user_not_exists);

        var weight_not_exists = user_not_exists.Get("weight", 50);
        Assert.Equal(50, weight_not_exists);
    }

    [Fact]
    public void Set()
    {
        var config = Toml.ReadString(ConfigString);

        var user = config.GetTable("user");
        Assert.NotNull(user);

        user.Set("age", 40);
        Assert.Equal(40, user.Get<int>("age"));

        var user_not_exists = config.GetTable("user_not_exists");
        Assert.NotNull(user_not_exists);

        user_not_exists.Set("weight", 50);
        Assert.Equal(50, user_not_exists.Get<int>("weight"));
    }

    [Fact]
    public void TrySet()
    {
        var config = Toml.ReadString(ConfigString);

        var user = config.GetTable("user");
        Assert.NotNull(user);

        var result = user.TrySet("age", 30);
        Assert.False(result);
        Assert.Equal(30, user.Get<int>("age"));

        result = user.TrySet("age", 40);
        Assert.True(result);
        Assert.Equal(40, user.Get<int>("age"));

        var user_not_exists = config.GetTable("user_not_exists");
        Assert.NotNull(user_not_exists);

        var result_not_exists = user_not_exists.TrySet("weight", 50);
        Assert.True(result_not_exists);
        Assert.Equal(50, user_not_exists.Get<int>("weight"));
    }

    [Fact]
    public void GetDateTime()
    {
        var config = Toml.ReadString(ConfigString);

        var user = config.GetTable("user");
        Assert.NotNull(user);

        var birth_date = user.Get("birth_date", DateTime.MinValue);
        Assert.Equal(new DateTime(1990, 1, 1), birth_date);

        var birth_date_not_exists = user.Get("birth_date_not_exists", new DateTime(1991, 1, 1));
        Assert.Equal(new DateTime(1991, 1, 1), birth_date_not_exists);
    }

    [Fact]
    public void SetDateTime()
    {
        var config = Toml.ReadString(ConfigString);
        var user = config.GetTable("user");
        Assert.NotNull(user);

        user.Set("birth_date", new DateTime(1991, 1, 1));
        Assert.Equal(new DateTime(1991, 1, 1), user.Get<DateTimeOffset>("birth_date"));

        user.Set("birth_date_not_exists", new DateTime(1992, 1, 1));
        Assert.Equal(new DateTime(1992, 1, 1), user.Get<DateTimeOffset>("birth_date_not_exists"));
    }

    [Fact]
    public void GetArray()
    {
        var config = Toml.ReadString(ConfigString);

        var user = config.GetTable("user");
        Assert.NotNull(user);

        var friends = user.Get("friends", Array.Empty<string>());
        Assert.Equal(["Alice", "Bob", "Charlie"], friends);

        var friends_not_exists = user.Get("friends_not_exists", Array.Empty<string>());
        Assert.Equal(Array.Empty<string>(), friends_not_exists);
    }

    [Fact]
    public void SetArray()
    {
        var config = Toml.ReadString(ConfigString);

        var user = config.GetTable("user");
        Assert.NotNull(user);

        user.Set("friends", ["Alice", "Bob", "Charlie", "David"]);
        Assert.Equal(["Alice", "Bob", "Charlie", "David"], user.Get<string[]>("friends"));
    }

    [Fact]
    public void TrySetArray()
    {
        var config = Toml.ReadString(ConfigString);

        var user = config.GetTable("user");
        Assert.NotNull(user);

        var result = user.TrySet("friends", ["Alice", "Bob", "Charlie"]);
        Assert.False(result);
        Assert.Equal(["Alice", "Bob", "Charlie"], user.Get<string[]>("friends"));

        result = user.TrySet("friends", ["Alice", "Bob", "Charlie", "David"]);
        Assert.True(result);
        Assert.Equal(["Alice", "Bob", "Charlie", "David"], user.Get<string[]>("friends"));
    }
}

namespace Nett;

public static class TomlTableExtensions
{
    public static T Get<T>(this TomlTable table, string key, T defaultValue)
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<T>();
    }

    public static bool Get(this TomlTable table, string key, bool defaultValue)
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<bool>();
    }

    public static string? Get(this TomlTable table, string key, string? defaultValue)
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<string>();
    }

    public static long Get(this TomlTable table, string key, long defaultValue)
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<long>();
    }

    public static int Get(this TomlTable table, string key, int defaultValue)
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<int>();
    }

    public static double Get(this TomlTable table, string key, double defaultValue)
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<double>();
    }

    public static float Get(this TomlTable table, string key, float defaultValue)
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<float>();
    }

    public static DateTimeOffset Get(this TomlTable table, string key, DateTimeOffset defaultValue)
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<DateTimeOffset>();
    }

    public static DateTime Get(this TomlTable table, string key, DateTime defaultValue)
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<DateTime>();
    }

    public static TimeSpan Get(this TomlTable table, string key, TimeSpan defaultValue)
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<TimeSpan>();
    }

    // Arrays
    public static IEnumerable<bool>? Get(
        this TomlTable table,
        string key,
        IEnumerable<bool>? defaultValue
    )
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<IEnumerable<bool>>();
    }

    public static IEnumerable<string>? Get(
        this TomlTable table,
        string key,
        IEnumerable<string>? defaultValue
    )
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<IEnumerable<string>>();
    }

    public static IEnumerable<long>? Get(
        this TomlTable table,
        string key,
        IEnumerable<long>? defaultValue
    )
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<IEnumerable<long>>();
    }

    public static IEnumerable<int>? Get(
        this TomlTable table,
        string key,
        IEnumerable<int>? defaultValue
    )
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<IEnumerable<int>>();
    }

    public static IEnumerable<double>? Get(
        this TomlTable table,
        string key,
        IEnumerable<double>? defaultValue
    )
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<IEnumerable<double>>();
    }

    public static IEnumerable<float>? Get(
        this TomlTable table,
        string key,
        IEnumerable<float>? defaultValue
    )
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<IEnumerable<float>>();
    }

    public static IEnumerable<DateTimeOffset>? Get(
        this TomlTable table,
        string key,
        IEnumerable<DateTimeOffset>? defaultValue
    )
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<IEnumerable<DateTimeOffset>>();
    }

    public static IEnumerable<DateTime>? Get(
        this TomlTable table,
        string key,
        IEnumerable<DateTime>? defaultValue
    )
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<IEnumerable<DateTime>>();
    }

    public static IEnumerable<TimeSpan>? Get(
        this TomlTable table,
        string key,
        IEnumerable<TimeSpan>? defaultValue
    )
    {
        if (!table.TryGetValue(key, out var value))
            return defaultValue;
        return value.Get<IEnumerable<TimeSpan>>();
    }

    public static TomlTable GetTable(this TomlTable table, string key)
    {
        if (!table.TryGetValue(key, out var value))
        {
            return TomlObjectFactory.Add(table, key, Toml.Create()).Added;
        }

        if (value.TomlType == TomlObjectType.Table)
        {
            return value.Get<TomlTable>();
        }
        else
        {
            return TomlObjectFactory.Update(table, key, Toml.Create()).Added;
        }
    }

    public static void Set(this TomlTable table, string key, bool value)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, value);
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
        }
    }

    public static void Set(this TomlTable table, string key, string value)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, value);
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
        }
    }

    public static void Set(this TomlTable table, string key, long value)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, value);
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
        }
    }

    public static void Set(this TomlTable table, string key, double value)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, value);
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
        }
    }

    public static void Set(this TomlTable table, string key, DateTimeOffset value)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, value);
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
        }
    }

    public static void Set(this TomlTable table, string key, TimeSpan value)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, value);
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
        }
    }

    // Table
    public static void Set<T>(
        this TomlTable table,
        string key,
        IDictionary<string, T> tableData,
        TomlTable.TableTypes type = TomlTable.TableTypes.Default
    )
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, tableData, type);
        }
        else
        {
            TomlObjectFactory.Add(table, key, tableData, type);
        }
    }

    public static void Set(
        this TomlTable table,
        string key,
        object obj,
        TomlTable.TableTypes type = TomlTable.TableTypes.Default
    )
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, obj, type);
        }
        else
        {
            TomlObjectFactory.Add(table, key, obj, type);
        }
    }

    // Table Array
    public static void Set<T>(
        this TomlTable table,
        string key,
        IEnumerable<T> items,
        TomlTable.TableTypes type = TomlTable.TableTypes.Default
    )
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, items, type);
        }
        else
        {
            TomlObjectFactory.Add(table, key, items, type);
        }
    }

    // Arrays
    public static void Set(this TomlTable table, string key, IEnumerable<bool> array)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, array);
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
        }
    }

    public static void Set(this TomlTable table, string key, IEnumerable<string> array)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, array);
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
        }
    }

    public static void Set(this TomlTable table, string key, IEnumerable<long> array)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, array);
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
        }
    }

    public static void Set(this TomlTable table, string key, IEnumerable<int> array)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, array);
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
        }
    }

    public static void Set(this TomlTable table, string key, IEnumerable<double> array)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, array);
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
        }
    }

    public static void Set(this TomlTable table, string key, IEnumerable<float> array)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, array);
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
        }
    }

    public static void Set(this TomlTable table, string key, IEnumerable<DateTimeOffset> array)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, array);
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
        }
    }

    public static void Set(this TomlTable table, string key, IEnumerable<DateTime> array)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, array);
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
        }
    }

    public static void Set(this TomlTable table, string key, IEnumerable<TimeSpan> array)
    {
        if (table.TryGetValue(key, out _))
        {
            TomlObjectFactory.Update(table, key, array);
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
        }
    }
}

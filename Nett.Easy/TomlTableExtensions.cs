using System.Collections.Generic;
using System.Linq;

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

    public static bool TrySet(this TomlTable table, string key, bool value)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Bool && oldValue.Get<bool>() == value)
            {
                return false;
            }
            else
            {
                TomlObjectFactory.Update(table, key, value);
                return true;
            }
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, string value)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.String && oldValue.Get<string>() == value)
            {
                return false;
            }
            else
            {
                TomlObjectFactory.Update(table, key, value);
                return true;
            }
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, long value)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Int && oldValue.Get<long>() == value)
            {
                return false;
            }
            else
            {
                TomlObjectFactory.Update(table, key, value);
                return true;
            }
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, int value)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Int && oldValue.Get<int>() == value)
            {
                return false;
            }
            else
            {
                TomlObjectFactory.Update(table, key, value);
                return true;
            }
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, double value)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Float && oldValue.Get<double>() == value)
            {
                return false;
            }
            else
            {
                TomlObjectFactory.Update(table, key, value);
                return true;
            }
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, float value)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Float && oldValue.Get<float>() == value)
            {
                return false;
            }
            else
            {
                TomlObjectFactory.Update(table, key, value);
                return true;
            }
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, DateTimeOffset value)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            try
            {
                if (oldValue.Get<DateTimeOffset>() == value)
                {
                    return false;
                }
            }
            catch
            {
                // Type mismatch, need to update
            }
            TomlObjectFactory.Update(table, key, value);
            return true;
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, DateTime value)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            try
            {
                if (oldValue.Get<DateTime>() == value)
                {
                    return false;
                }
            }
            catch
            {
                // Type mismatch, need to update
            }
            TomlObjectFactory.Update(table, key, value);
            return true;
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, TimeSpan value)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.LocalTime && oldValue.Get<TimeSpan>() == value)
            {
                return false;
            }
            else
            {
                TomlObjectFactory.Update(table, key, value);
                return true;
            }
        }
        else
        {
            TomlObjectFactory.Add(table, key, value);
            return true;
        }
    }

    // Arrays
    public static bool TrySet(this TomlTable table, string key, IEnumerable<bool> array)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Array)
            {
                try
                {
                    var oldArray = oldValue.Get<bool[]>();
                    if (oldArray != null && array != null && oldArray.SequenceEqual(array))
                    {
                        return false;
                    }
                }
                catch
                {
                    // Type mismatch, need to update
                }
            }
            TomlObjectFactory.Update(table, key, array);
            return true;
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, IEnumerable<string> array)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Array)
            {
                try
                {
                    var oldArray = oldValue.Get<string[]>();
                    if (oldArray != null && array != null && oldArray.SequenceEqual(array))
                    {
                        return false;
                    }
                }
                catch
                {
                    // Type mismatch, need to update
                }
            }
            TomlObjectFactory.Update(table, key, array);
            return true;
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, IEnumerable<long> array)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Array)
            {
                try
                {
                    var oldArray = oldValue.Get<long[]>();
                    if (oldArray != null && array != null && oldArray.SequenceEqual(array))
                    {
                        return false;
                    }
                }
                catch
                {
                    // Type mismatch, need to update
                }
            }
            TomlObjectFactory.Update(table, key, array);
            return true;
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, IEnumerable<int> array)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Array)
            {
                try
                {
                    var oldArray = oldValue.Get<int[]>();
                    if (oldArray != null && array != null && oldArray.SequenceEqual(array))
                    {
                        return false;
                    }
                }
                catch
                {
                    // Type mismatch, need to update
                }
            }
            TomlObjectFactory.Update(table, key, array);
            return true;
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, IEnumerable<double> array)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Array)
            {
                try
                {
                    var oldArray = oldValue.Get<double[]>();
                    if (oldArray != null && array != null && oldArray.SequenceEqual(array))
                    {
                        return false;
                    }
                }
                catch
                {
                    // Type mismatch, need to update
                }
            }
            TomlObjectFactory.Update(table, key, array);
            return true;
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, IEnumerable<float> array)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Array)
            {
                try
                {
                    var oldArray = oldValue.Get<float[]>();
                    if (oldArray != null && array != null && oldArray.SequenceEqual(array))
                    {
                        return false;
                    }
                }
                catch
                {
                    // Type mismatch, need to update
                }
            }
            TomlObjectFactory.Update(table, key, array);
            return true;
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, IEnumerable<DateTimeOffset> array)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Array)
            {
                try
                {
                    var oldArray = oldValue.Get<DateTimeOffset[]>();
                    if (oldArray != null && array != null && oldArray.SequenceEqual(array))
                    {
                        return false;
                    }
                }
                catch
                {
                    // Type mismatch, need to update
                }
            }
            TomlObjectFactory.Update(table, key, array);
            return true;
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, IEnumerable<DateTime> array)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Array)
            {
                try
                {
                    var oldArray = oldValue.Get<DateTime[]>();
                    if (oldArray != null && array != null && oldArray.SequenceEqual(array))
                    {
                        return false;
                    }
                }
                catch
                {
                    // Type mismatch, need to update
                }
            }
            TomlObjectFactory.Update(table, key, array);
            return true;
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
            return true;
        }
    }

    public static bool TrySet(this TomlTable table, string key, IEnumerable<TimeSpan> array)
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Array)
            {
                try
                {
                    var oldArray = oldValue.Get<TimeSpan[]>();
                    if (oldArray != null && array != null && oldArray.SequenceEqual(array))
                    {
                        return false;
                    }
                }
                catch
                {
                    // Type mismatch, need to update
                }
            }
            TomlObjectFactory.Update(table, key, array);
            return true;
        }
        else
        {
            TomlObjectFactory.Add(table, key, array);
            return true;
        }
    }

    // Table
    public static bool TrySet<T>(
        this TomlTable table,
        string key,
        IDictionary<string, T> tableData,
        TomlTable.TableTypes type = TomlTable.TableTypes.Default
    )
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Table)
            {
                // For tables, we consider them equal if they have the same structure
                // This is a simplified check - you might want more sophisticated comparison
                try
                {
                    var oldTable = oldValue.Get<TomlTable>();
                    if (oldTable != null && tableData != null)
                    {
                        // Compare keys and values
                        var oldKeys = oldTable.Keys.ToHashSet();
                        var newKeys = tableData.Keys.ToHashSet();
                        if (oldKeys.SetEquals(newKeys))
                        {
                            bool allEqual = true;
                            foreach (var kvp in tableData)
                            {
                                if (!oldTable.TryGetValue(kvp.Key, out var oldVal))
                                {
                                    allEqual = false;
                                    break;
                                }
                                try
                                {
                                    var oldT = oldVal.Get<T>();
                                    if (!EqualityComparer<T>.Default.Equals(oldT, kvp.Value))
                                    {
                                        allEqual = false;
                                        break;
                                    }
                                }
                                catch
                                {
                                    allEqual = false;
                                    break;
                                }
                            }
                            if (allEqual)
                            {
                                return false;
                            }
                        }
                    }
                }
                catch
                {
                    // Type mismatch or conversion error, need to update
                }
            }
            TomlObjectFactory.Update(table, key, tableData, type);
            return true;
        }
        else
        {
            TomlObjectFactory.Add(table, key, tableData, type);
            return true;
        }
    }

    public static bool TrySet(
        this TomlTable table,
        string key,
        object obj,
        TomlTable.TableTypes type = TomlTable.TableTypes.Default
    )
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.Table)
            {
                // For object comparison, we'll always update since object equality is complex
                // This could be enhanced with more sophisticated comparison logic
            }
            TomlObjectFactory.Update(table, key, obj, type);
            return true;
        }
        else
        {
            TomlObjectFactory.Add(table, key, obj, type);
            return true;
        }
    }

    // Table Array
    public static bool TrySet<T>(
        this TomlTable table,
        string key,
        IEnumerable<T> items,
        TomlTable.TableTypes type = TomlTable.TableTypes.Default
    )
    {
        if (table.TryGetValue(key, out var oldValue))
        {
            if (oldValue.TomlType == TomlObjectType.ArrayOfTables)
            {
                try
                {
                    var oldArray = oldValue.Get<IEnumerable<TomlTable>>();
                    if (oldArray != null && items != null)
                    {
                        var oldList = oldArray.ToList();
                        var newList = items.ToList();
                        if (oldList.Count == newList.Count)
                        {
                            // For table arrays, we'll do a simple count comparison
                            // More sophisticated comparison could be added if needed
                            bool allEqual = true;
                            for (int i = 0; i < oldList.Count; i++)
                            {
                                // Simplified comparison - could be enhanced
                                if (!EqualityComparer<T>.Default.Equals(newList[i], default(T)))
                                {
                                    allEqual = false;
                                    break;
                                }
                            }
                            if (allEqual && oldList.Count == 0)
                            {
                                return false;
                            }
                        }
                    }
                }
                catch
                {
                    // Type mismatch, need to update
                }
            }
            TomlObjectFactory.Update(table, key, items, type);
            return true;
        }
        else
        {
            TomlObjectFactory.Add(table, key, items, type);
            return true;
        }
    }
}

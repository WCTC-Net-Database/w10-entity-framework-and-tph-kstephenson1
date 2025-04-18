﻿namespace w10_assignment_ksteph.FileIO.Json;

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using w10_assignment_ksteph.DataTypes;
using w10_assignment_ksteph.FileIO.Json.Converters;
using w10_assignment_ksteph.Models.Interfaces.FileIO;

[Obsolete]
public class JsonFileHandler<T> : ICharacterIO, IItemIO
{
    // JsonFileHandler is used to convert bewtween units and json format.  Just like the CsvFileHandler, this class was refactored
    // to implement generic types.

    [Obsolete]
    private const string JSON_EXT = ".json";
    [Obsolete]
    private readonly JsonSerializerOptions _options = new();

    [Obsolete]
    public JsonFileHandler()
    {
        _options.Converters.Add(new JsonInventoryConverter());      // Using a custom converter to convert json string -> Inventory
        _options.Converters.Add(new JsonUnitConverter());      // Using a custom converter to convert json string -> Inventory

        _options.Converters.Add(new JsonNumberEnumConverter<WeaponType>());       // Using a custom converter to convert json string -> Position
        _options.Converters.Add(new JsonStringEnumConverter());       // Using a custom converter to convert json string -> Position
        _options.WriteIndented = true;                              // Writes the json file in indented format.
        //_options.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    }

    [Obsolete]
    public List<T> Read<T>(string dir)
    {

        using StreamReader reader = new(dir + JSON_EXT);            // reads from the json file and returns a list of characters.
        string json = reader.ReadToEnd();

        return JsonSerializer.Deserialize<List<T>>(json, _options)!;
    }

    [Obsolete]
    public void Write<T>(List<T> units, string dir)
    {
        using StreamWriter writer = new(dir + JSON_EXT);            // Takes a list of characters and writes to the json file
        writer.WriteLine(JsonSerializer.Serialize<List<T>>(units, _options));
    }
}

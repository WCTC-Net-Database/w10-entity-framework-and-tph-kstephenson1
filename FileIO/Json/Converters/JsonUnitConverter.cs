﻿using System.Text.Json;
using System.Text.Json.Serialization;
using w10_assignment_ksteph.Models.Units.Abstracts;
using w10_assignment_ksteph.Services.DataHelpers;

namespace w10_assignment_ksteph.FileIO.Json.Converters;

// The JsonInventoryConverter is used to turn json format into an Inventories Object automatically.
[Obsolete]
public class JsonUnitConverter : JsonConverter<Unit>
{
    [Obsolete]
    public override Unit? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument jsonDocument = JsonDocument.ParseValue(ref reader))
        {
            var rootElement = jsonDocument.RootElement;
            var typeProperty = rootElement.GetProperty("$type").GetString();

            //typeProperty = "w6_assignment_ksteph.Entities." + typeProperty;

            Type unitType = UnitClassSerializer.Deserialize(typeProperty);
            

            return (Unit)JsonSerializer.Deserialize(rootElement.GetRawText(), unitType, options);
        }
    }

    [Obsolete]
    public override void Write(Utf8JsonWriter writer, Unit unit, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, (object)unit, options);
    }
}

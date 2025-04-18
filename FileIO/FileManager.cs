﻿namespace w10_assignment_ksteph.FileIO;

using w10_assignment_ksteph.Configuration;
using w10_assignment_ksteph.DataTypes;
using w10_assignment_ksteph.FileIO.Csv;
using w10_assignment_ksteph.FileIO.Json;
using w10_assignment_ksteph.Models.Interfaces.FileIO;
using w10_assignment_ksteph.Models.Items.WeaponItems;
using w10_assignment_ksteph.Models.Units.Abstracts;

[Obsolete]
public class FileManager<T>
{
    // FileManager contains redirects to functions that assist with file IO functions.  This class allows the import and export of a generic
    // unit type.

    [Obsolete]
    private FileType _fileType = Config.DEFAULT_FILE_TYPE;

    [Obsolete]
    private Type _type = typeof(T);
    [Obsolete]
    private Dictionary<Type, int> _typeDict = new()
    {
            {typeof(Unit),0},
            {typeof(Character),1},
            {typeof(Monster),2},
            {typeof(WeaponItem),3},
        };

    [Obsolete]
    private string GetFilePath()
    {
        return _typeDict[_type] switch
        {
            0 => "Data/Files/units",
            //1 => "Files/characters",
            //2 => "Files/monsters",
            3 => "Data/Files/weapons",
            _ => throw new ArgumentOutOfRangeException($"GetFilePath() has invalid type ({_typeDict})")
        };

    }

    [Obsolete]
    private IFileIO GetFileType<T>() // Checks to see what the current file type is set to and execute the proper file system.
    {
        return _fileType switch
        {
            FileType.Csv => new CsvFileHandler<T>(),
            FileType.Json => new JsonFileHandler<T>(),
            _ => throw new NullReferenceException("Error: File type not found in FileManager.GetFileType()"),
        };
    }

    [Obsolete]
    public void SwitchFileType()
    {
        Console.Clear();
        if (_fileType == FileType.Csv)
        {
            Console.WriteLine("File format set to Json.");
            _fileType = FileType.Json;
        } else
        {
            Console.WriteLine("File format set to Csv.");
            _fileType = FileType.Csv;
        }
    }

    [Obsolete]
    public List<T> Import<T>() => GetFileType<T>().Read<T>(GetFilePath());
    [Obsolete]
    public void Export<T>(List<T> tList) => GetFileType<T>().Write<T>(tList, GetFilePath());
}

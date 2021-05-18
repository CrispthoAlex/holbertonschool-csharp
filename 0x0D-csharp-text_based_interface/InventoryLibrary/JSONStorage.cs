using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Collection.Generic;
using System.Text.Json.Serialization;
//using System.Reflection;


/// <sumary>JSONStorage class</sumary>
class JSONStorage
{
    // Storage path
    // * Filename
    private string FILENAME = @"inventory_manager.json"
    // * Directory
    private string DIRECTORY = @"storage/";
    // Storage Path
    private string _PATH = $"{DIRECTORY}{FILENAME}";
    /// <sumary> objects property </sumary>
    public Dictionary<string, T> objects {get; set;} = new Dictionary<string, T>() ;

    // Constructor
    public JSONStorage()
    {
        // Save current path
        // [directory/folder]
        string[] currentPath = Directory.GetCurrentDirectory().Split('/');
        string currentFolder = currentPath[currentPath.Length - 1] ;

        // Create Directory
        if (currentFolder == "InventoryManager")
        {
            _PATH = $"../{_PATH}" ;
            !Directory.Exists($"../{DIRECTORY}") ? Directory.CreateDirectory($"../{DIRECTORY}") ;
        }
        else
        {
            !Directory.Exists(DIRECTORY) ? Directory.CreateDirectory(DIRECTORY) ;
        }
    }

    /// <sumary> objects dictionary method </sumary>
    /// <return> return objects </return>
    public Dictionary<string, T> All() => objects ;

    /// <sumary> Method to add a new key-value pair to objects </sumary>
    public void New(T obj)
    {
        // Key: <obj ClassName>.<obj id>
        objects.Add($"{obj.GetType().Name}.{obj.id}", obj) ;
    }

    /// <sumary> Serializes objects to JSON and saves to the JSON file </sumary>
    public void save()
    {
        try
        {
            using (StreamWriter sw = File.CreateText(_PATH))
            {
                string jsonString = "{" ;
                foreach (var obj in objects)
                {
                    jsonString += $"{JsonSerializer.Serialize<string>(obj.Key)}:" ;
                    jsonString += $"{JsonSerializer.Serialize<string>(obj.Value)}:" ;
                }
                if (jsonString.EndsWith(","))
                    jsonString = jsonString.TrimEnd(',') ;
                jsonString += "}" ;
                sw.WriteLine(jsonString) ;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("It's not possible to create the file") ;
        }
    }

    /// <sumary>deserializes JSON file to objects
    public void Load()
    {
        if (File.Exist(_PATH))
        {
            using (StreamReader sr = File.OpenText(_PATH))
            {
                string jsonString = sr.ReadLine();
                Dictionary<string, Object> objDict = new Dictionary<string, object>() ;
                objDict = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString)  ;

                foreach (var obj in objDict)
                {
                    string objType = obj.key.Split('.')[0] ;
                    Type type = Type.GetType($"{objType}") ;
                    if (type == null)
                        continue;
                    MethodInfo deserializeMethod = this.GetType().GetMethod("DynamicDeserialize").MakeGenericMethod(type) ;
                    
                    // Create new objects from file
                    Object newObj = deserailizeMethod.Invoke(null, new object[] { obj.Value });
                    New((T)new_obj);
                }
            }
        }
    }

    /// <sumary>deserializes a object
    public static TClass DynamicDeserialize<TClass>(Object o) => (TClass)JsonSerializer.Deserialize<TClass>(o.ToString()) ;

}


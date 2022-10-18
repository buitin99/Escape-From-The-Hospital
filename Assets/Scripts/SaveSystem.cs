using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem<T> where T : class, new()
{
    public static void Save(T data)
    {
        BinaryFormatter bf = new BinaryFormatter();
        string path = Application.persistentDataPath + $"/{typeof(T).Name}.sav";
        FileStream stream = new FileStream(path, FileMode.Create);

        bf.Serialize(stream, data);
        stream.Close();
    }

    public static T LoadData()
    {
        string path = Application.persistentDataPath + $"/{typeof(T).Name}.sav";
        if(File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            T data = bf.Deserialize(stream) as T;
            stream.Close();
            return data;
        }
        else
        {
            T newData = new T();
            // Save(newData);
            return newData;
        }  
    }
}

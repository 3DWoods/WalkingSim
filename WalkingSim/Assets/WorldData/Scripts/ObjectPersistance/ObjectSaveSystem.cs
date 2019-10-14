using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class ObjectSaveSystem 
{

    public static void SaveObjectData(ObjectState objectState)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.dataPath + "/object.fnx";
        FileStream stream = new FileStream(path, FileMode.Create);

        ObjectData data = new ObjectData(objectState);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static ObjectData LoadObjectData() {
        string path = Application.dataPath + "/object.fnx";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ObjectData data = formatter.Deserialize(stream) as ObjectData;

            stream.Close();

            return data;
        }
        else {
            Debug.Log("No data to load for persistant objects.");
            return null;
        }
    }

}

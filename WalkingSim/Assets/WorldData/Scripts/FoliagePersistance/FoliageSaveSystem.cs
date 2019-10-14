using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class FoliageSaveSystem 
{
    public static void SaveFoliageData(FoliageState foliageState) {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.dataPath + "/foliage.fnx";
        FileStream stream = new FileStream(path, FileMode.Create);

        FoliageData data = new FoliageData(foliageState);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    

    public static FoliageData LoadFoliageData() {
        string path = Application.dataPath + "/foliage.fnx";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            FoliageData data = formatter.Deserialize(stream) as FoliageData;

            stream.Close();

            return data;
        }
        else {
            Debug.Log("Foliage save not found in " + path + " creating new foliage data.");
            return null;
        }
    }

}

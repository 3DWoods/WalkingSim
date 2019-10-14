using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectState : MonoBehaviour
{
    //Script to save/load objects from list
    public GameObject[] persistanceObjects;
    //hack
    public LightData[] lightData;
    public GameObject[] lights;


    public WeeklyData weeklyData;


    void Start()
    {
        GetPersistantObjects();
        LoadObject();
        //SaveObject();
    }

    void GetPersistantObjects() {

        persistanceObjects = GameObject.FindGameObjectsWithTag("PersistantObject");
        lights = GameObject.FindGameObjectsWithTag("StaticInteract");
        lightData = new LightData[lights.Length];

        UpdateLightData();

    }

    //I dont really need to update the data in this script until it's called right?
    //Keep this for debugging purposes.
    void UpdateLightData() {
        for (int i = 0; i < lights.Length; i++)
        {
            lightData[i] = lights[i].GetComponent<LightStateData>().lightData;
        }
    }

    public void SaveObject()
    {
        ObjectSaveSystem.SaveObjectData(this);
    }

    public void LoadObject()
    {
        ObjectData objectData = ObjectSaveSystem.LoadObjectData();

        for (int i = 0; i < persistanceObjects.Length; i++) {
            persistanceObjects[i].transform.position = new Vector3(objectData.posx[i], objectData.posy[i], objectData.posz[i]);
            persistanceObjects[i].transform.rotation = Quaternion.Euler(objectData.rotx[i], objectData.roty[i], objectData.rotz[i]);
            //Debug.Log(objectData.rotx[i]);
        }

        //Hmmmmmmm
        UpdateLightData();


        //cache data better
        for (int i = 0; i < lights.Length; i++) {
            lightData[i] = objectData.lightData[i];
            lights[i].GetComponent<LightStateData>().lightData = lightData[i];
        }

        weeklyData.currentDay = objectData.currentDay;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SaveObject();
            Debug.Log("Saved Data");
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            LoadObject();
            Debug.Log("Loaded Data");
        }

        //Debugging purpose
        UpdateLightData();
    }

    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class ObjectData 
{
    //Data to save - Position, rotation, array [x, y, z];
    public float[] posx;
    public float[] posy;
    public float[] posz;

    public float[] rotx;
    public float[] roty;
    public float[] rotz;

    public int currentDay;

    public LightData[] lightData;


    public ObjectData(ObjectState objectState) {
        posx = new float[objectState.persistanceObjects.Length];
        posy = new float[objectState.persistanceObjects.Length];
        posz = new float[objectState.persistanceObjects.Length];
        rotx = new float[objectState.persistanceObjects.Length];
        roty = new float[objectState.persistanceObjects.Length];
        rotz = new float[objectState.persistanceObjects.Length];

        for (int i = 0; i < objectState.persistanceObjects.Length; i++) {
            posx[i] = objectState.persistanceObjects[i].transform.position.x;
            posy[i] = objectState.persistanceObjects[i].transform.position.y;
            posz[i] = objectState.persistanceObjects[i].transform.position.z;

            rotx[i] = objectState.persistanceObjects[i].transform.rotation.eulerAngles.x;
            roty[i] = objectState.persistanceObjects[i].transform.rotation.eulerAngles.y;
            rotz[i] = objectState.persistanceObjects[i].transform.rotation.eulerAngles.z;

        }

        lightData = new LightData[objectState.lights.Length];

        for (int i = 0; i < objectState.lightData.Length; i++) {
            lightData[i] = objectState.lightData[i];
            if (lightData[i].state) {
                Debug.Log("This light was saved in the on state");
            }
        }

        currentDay = objectState.weeklyData.currentDay;

        Debug.Log("This was called at least?");
    }

}

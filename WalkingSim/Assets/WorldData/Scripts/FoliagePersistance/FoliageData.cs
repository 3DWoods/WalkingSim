using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FoliageData
{


    public int worldState;

    public FoliageData(FoliageState foliageState) {
        worldState = foliageState.worldState;
    }


}

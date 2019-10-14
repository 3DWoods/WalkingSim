using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoliageState : MonoBehaviour
{

    public GameObject biomeUpdate;
    public int worldState;

    // Start is called before the first frame update
    void Start()
    {

        LoadFoliage();

        if (worldState == 1)
        {
            biomeUpdate.SetActive(true);
        }
        else {
            biomeUpdate.SetActive(false);
        }
    }

    public void SaveFoliage() {
        FoliageSaveSystem.SaveFoliageData(this);
    }

    public void LoadFoliage() {
        FoliageData foliageData = FoliageSaveSystem.LoadFoliageData();

        worldState = foliageData.worldState;
    }

    private void UpdateFoliageZone() {
        worldState = 1;
        SaveFoliage();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "CapsuleCollider") {
            UpdateFoliageZone();
        }
    }
}

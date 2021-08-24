using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMaterialBehavior : MonoBehaviour
{

    // Start is called before the first frame update
    void Update()
    {
   
        foreach (GameObject mesh in Resources.FindObjectsOfTypeAll(typeof(MeshRenderer)) as GameObject[])
        {
            if(mesh.GetComponent<DistanceDissolveTarget>() == null && mesh.name != "TrackedObject")
            {
                mesh.gameObject.AddComponent<DistanceDissolveTarget>();
                mesh.GetComponent<DistanceDissolveTarget>().enabled = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotatation : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, MasterManager.SpeedManager.Speed * Time.deltaTime);
    }
}

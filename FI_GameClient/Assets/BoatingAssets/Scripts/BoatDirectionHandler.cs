using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatDirectionHandler : MonoBehaviour
{
    public float heading;
    public float speed;
    public float boomAngle;
    public GameObject boomObject;
    WindDirector windSampling;

    public float energyModifier;


    private void Awake()
    {
        heading = transform.rotation.y;
        windSampling = GameObject.FindGameObjectWithTag("WindDirector").GetComponent<WindDirector>();

    }

    private void Update()
    {
        heading = transform.transform.eulerAngles.y;
        boomAngle = boomObject.transform.eulerAngles.y;
        float globalWindAngle = windSampling.angle;

        Debug.Log("Wind is " + globalWindAngle.ToString() + ", Ship is " + boomAngle.ToString());
        float windAlignment = 
        Debug.Log("Alignment is " +);
    }
}

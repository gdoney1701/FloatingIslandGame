using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomDirectionHandler : MonoBehaviour
{
    bool currentTension = false;
    bool atMaxRotation = false;
    public int windDirection = 1;
    float currentWindSpeed = 0f;
    float currentWindAngle = 0f;
    public float alignmentModifier;
    float releaseAngle;
    public float maxAngle = 90;
    float timeSinceRelease;
    float tensionLimit;

    private void Start()
    {
        UpdateWindData();
        releaseAngle = transform.eulerAngles.y;
    }

    private void Update()
    {
        if (!currentTension && !atMaxRotation)
        {
            float rotationDuration = 15 / (currentWindSpeed * alignmentModifier) + 1;
            float t = (Time.time - timeSinceRelease) / rotationDuration;
            float directionalMaxAngle = windDirection * maxAngle;
            transform.rotation = Quaternion.Euler(0, Mathf.SmoothStep(releaseAngle, maxAngle, t), 0);
            //transform.Rotate(new Vector3(0, Mathf.SmoothStep(releaseAngle, maxAngle, t), 0));
            if (Mathf.Approximately(transform.eulerAngles.y, directionalMaxAngle))
            {
                atMaxRotation = true;
            }
        }
        if (currentTension)
        {

        }

        
    }
    public void UpdateWindData()
    {
        WindDirector tempWind = GameObject.FindGameObjectWithTag("WindDirector").GetComponent<WindDirector>();
        currentWindAngle = tempWind.angle;
        currentWindSpeed = tempWind.windPower;
    }
    public void ResetRelease()
    {
        timeSinceRelease = Time.time;
        releaseAngle = transform.eulerAngles.y;
    }
    public void StartTension()
    {
        currentTension = true;

    }
}

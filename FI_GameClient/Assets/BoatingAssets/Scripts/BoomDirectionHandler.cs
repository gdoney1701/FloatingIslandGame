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
    Vector2 sailVector;
    bool clockwise;

    private void Start()
    {
        UpdateWindData();
        releaseAngle = transform.eulerAngles.y;
        sailVector = new Vector2(0, 1); 
    }

    private void Update()
    {
        Vector2 sailVector = new Vector2(Mathf.Cos(transform.eulerAngles.y*Mathf.Deg2Rad), Mathf.Sin(transform.eulerAngles.y*Mathf.Deg2Rad)).normalized;
        if (transform.eulerAngles.y > 180)
        {
            Debug.DrawRay(transform.position, new Vector3(-sailVector.x, 0, sailVector.y), Color.red);
        }
        else
        {
            Debug.DrawRay(transform.position, new Vector3(-sailVector.x, 0, sailVector.y), Color.green);
        }
        if (!currentTension && !atMaxRotation)
        {
            float rotationDuration = 15 / (currentWindSpeed * alignmentModifier) + 1;
            float t = (Time.time - timeSinceRelease) / rotationDuration;
            float newAngle = Mathf.SmoothStep(releaseAngle, currentWindAngle, t);
            if (maxAngle < newAngle && newAngle < 360-maxAngle)
            {
                transform.rotation = Quaternion.Euler(0, newAngle, 0);
            }
            if (transform.eulerAngles.y > 360-maxAngle || transform.eulerAngles.y < maxAngle)
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
        if (!currentTension)
        {
            ResetRelease();
        }
        atMaxRotation = false;

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

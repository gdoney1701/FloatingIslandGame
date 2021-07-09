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
    BoomDirectionHandler boomHandler;

    public float alignmentModifier;


    private void Awake()
    {
        heading = transform.rotation.y;
        windSampling = GameObject.FindGameObjectWithTag("WindDirector").GetComponent<WindDirector>();
        boomHandler = transform.GetChild(1).gameObject.GetComponent<BoomDirectionHandler>();

    }

    private void Update()
    {
        heading = transform.transform.eulerAngles.y;
        boomAngle = boomObject.transform.eulerAngles.y;
        float globalWindAngle = windSampling.angle;

        Debug.Log("Wind is " + globalWindAngle.ToString() + ", Ship is " + boomAngle.ToString());

        alignmentModifier = CheckHeadingAgainstWind(globalWindAngle);
        if( heading - globalWindAngle > 0)
        {
            boomHandler.windDirection = 1;
        }
        else
        {
            boomHandler.windDirection = -1;
        }
        boomHandler.alignmentModifier = alignmentModifier;


    }

    private float CheckHeadingAgainstWind(float windAngle)
    {
        Vector2 windVector = new Vector2(Mathf.Cos(windAngle * Mathf.Deg2Rad), Mathf.Sin(windAngle * Mathf.Deg2Rad));
        Vector2 headingVector = new Vector2(Mathf.Cos(heading * Mathf.Deg2Rad), Mathf.Sin(heading * Mathf.Deg2Rad));
        float coneAngle = Mathf.Cos(45 * Mathf.Deg2Rad);
        float windAlignment = 1 - Vector2.Dot(headingVector, -windVector);
        return windAlignment;
        //Debug.Log("Alignment at " + Vector2.Dot(headingVector, -windVector).ToString() + ", cone at " + coneAngle.ToString());
    }
}

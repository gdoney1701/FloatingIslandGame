using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindDirector : MonoBehaviour
{
    public Vector2 globalWindDirection;
    private bool windVectorsPresent = false;
    private GameObject xAxisArrow;
    private GameObject yAxisArrow;

    //Arrow for Testing Purposes
    public GameObject directionArrow;

    private void Awake()
    {
        GenerateWind();
    }

    public void GenerateWind()
    {
        if (windVectorsPresent)
        {
            Destroy(xAxisArrow);
            Destroy(yAxisArrow);
            xAxisArrow = null;
            yAxisArrow = null;
            windVectorsPresent = false;
        }
        globalWindDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;

        //Have to offset by 90 degrees -> radians to recontextualize into y/x space
        float angle = Mathf.Atan2(globalWindDirection.y, globalWindDirection.x); //Creates an angle based on the normalized global wind
        angle *= Mathf.Rad2Deg;
        Debug.Log(angle);
        //These 4 lines exist only for testing purposes, can be removed later on
        xAxisArrow = Instantiate(directionArrow, directionArrow.transform.position, new Quaternion(0, 0, 0, 0));
        yAxisArrow = Instantiate(directionArrow, directionArrow.transform.position, new Quaternion(0, 0, 0, 0));

        GenerateVectorComponents(Color.red, xAxisArrow, true);
        GenerateVectorComponents(Color.green, yAxisArrow, false);

        directionArrow.transform.rotation = Quaternion.Euler(0, angle, 0);
        //directionArrow.transform.Rotate(new Vector3(0, angle, 0));
        windVectorsPresent = true;
    }

    public void GenerateVectorComponents(Color vectorColor, GameObject axis, bool xAxis)
    {
        //This code exists only to test the vector creation system for the global wind
        foreach (Transform child in axis.transform)
        {
            child.gameObject.GetComponent<MeshRenderer>().material.color = vectorColor;
        }

        axis.transform.position = new Vector3(xAxisArrow.transform.position.x, xAxisArrow.transform.position.y + 2, xAxisArrow.transform.position.z);
        float globalWindModifier;
        if (xAxis)
        {
            globalWindModifier = globalWindDirection.x;
            axis.transform.Rotate(0, 90, 0);
        }
        else
        {
            globalWindModifier = globalWindDirection.y;
        }
        axis.transform.localScale = new Vector3(xAxisArrow.transform.localScale.x, xAxisArrow.transform.localScale.y, xAxisArrow.transform.localScale.z * globalWindModifier);
    }

}

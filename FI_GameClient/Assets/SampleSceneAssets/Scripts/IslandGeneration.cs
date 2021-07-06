using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandGeneration : MonoBehaviour
{
    public float radius = 10;
    public float shellThickness = 1;
    public int islandNumber = 10;
    public GameObject islandPrefab;
    public GameObject islandParent;
    public int failureThreshold = 10;
    public int platformMaxSize = 1;

    // Start is called before the first frame update
    void Start()
    {
        List<Vector3> pointStart = new List<Vector3>();
        float minRad = radius - shellThickness;
        int i = 0;
        int failCounter = 0;
        while( i < islandNumber)
        {
            Vector3 newCoords = new Vector3(
                Random.Range(-radius, radius),
                Random.Range(-radius, radius),
                Random.Range(-radius, radius));
            float vectorCheck = Mathf.Sqrt(
                Mathf.Pow(newCoords.x, 2) + Mathf.Pow(newCoords.y, 2) + Mathf.Pow(newCoords.z, 2));
            if (vectorCheck >= minRad && vectorCheck <= radius)
            {
                Collider[] areaCheck = Physics.OverlapSphere(newCoords, platformMaxSize);
                if (areaCheck.Length > 0)
                {
                    failCounter++;
                    if (failCounter > 0)
                    {
                        failCounter = 0;
                        i++;
                    }
                    continue;
                }
                pointStart.Add(newCoords);
                i++;
                failCounter = 0;
                continue;
            }
        }
        foreach(Vector3 entry in pointStart)
        {
            GameObject newIsland = Instantiate(islandPrefab, entry, new Quaternion(0,0,0,0));
            newIsland.transform.SetParent(islandParent.transform);
        }
        islandParent.name += pointStart.Count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

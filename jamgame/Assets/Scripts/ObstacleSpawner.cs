using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public bool canSpawn = true;
    public GameObject obstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (this.transform.childCount == 0)
            canSpawn = true;

        
        if(canSpawn == true)
        {
            var obj = Instantiate(obstaclePrefab, new Vector3(0, 0, 0), Quaternion.identity);
            obj.transform.parent = this.transform;
            canSpawn = false;

            obj.GetComponent<ObstacleBehaviour>().SetRotateSpeed(Random.Range(25, 150));
            obj.GetComponent<ObstacleBehaviour>().SetStartAngle(new Vector3(0, 0, Random.Range(0, 360)));
        }


    }
}

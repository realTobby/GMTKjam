using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    public float obstacleSpeed = 50f;

    public float shrinkSpeed = 0.3f;

    public bool isShrinking = true;

    public void SetRotateSpeed(float speed)
    {
        obstacleSpeed = speed;
    }

    public void SetStartAngle(Vector3 angle)
    {
        this.transform.eulerAngles = angle;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // rotate
        RotateLeft();

        // shrink
        if(isShrinking == true)
            Shrink();

        if (isShrinking == false)
            Destroy(this.gameObject);

    }

    public void Shrink()
    {

        this.transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        if (this.transform.localScale.x <= 0.1)
            isShrinking = false;

    }


    public void RotateLeft()
    {
        this.transform.RotateAround(this.transform.position, Vector3.back, obstacleSpeed * Time.deltaTime);
    }

    public void RotateRight()
    {
        this.transform.RotateAround(this.transform.position, Vector3.forward, obstacleSpeed * Time.deltaTime);
    }

}

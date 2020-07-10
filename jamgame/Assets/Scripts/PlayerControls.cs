using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    private Vector3 screenMiddle = new Vector3(0, 0, 0);
    public float rotateSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public bool IsUpperHallf()
    {
        if (this.transform.position.y > 0)
            return true;
        return false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RotateRight();
        }
            
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RotateLeft();
        }
            

    }

    public void RotateLeft()
    {
        this.transform.RotateAround(screenMiddle, Vector3.back, rotateSpeed * Time.deltaTime);
    }

    public void RotateRight()
    {
        this.transform.RotateAround(screenMiddle, Vector3.forward, rotateSpeed * Time.deltaTime);
    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.tag == "obstacle")
        {
            Debug.Log("you just died :)");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}

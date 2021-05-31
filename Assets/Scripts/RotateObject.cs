using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    float rotSpeed = 15 * 120;

    //// Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0))
        {
            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;
            float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Time.deltaTime;

            GetComponent<Transform>().RotateAround(Vector3.zero, Vector3.up, -rotX);
            GetComponent<Transform>().RotateAround(Vector3.zero, Vector3.right, rotY);


            //GetComponent<Transform>().Rotate(new Vector3(0, 1, 0));
            //Debug.Log("space is pressed");
        }
    }



    //private void OnMouseDown()
    //{
    //    float rotX = Input.GetAxis("Mouse X") * rotSpeed;
    //    float rotY = Input.GetAxis("Mouse Y") * rotSpeed;

    //    GetComponent<Transform>().RotateAround(Vector3.zero, Vector3.up, -rotX);
    //    GetComponent<Transform>().RotateAround(Vector3.zero, Vector3.right, rotY);
        
    //}

    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_Rotate : MonoBehaviour
{

    public float angleX = 0;
    public float angleY = 360;
    public float angleZ = 0;

    float rotateAngleX = 0;
    float rotateAngleY = 0;
    float rotateAngleZ = 0;


    private void OnMouseDown()
    {
        rotateAngleX = angleX;
        rotateAngleY = angleY;
        rotateAngleZ = angleZ;
    }

    private void OnMouseUp()
    {
        rotateAngleX = 0;
        rotateAngleY = 0;
        rotateAngleZ = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        this.transform.Rotate(rotateAngleX / 50, rotateAngleY / 50, rotateAngleZ / 50);
    }
}

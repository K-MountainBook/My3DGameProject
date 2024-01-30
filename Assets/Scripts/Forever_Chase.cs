using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_Chase : MonoBehaviour
{

    public string targetObjectName;
    public float speed = 1;
    GameObject targetObject;

    // Start is called before the first frame update
    void Start()
    {
        targetObject = GameObject.Find(targetObjectName);
    }


    private void FixedUpdate()
    {
        Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;
        float vx = dir.x * speed;
        float vz = dir.z * speed;
        this.transform.Translate(vx / 50, 0, vz / 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

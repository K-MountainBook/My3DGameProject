using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_Move : MonoBehaviour
{

    public float speed = 2;

    float vx = 0;
    float vz = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vx = Input.GetAxisRaw("Horizontal") * speed;
        vz = Input.GetAxisRaw("Vertical") * speed;
    }

    private void FixedUpdate()
    {
        this.transform.Translate(vx / 50, 0, vz / 50);
    }
}

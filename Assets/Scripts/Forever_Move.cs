using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_MoveX : MonoBehaviour
{
    public float speedX = 1;

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
        this.transform.Translate(speedX / 50, 0, 0);
    }
}

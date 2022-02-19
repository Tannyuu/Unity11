using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * 5.0f * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMov : MonoBehaviour
{
    private Vector3 IniPos;
    private float Velocity = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        IniPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Velocity * Time.deltaTime);
        if (transform.position.x < -17.81f)
        {
            transform.position = IniPos;
        }
    }
}

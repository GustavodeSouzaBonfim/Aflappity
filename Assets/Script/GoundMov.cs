using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoundMov : MonoBehaviour
{
    private float veloc = 1.0f;
    private float RepPos = -6.2f;

    private Vector3 IniPos;
    // Start is called before the first frame update
    void Start()
    {
       IniPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * veloc * Time.deltaTime);
        if (transform.position.x <= RepPos)
        {
            transform.position = IniPos;
        }
    }
}

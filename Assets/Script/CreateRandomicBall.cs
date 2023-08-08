using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomicBall : MonoBehaviour
{
    public float gTime;
    public float cDown;
    public float TimeTg;
    public bool isGenering;
    public GameObject pfPU;

    // Start is called before the first frame update
    void Start()
    {
        isGenering = false;
    }

    // Update is called once per frame
    void Update()
    {
        gTime = Time.time;
        if (isGenering == false)
        {
            cDown = Random.Range(0, 15);
            TimeTg = gTime + cDown;
            isGenering = true;
        }
        if (gTime >= TimeTg)
        {
            Instantiate(pfPU, new Vector3(Random.Range(-6.27f, 6.82f), 5.68f, 0), Quaternion.identity);
            isGenering = false;
        }
    }
}

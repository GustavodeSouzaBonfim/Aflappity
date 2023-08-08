using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneManeger : MonoBehaviour
{
    public Enemy enemy;
    public float gTime;
    public float lCDown;
    public GameObject pfStone;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Enemy>();
        lCDown = gTime + 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        gTime = Time.time;
        if (gTime >= lCDown){
            Instantiate(pfStone, new Vector3(9.72f, Random.Range(-2.99f, 4.1f), 0), Quaternion.identity);
            lCDown = gTime + 0.75f;
        }
    }
}

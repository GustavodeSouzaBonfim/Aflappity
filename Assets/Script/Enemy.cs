using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int i = 0;
    public float veloc = 5.6f;
    public Rigidbody2D rb;
    public int launchForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        launchForce = 65;
    }

    // Update is called once per frame
    void Update()
    {
        while (i < launchForce)
        {
            rb.AddForce(Vector3.up * veloc);
            rb.AddForce(Vector3.left * veloc);
            i++; 
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            print(other.name + " foi atingido");
            Destroy(this.gameObject);
        } else if (other.tag == "Ground") {
            Destroy(this.gameObject);
        }
    }
}

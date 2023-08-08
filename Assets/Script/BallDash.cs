using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * 2.5f * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        print("O objeto " + this.name + " colidiu com " + other.name);
        
        if (other.tag == "Player")
        {
            PlayerMov player = other.GetComponent<PlayerMov>();
            player.playerVeloc += 1;
            Destroy(this.gameObject);
        }
        if (other.name == "Ground sprite")
        {
            Destroy(this.gameObject);
        }
        
    }
}

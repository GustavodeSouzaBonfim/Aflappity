using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public bool DashActivate;
    public GameObject pfPU;
    public float playerVeloc = 4.5f;
    public float horizontalInput;
    public float verticalInput;
    public GameObject pfEgg;
    public float CowlDown = 0.3f;
    public float CowlDownDash; 
    public float TImeGame = 0.0f;
    public float DashValocity = 6.5f;
    public SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        DashActivate = false;
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        CreatePU();
        Dash();
        Moviment();
        Dispar(); 
    }

    void CreatePU()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(pfPU, new Vector3(Random.Range(-6.27f, 6.82f), 5.68f, 0), Quaternion.identity);
        }
    }
    void Dash()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            DashActivate = true;
            CowlDownDash = Time.time + 0.2f;
        }
        if (CowlDownDash > Time.time && DashActivate == true)
        {
            if (horizontalInput >= 0)
            {
                transform.Translate(Vector3.right * (playerVeloc + 7) * Time.deltaTime);
            }
            else if (horizontalInput < 0)
            {
                transform.Translate(Vector3.right * ((playerVeloc*-1) - 7) * Time.deltaTime);
            }
        } else
        {
            DashActivate = false;
        }

    }
    void Dispar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > TImeGame)
            {
                Instantiate(pfEgg, transform.position + new Vector3(0, -0.88f, 0), Quaternion.identity);
                TImeGame = Time.time + CowlDown;
            }
            
        }
    }
    void Moviment()
    {
        //Defining the variables that affect object movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Moviment constant
        transform.Translate(horizontalInput * playerVeloc * Time.deltaTime * Vector3.right);
        transform.Translate(verticalInput * playerVeloc * Time.deltaTime * Vector3.up);

        //Limiting movement
        if (transform.position.x <= -8.5f){
            transform.position = new Vector3(-8.5f, transform.position.y, 0);
        } if (transform.position.x >= 8.35f){
            transform.position = new Vector3(8.35f, transform.position.y, 0);
        } if (transform.position.y <= -3.11f){
            transform.position = new Vector3(transform.position.x, -3.11f, 0);
        } if (transform.position.y > 4.5f){
            transform.position = new Vector3(transform.position.x, 4.5f, 0);
        }
    }
}

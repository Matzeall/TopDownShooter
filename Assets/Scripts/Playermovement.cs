using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour {

    [SerializeField]
    private string s="";
    Vector2 mov;
    Rigidbody2D rgbd;
    [SerializeField]
    int speed;
    
    CreateBullet CreateBullet;
    
    // Use this for initialization
	void Start () {
        rgbd = gameObject.GetComponent<Rigidbody2D>();
        CreateBullet = gameObject.GetComponent<CreateBullet>();
    }
	
	// Update is called once per frame
	void Update () {
        mov.x = 0;
        mov.y = 0;
        
        if (s == "WASD")
        {
            if (Input.GetKey(KeyCode.W))
                mov.y += 1;
            if (Input.GetKey(KeyCode.A))
                mov.x += -1;
            if (Input.GetKey(KeyCode.S))
                mov.y += -1;
            if (Input.GetKey(KeyCode.D))
                mov.x += 1;
            if (Input.GetKeyDown(KeyCode.Space) && CreateBullet != null)
            {
                CreateBullet.Create();
            }

                
        }
        else if (s == "Arrows")
        {
            if (Input.GetKey(KeyCode.UpArrow))
                mov.y += 1;
            if (Input.GetKey(KeyCode.LeftArrow))
                mov.x += -1;
            if (Input.GetKey(KeyCode.DownArrow))
                mov.y += -1;
            if (Input.GetKey(KeyCode.RightArrow))
                mov.x += 1;
            if (Input.GetKeyDown(KeyCode.RightShift)&& CreateBullet != null && CreateBullet.GetTarget()!= null)
            {
                CreateBullet.Create();
            }
                
        }
        else
        {
            Debug.Log(s + " ist keine Steuerung");
        }
        //movement
       
        if (rgbd)
        {
            rgbd.velocity = mov.normalized * speed * Time.deltaTime;
        }
    }
}

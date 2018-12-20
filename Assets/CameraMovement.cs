using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour {

    [SerializeField]
    GameObject PlayerOne;
    [SerializeField]
    GameObject PlayerTwo;
    Vector3 vek;
    [SerializeField]
    Camera MyCamera;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerOne && PlayerTwo)
        {
            vek = new Vector3((PlayerOne.transform.position.x - PlayerTwo.transform.position.x) / 2, (PlayerOne.transform.position.y - PlayerTwo.transform.position.y) / 2, 10);
            transform.position = PlayerOne.transform.position - vek;
        }
       
        Debug.Log(vek.ToString());
        if (MyCamera)
        {
            if (Mathf.Abs(vek.x) > 7.5||Mathf.Abs(vek.y)>5.3)
            {
                if(Mathf.Abs(vek.x)>Mathf.Abs(vek.y)*2.2f)
                MyCamera.orthographicSize = Mathf.Abs(vek.x) * 0.65f+1.5f;
                else
                MyCamera.orthographicSize = Mathf.Abs(vek.y)+1.5f;
            }


        }
            
     

        
	}
}

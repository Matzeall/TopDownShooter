using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullet : MonoBehaviour {

    [SerializeField]
    GameObject BulletPrefab;

    GameObject Bullet;

    [SerializeField]
     GameObject Target;

    public GameObject GetTarget()
    {
        return Target;
    }
    public void Create()
    {
        if(BulletPrefab)
        Bullet = Instantiate(BulletPrefab);
        Bullet.transform.position = transform.position;
       
    } 
}

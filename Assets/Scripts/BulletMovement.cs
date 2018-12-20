using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {
    GameObject Target;
    CreateBullet createBullet;
    Rigidbody2D rgbd;
    [SerializeField]
    string Player="";
    [SerializeField]
    int BulletSpeed;
    GameObject Spieler;
    Health health;
    [SerializeField]
    string BulletTag;

    // Use this for initialization
    void Start () {
        Spieler = GameObject.Find(Player);
        if (Spieler) createBullet = Spieler.GetComponent<CreateBullet>();
        else Debug.Log("kein CreateBullet Script");
        rgbd = gameObject.GetComponent<Rigidbody2D>();
        if (rgbd && createBullet && createBullet.GetTarget()) rgbd.velocity = new Vector3(createBullet.GetTarget().transform.position.x - transform.position.x, createBullet.GetTarget().transform.position.y - transform.position.y, 0).normalized * BulletSpeed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        if (createBullet.GetTarget())
        {
            if (collision.gameObject.tag == createBullet.GetTarget().tag)
            {
                Debug.Log("Hit Player");
                Destroy(gameObject);
                health = createBullet.GetTarget().gameObject.GetComponent<Health>();
                if (health) health.TakeDmg();
                else Debug.Log("kein HealthScript");

            }
            else if (collision.gameObject.tag == "Wall"||collision.gameObject.tag== BulletTag)
            {
                Destroy(gameObject);
                Debug.Log("Hit Something");
            }
        }
    }


}

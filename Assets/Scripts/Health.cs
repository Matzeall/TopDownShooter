using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    [SerializeField]
    private int MaxHealth;
    private int curHealth;

    

    // Use this for initialization
    void Start () {
        curHealth = MaxHealth;
	}
    private void Update()
    {
        if (curHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Destroyed");
        }
    }

    public void TakeDmg()
    {
        curHealth -= 1;
        Debug.Log(curHealth);
    }
}

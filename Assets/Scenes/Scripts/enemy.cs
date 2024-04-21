using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float enemyHealth;
    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        if(enemyHealth <= 0)
        {
            Debug.Log("enemy is dead");
            Destroy(gameObject);
        }
    }
    
    
}

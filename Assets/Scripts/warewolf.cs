using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warewolf : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float enemyHealth;
    public float currenthealth;
   [SerializeField] float remainimgTime;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
       
        currenthealth = enemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (remainimgTime > 0)
        {

            remainimgTime -= Time.deltaTime;
        }
        else if (remainimgTime < 0)
        {
            remainimgTime = 0;

        }
        int minutes = Mathf.FloorToInt(remainimgTime / 60);
        int seconds = Mathf.FloorToInt(remainimgTime % 60);



        if (enemyHealth < currenthealth)
        {
            currenthealth = enemyHealth;
           
        }
        if (enemyHealth <= 0)
        {
            Debug.Log("enemy is dead");
           
            if (remainimgTime == 0)
            {
                Destroy(gameObject);
            }
        }
    
}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<playerhealth>().health -= 20;
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warewolf : MonoBehaviour
{
    public float wareWolfHealth;
    public float currenthealth;
    private Animator anim;

    [SerializeField] float remainimgTime;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        currenthealth = wareWolfHealth;
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



        if (wareWolfHealth < currenthealth)
        {
            currenthealth = wareWolfHealth;
            anim.SetTrigger("isAttacked");
        }
        if (wareWolfHealth <= 0)
        {
            Debug.Log("enemy is dead");
            anim.SetBool("isDead", true);
            if (remainimgTime == 0)
            {
                Destroy(gameObject);
            }
        }
    }


}

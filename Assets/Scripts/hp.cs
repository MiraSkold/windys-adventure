using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
   
    [SerializeField]
    GameObject HP1;
    [SerializeField]
    GameObject HP2;
    [SerializeField]
    GameObject HP3;
    public int liv = 3;
    // Start is called before the first frame update

    public void TakeDamage()
    {
        liv -= 1;
        if (liv == 0)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {

        
    }

    // Update is called once per frame
    public void Update()
    {
       

       
        if (transform.position.y < -6)
        {
           
            if (liv == 2)
            {
                Destroy(HP1);
            }

            if (liv == 1)
            {
                Destroy(HP3);
            }

            if (liv == 0)
            {
                Destroy(HP2);
            }
        }
    }
}

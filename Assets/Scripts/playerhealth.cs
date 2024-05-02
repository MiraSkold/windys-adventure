using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerhealth : MonoBehaviour
{
    public float health;
    public float maxhealth;
    public Image healthBar;
    public string scene;
    [SerializeField] float remainimgTime;
    // Start is called before the first frame update
    void Start()
    {
        maxhealth = health;
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

        healthBar.fillAmount = Mathf.Clamp(health / maxhealth, 0, 1);

        if(health <= 0)
        {
            //SceneManager.LoadScene(scene);
        }
        if(transform.position.y <= -6)
        {
            if (remainimgTime == 0)
            {
                SceneManager.LoadScene(scene);
            }
            
        }
    }

}

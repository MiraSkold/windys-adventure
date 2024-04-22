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
    // Start is called before the first frame update
    void Start()
    {
        maxhealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxhealth, 0, 1);

        if(health <= 0)
        {
            //SceneManager.LoadScene(scene);
        }
    }
}

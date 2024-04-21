using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class coinnumber : MonoBehaviour
{
    public coinmanager cm;
    
    public TextMeshProUGUI cointext;
   
    // Start is called before the first frame update
    void Start()
    {
         

    }

    // Update is called once per frame
    void Update()
    {
        cointext.text = "x" + cm.coinCount.ToString();
    }
    
}

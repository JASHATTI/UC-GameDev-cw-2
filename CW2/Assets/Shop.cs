using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shop : MonoBehaviour
{
    int score = 0;
    int inc=1;
    public Text textScore;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickup()
    {
        score += inc;
        textScore.text = score + "";

    }


    public void shopup()
    {
        if (score >= 5 )
        {
            score -= 5;
            inc++ ;
            textScore.text = score + "";
            
        }
    }
}

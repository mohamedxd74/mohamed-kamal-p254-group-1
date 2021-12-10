using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementsInt : MonoBehaviour
{
    public int score =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score > 60 && score <75)
        {
            print("passed");
        }
        else if (score > 75 && score < 100)
        {
            print("passed well ");
        }  
        else if (score == 100)
        {
            print("passed great ");
        }
        else
        {
            print(" try agian ");
        }

    }

}

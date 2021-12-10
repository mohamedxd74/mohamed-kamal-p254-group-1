using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functionwork : MonoBehaviour
{
    int a = 24;
    // Start is called before the first frame update
    void Start()
    {
        int a1 = doubleval();
        print(a1);

        int val1 = sumval(6);
        print(val1);

    }

    // Update is called once per frame
    void Update()
    {

    }
    int doubleval()
    {
        return (a * 6);
    }
    
    int sumval(int val)
    {
        return (val + 10);
    }
}

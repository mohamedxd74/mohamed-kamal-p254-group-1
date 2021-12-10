using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariblesWork : MonoBehaviour
{

    int number = 5;
    float position = 6.1f;
    char letter = 'a';
    public string name = "mohamed";
    // Start is called before the first frame update
    void Start()
    {
        print(number);
        print("position" + position);
        print("letter" + letter);

    }

    // Update is called once per frame
    void Update()
    {
        // print("you're" + name);
    }
}
 
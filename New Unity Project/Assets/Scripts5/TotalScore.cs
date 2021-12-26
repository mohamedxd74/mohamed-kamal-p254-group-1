using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalScore : MonoBehaviour
{
    public int score;

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            if (value > 5 && value < 10) // 5 < score < 10
            {
                score = value;
            }
        }
    }


    public int Result { get; set; }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager current;
    public bool isBlue = false;

    // Start is called before the first frame update
    void Start()
    {
        current = this;
    }

    public void SwitchColor()
    {
        if (isBlue)
            isBlue = false;
        else isBlue = true;
    }
}

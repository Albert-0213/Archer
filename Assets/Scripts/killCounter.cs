﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class killCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    void MmonsterKilled()
    {
        GlobalData.score += 1;
        score.text = GlobalData.score.ToString();
    }
}
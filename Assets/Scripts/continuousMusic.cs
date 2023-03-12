﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continuousMusic : MonoBehaviour
{
    private static continuousMusic instance = null;
    public static continuousMusic Instance
    {
        get {return instance;}
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TascUnity
{
    public class GlobalTimerUpdater : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            TimeState.UpdateGlobalTimer();
        }
    }

}

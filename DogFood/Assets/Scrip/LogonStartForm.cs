﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUIFW;

/// <summary>
/// 开始场景的控制
/// </summary>
public class LogonStartForm :  BaseUIForm {


    private void Awake()
    {
        CurrentUIType.UIForms_Type = UIFormType.Normal;
        CurrentUIType.UIForm_LucencyType = UIFormLucenyType.Translucence;
        CurrentUIType.UIForms_ShowMode = UIFormShowMode.ReverseChange;
       
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

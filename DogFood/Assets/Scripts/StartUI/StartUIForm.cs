using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUIFW;

/// <summary>
/// 登录窗体控制脚本
/// </summary>
public class StartUIForm :BaseUIForm {

    private void Awake()
    {
        CurrentUIType.UIForms_Type = UIFormType.PopUp;
        CurrentUIType.UIForm_LucencyType = UIFormLucenyType.Translucence;
        CurrentUIType.UIForms_ShowMode = UIFormShowMode.Normal;

            
         
        
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

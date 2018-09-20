using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUIFW;
using UnityEngine.UI;


/// <summary>
/// 商店控制脚本
/// </summary>
public class StoreUIForm : BaseUIForm{

    /// <summary>
    ///  商店狗粮
    /// </summary>
    public Toggle StoreDogFood;
    /// <summary>
    /// 商店狗狗
    /// </summary>
    public Toggle StoreDogType;
    /// <summary>
    /// 商店弹弓
    /// </summary>
    public Toggle StoreDogShot;
    /// <summary>
    /// 
    /// </summary>
    private void Awake()
    {
        CurrentUIType.UIForms_Type = UIFormType.PopUp;
        CurrentUIType.UIForm_LucencyType = UIFormLucenyType.Translucence;
        CurrentUIType.UIForms_ShowMode = UIFormShowMode.Normal;

        // 关闭
        RigisterButtonObjectEvent("Button_Close", 
          p =>
          {
              CloseUIForm();
          });        
       // 弹弓  
       RigisterButtonObjectEvent("Toggle_Slingshot", 
          p =>
          {
            //  OpenUIForm();            
          });        
        
        
    }
    // Use this for initialization
    void Start () {
		
	}
   
      
	// Update is called once per frame
	void Update () {
		
	}
}

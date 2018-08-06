using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///   
/// </summary>
public class SlingshotBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    #region  属性 


    /// <summary>
    /// 
    /// </summary>
    private string  slingname;
 
    /// <summary>
    ///  
    /// </summary>    
    private int slingid;


     /// <summary>
     /// 弹弓的射速
     /// </summary>
    private float slingspeed;

    /// <summary>
    ///
    /// </summary>
    private bool EatSucced;

    /// <summary>
    /// 
    /// </summary>
    private GameObject sliobject;
  /// <summary>
  ///  弹弓的材质
  /// </summary>
    private Material slimater;
   
    /// <summary>
    ///
    /// </summary>
       private   GameObject    leftpillar;

    /// <summary>
    /// 
    /// </summary>
       private   GameObject   rightpillar;
     
     /// <summary>
     ///  支柱的材料
     /// </summary>
    private Material pillmater;

    public  string  SlingName
    {
        get {    return slingname;   }
        set { slingname = value; }  
    }
    public   int SingId
    {
        get { return slingid; }
        set { slingid = value; }
    }
    public   float  SlingSpeed
    {
        get { return slingspeed; }
        set { slingspeed = value; }
    }

    public  GameObject  SlingObj
    {
        get { return sliobject; }
        set { sliobject = value; }
    }

    
    /// <summary>
    ///
    /// </summary>
     public  Material  SlingMater
    {
      get { return slimater; }
       set { slimater = value;   }
    }

     public  GameObject RightPillar
    {
       get { return RightPillar; }
       set { rightpillar = value; }
    }
    
    public Material  PillMateril
    {
        get { return pillmater;  }
        set { pillmater = value; }
    }

    
    #endregion


    
}
 
/// <summary>
///  
/// </summary>
public  enum   SlingType
{
        Sli_Wood,   //木质弹弓
        Sli_Bamboo, // 竹制
        Sli_Metal,  /// 金属
        Sli_Synthetic //合成材料弹弓
}
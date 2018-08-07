using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  狗控制的基类
/// </summary>
public class DogBase : MonoBehaviour {

    private string dogname;

    private DogType dogtype;

    public  string  DogName
    {
        get { return  dogname; }
        set { dogname = value;  }
    }

    public DogType DogType
    {
        get { return dogtype; }
        set { dogtype = value; }
    }
}

/// <summary>
/// 狗的种类  超小型 小型 中型 大型 超大型 
/// </summary>
public enum  DogType
{
       dog_type1,   //吉娃娃
       dog_type2,  //柴犬犬 
       dog_type3, //哈士奇
       dog_type4, // 牧羊犬
       dog_type5, // 秋田犬
}
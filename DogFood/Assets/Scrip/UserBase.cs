using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 用户使用的基类
/// </summary>
public class UserBase : MonoBehaviour {

    #region 属性字段

    /// <summary>
    /// 用户的用户名 
    /// </summary>
    private string username;
     
    /// <summary>
    /// 用户昵称
    /// </summary>
    private string usernickname;

    /// <summary>
    /// 用户密码
    /// </summary>
    private string userpassword;
    
    /// <summary>
    /// 用户的金币
    /// </summary>
    private string usergoldcoin;
    
    /// <summary>
    ///  用户的使用 ID
    /// </summary>
    private string userid;


    /// <summary>
    ///  用户ID
    /// </summary>
    public string UserId
    {
        get
        {
            return userid;
        }

        set
        {
            userid = value;
        }
    }
   
    /// <summary>
    ///  用户使用的金币 
    /// </summary>
    public string UserGoldCoin
    {
        get
        {
            return usergoldcoin;
        }

        set
        {
            usergoldcoin = value;
        }
    }
   
    /// <summary>
    /// 用户密码
    /// </summary>
    public string UserPassword
    {
        get
        {
            return userpassword;
        }

        set
        {
            userpassword = value;
        }
    }
   
    /// <summary>
    /// 用户昵称
    /// </summary>
    public string UserNickName
    {
        get
        {
            return usernickname;
        }

        set
        {
            usernickname = value;
        }
    }
   /// <summary>
   ///  
   /// </summary>
    public string UserName
    {
        get
        {
            return username;
        }

        set
        {
            username = value;
        }
    }

    /// <summary>
    /// 用户的积分
    /// </summary>

   #endregion 

     
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

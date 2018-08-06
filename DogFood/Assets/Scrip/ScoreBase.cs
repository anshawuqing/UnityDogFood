using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 分数控制脚本
/// </summary>
public class ScoreBase : MonoBehaviour {


    public static ScoreBase instance;
 

   /// <summary>
   /// 当前食物的分数
   /// </summary>
    public static  int  Food_CurrentScore;

    /// <summary>
    /// 食物的总分数
    /// </summary>
    public static int Food_AllScore;



    public GameObject Score_Text_Ui;

    
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
         
    }



}


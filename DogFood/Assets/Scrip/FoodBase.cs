using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 食物控制的基类
/// </summary>
public class FoodBase : MonoBehaviour {


    /// <summary>
    ///  food id
    /// </summary>
    private string foodid;

    /// <summary>
    //食物的分数
   /// </summary>
    private int foodscore;

    /// <summary>
    /// food  type
    /// </summary>
    private FoodType foodtype;
  
    /// <summary>
    /// food 的实例
    /// </summary>
    private GameObject foodobj;
 
    /// <summary>
    ///  食物的材质
    /// </summary>
    private Material foodmateril;

    

    /// <summary>
    ///食物的 ID
    /// </summary>
    public string FoodId
    {
        get {  return  foodid; }
        set { foodid = value; }
    }

    public  int  FoodScore
    {
        get {   return  foodscore; }
        set { foodscore = value; }
   }

  public FoodType FoodType
    {
         get { return  foodtype; }
        set { foodtype = value; }
    }

     public  GameObject  FoodObject
    {
          get { return foodobj; }
           set {  foodobj = value; }
    }

    public  Material  FoodMateril
    {
        get { return foodmateril;  }
        set { foodmateril = value; }
    }
}

/// <summary>
/// 食物的类型   
/// </summary>
public enum  FoodType
{
       food_hard, // 菜团子  
       food_stuffed,// 肉包子
       food_bone,// 大骨头 
       food_orifood , // 原味狗粮
      food_finefood // 精品狗粮
}
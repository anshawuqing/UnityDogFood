using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  弹射控制脚本
/// </summary>
public class LaunchControl : MonoBehaviour {

    /// <summary>
    /// 发射时的速度和力量，模拟不同力的大小
    /// </summary>
    public float Power = 10;
    /// <summary>
    ///发射时的角度
    /// </summary>
    public float Angle = 45;
    /// <summary>
    /// 重力加速度 
    /// </summary>
    public float Gravity = -10;

     
     private  Vector3 MoveSpeed;  //初速度向量
     private  Vector3 GritySpeed  = Vector3.zero;  //初速度向量
    private float dTime;    //已经过去的时间
    

	void Start () {
        EmissionVector();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    ///  得到 发射时的 发射向量
    /// </summary>
    void EmissionVector()
    {
        MoveSpeed = Quaternion.Euler(new Vector3(-Angle, 0, 0)) * Vector3.forward * Power; 
    }

    /// <summary>
    ///移动物体
    /// </summary>
    private void FixedUpdate()
    {
        GritySpeed.y = Gravity * (dTime += Time.fixedDeltaTime);

        this.transform.Translate(MoveSpeed * Time.fixedDeltaTime);
        this.transform.Translate( GritySpeed* Time.fixedDeltaTime);
    }
    
   

}

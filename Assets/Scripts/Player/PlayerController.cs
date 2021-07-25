// ****************************************************
//     文件：PlayerController.cs
//     作者：积极向上小木木
//     邮箱：positivemumu@126.com
//     日期：#CreateTime#
//     功能：
// *****************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;


    private Rigidbody rigidbody;
    public Camera camera;
    
    private Vector2 moveDir;
    private Vector2 m_Rotation;
    private Vector2 m_Look;
    private Vector2 m_Move;
    public void OnMove(InputAction.CallbackContext context)
    {
        moveDir = context.ReadValue<Vector2>();
    }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void LateUpdate()
    {
        if (moveDir.sqrMagnitude > 0.01)
        {
            rigidbody.velocity = new Vector3(0,rigidbody.velocity.y,0)+Quaternion.Euler(0, transform.eulerAngles.y, 0) * new Vector3(moveDir.x,0,moveDir.y)*moveSpeed;
            Quaternion q = Quaternion.identity;
            q.SetLookRotation(camera.transform.forward);//setlookrotaion定义看向指定方向的rotation
            transform.rotation=Quaternion.RotateTowards(transform.rotation,q,5f );
            
        }
    }
    
}

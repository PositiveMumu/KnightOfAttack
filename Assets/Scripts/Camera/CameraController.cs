// ****************************************************
//     文件：CameraController.cs
//     作者：积极向上小木木
//     邮箱：positivemumu@126.com
//     日期：#CreateTime#
//     功能：
// *****************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public InputActionReference camera;

    private CinemachineInputProvider cip;
    private bool rightButtonState=false;

    private void Awake()
    {
        cip = GetComponent<CinemachineInputProvider>();
    }

    public void OnRightButtonDown(InputAction.CallbackContext context)
    {
        if (context.canceled==false)
        {
            if (rightButtonState == false)
            {
                rightButtonState = true;
                cip.XYAxis = camera;
            }
        }
        else
        {
            rightButtonState = false;
            cip.XYAxis = null;
        }
    }
}

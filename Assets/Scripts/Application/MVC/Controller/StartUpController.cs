using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUpController : Controller
{
    public override void Execute(object data)
    {
        //注册所有的controller
        RegisterController(Consts.E_EnterScenes,typeof(EnterScenesController));

        //注册model

        //完成场景跳转
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Controller  {
    //执行事件
    public abstract void Execute(object data);

    //获取模型
    protected T GetModel<T>()
        where T:Model
    {
        return MVC.GetModel<T>() as T;
    }
    //获取视图
    protected T GetView<T>()
        where T : View
    {
        return MVC.GetView<T>() as T;
    }

    //注册模型
    protected void RegisterModel(Model model) {
        MVC.RegisterModel(model);
    }
    //注册视图
    protected void RegisterView(View view) {
        MVC.RegisterView(view);
    }
    //注册Controller
    protected void RegisterController(string eventName,Type controllerType) {
        MVC.RegisterController(eventName,controllerType);
    }
}

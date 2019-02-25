using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterScenesController : Controller
{
    public override void Execute(object data)
    {
        SceneArgs e = data as SceneArgs;
        switch (e.scenesIndex)
        {
            case 1:

            default:
                break;
        }
    }
}

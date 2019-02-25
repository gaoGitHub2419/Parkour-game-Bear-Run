using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IReusable
{
    //取出时调用
    void OnSpawn();

    //回首时调用
    void OnUnSpawn();
	
}

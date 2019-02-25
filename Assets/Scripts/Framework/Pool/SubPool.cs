using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubPool  {
    //集合保存对象
    List<GameObject> m_objects = new List<GameObject>();

    //预设-模板
    GameObject m_prefabs;

    //父物体-界面整洁
    Transform m_parent;

    //名字-每一个SubPool的Name不同，用于区分
    public string Name {
        get { return m_prefabs.name; }
    }

    //构造函数-初始化信息
    public SubPool(Transform parent,GameObject go) {
        m_prefabs = go;
        m_parent = parent;
    }

    //取出物体
    public GameObject Spawn() {
        GameObject go = null;
        foreach (var obj in m_objects)
        {
            if (!obj.activeSelf)
            {
                go = obj;
            }
        }
        if (go = null)
        {
            go = Object.Instantiate(m_prefabs);
            go.transform.parent = m_parent;
            m_objects.Add(go);
        }
        go.SetActive(true);
        go.SendMessage("OnSpawn",SendMessageOptions.DontRequireReceiver);
        return go;
    }

    //回收物体
    public void UnSpawn(GameObject go) {
        if (Contain(go))
        {
            go.SendMessage("OnUnSpawn",SendMessageOptions.DontRequireReceiver);
            go.SetActive(false);
        }
    }

    //回收所有物体
    public void UnSpawnAll() {
        foreach (var obj in m_objects)
        {
            if (obj.activeSelf)
            {
                UnSpawn(obj);
            }
        }
    }

    //判断是否属于list里面
    public bool Contain(GameObject go) {
        return m_objects.Contains(go);
    }

	
}

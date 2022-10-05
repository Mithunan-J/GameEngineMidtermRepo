using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField]
    private MonoBehaviour prefab;

    public MonoBehaviour GetNewInstance()
    {
        return Instantiate(prefab);
    }
}

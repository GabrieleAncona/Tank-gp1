using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGraphicController : MonoBehaviour
{
    private GameObject graphic;

    public void Init(GameObject _graphic)
    {
        graphic = _graphic;
    }

    private void OnEnable()
    {
       // Solo per eventi?
    }

    private void OnDisable()
    {
        
    }
}

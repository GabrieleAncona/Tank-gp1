using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileView : MonoBehaviour
{
    public ProjectileData CurrentPJData;

    private void Awake()
    {
        
    }

    public void Init(ProjectileData PJdata)
    {
        if(CurrentPJData != null)
        {
            PJdata = CurrentPJData;
        }
    }

    public void InstantiatePJView()
    {
        Instantiate(CurrentPJData.projectileview);
    }
}

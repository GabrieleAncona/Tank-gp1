using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class ObstacleBase : MonoBehaviour, IObstacle
{
    /*private*/public ObstacleData obstacleData;
    private ObstacleGraphicController graphicCtrl;

    private List<DestructibleObstacleBase> destructibleObstacleBases = new List<DestructibleObstacleBase>(); 

    public virtual void Init(ObstacleData _obstacleData, ObstacleGraphicController _obstacleGraphicController)
    {
        obstacleData = _obstacleData;
        graphicCtrl = _obstacleGraphicController;

        //////////DUBBI///////////
        graphicCtrl.Init(obstacleData.Graphic);
        /////////////////////////

        destructibleObstacleBases = FindObjectsOfType<DestructibleObstacleBase>().ToList();

        foreach (DestructibleObstacleBase _DestrucOb in destructibleObstacleBases)
        {
            _DestrucOb.Init();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class DestructibleObstacleBase : ObstacleBase, IDamageable
{
    private ObstacleHealthController obstacleCtrl;

    #region Dubbi fuori UML
    public void Init() 
    {
        obstacleCtrl = FindObjectOfType<ObstacleHealthController>();
        obstacleCtrl.Init(obstacleData.Life);
    }

    #endregion

    public void TakeDamage(int _amount)
    {
        obstacleCtrl.LoseHealth(_amount);
    }
}

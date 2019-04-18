using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObstacleManager : MonoBehaviour
{
    #region Dubbi fuori UML
    public ObstacleData ObData;
    public ObstacleGraphicController ObGraphicController;
    #endregion
    private List<IObstacle> Ob = new List<IObstacle>(); // Perché IObstacle e non ObstacleBase?

    private List<ObstacleBase> Obases = new List<ObstacleBase>();

    
    public void Init()
    {
        Obases = FindObjectsOfType<ObstacleBase>().ToList();

        foreach (ObstacleBase _Ob in Obases)
        {
            _Ob.Init(ObData, ObGraphicController);
        }
    }

}

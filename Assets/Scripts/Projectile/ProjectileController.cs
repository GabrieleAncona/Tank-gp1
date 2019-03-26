using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    #region variables

    public int damage = 2;
    public TankData tank;

    #endregion

    private void Start()
    {
        tank = FindObjectOfType<TankData>();
    }

    #region API

    //controllo collisioni

    private void OnCollisionEnter(Collision other)
    {
        //se il proiettile colpisce un tank
        if (other.gameObject.GetComponent<TankData>())
        {
            //fai danno
            tank.Life = (tank.Life - damage); 

            //se la vita va a zero distruggi il tank
            if(tank.Life <= 0 && other.gameObject.GetComponent(typeof(IDestructable)))
            {
                other.gameObject.SetActive(false);
            }
        }

        //se colpisce un idamageble succederà qualcosa
        if (other.gameObject.GetComponent(typeof(IDamagable)))
        {

        }
    }
    #endregion

}

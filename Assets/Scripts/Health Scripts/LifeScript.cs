using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeScript : MonoBehaviour
{
    public int Life;
    private int LifeMax;

    public LifeScript(int LifeMax)
    {
        this.LifeMax = LifeMax;
        Life = LifeMax;
    }

    public int GetLife()
    {
        return Life;
    }

    public void Damage (int damageAmount)
    {
        Life -= damageAmount;
        if (Life < 0) Life = 0;
    }

    public void Heal (int healAmount)
    {
        Life += healAmount;
        if (Life > LifeMax) Life = LifeMax;
    }


}

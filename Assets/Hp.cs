using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public int maxHp;
    public int currentHp;

    private void Start()
    {
        currentHp = maxHp;
    }

    public void Damage(int damage)
    {
        currentHp -= damage;
        if (currentHp <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}

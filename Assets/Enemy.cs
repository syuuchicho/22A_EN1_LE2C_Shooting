using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Enemyの体力用変数
    private int enemyHp;
    void Start()
    {
        //生成時に体力を指定しておく
        enemyHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //もしも体力が0以下になったら
        if(enemyHp <= 0)
        {
            //自分で消える
            Destroy(this.gameObject);
        }
    }


    public void Damage()
    {
        enemyHp = enemyHp - 1;
        Debug.Log ("enemyHp" + enemyHp);
    }
}

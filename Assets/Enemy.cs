using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Enemy‚Ì‘Ì—Í—p•Ï”
    private int enemyHp;
    void Start()
    {
        //¶¬‚É‘Ì—Í‚ğw’è‚µ‚Ä‚¨‚­
        enemyHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //‚à‚µ‚à‘Ì—Í‚ª0ˆÈ‰º‚É‚È‚Á‚½‚ç
        if(enemyHp <= 0)
        {
            //©•ª‚ÅÁ‚¦‚é
            Destroy(this.gameObject);
        }
    }


    public void Damage()
    {
        enemyHp = enemyHp - 1;
        Debug.Log ("enemyHp" + enemyHp);
    }
}

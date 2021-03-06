using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMananager : MonoBehaviour
{
    // 敵の数を数える用の変数
    private GameObject[] enemy;

    //パネルを登録する
    public GameObject panel;

    void Start()
    {
        //パネルを隠す
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //シーンに存在しているEnemyタグを持っているオブジェクト
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        //シーンに1匹もEnemyがいなくなったら
        if(enemy.Length==0)
        {
            //パネルを表示する
            panel.SetActive(true);
        }
    }
}

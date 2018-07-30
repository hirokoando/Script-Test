﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    int mp = 53;

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");


        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }

}
public class Test : MonoBehaviour
{
    void Start()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 4; i >= 0 ; i--)
        {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss midboss = new Boss();
        midboss.Attack();
        midboss.Defence(5);
        for (int i = 0; i <= 10; i++)
        {
            midboss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

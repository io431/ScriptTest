using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int[] array = new int[5];
    private int mp = 53;
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力

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


    public void kadai()
    {

        array[0] = 1;
        array[1] = 3;
        array[2] = 5;
        array[3] = 7;
        array[4] = 9;

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int o = array.Length - 1; o >= 0; o--)
        {
            Debug.Log(array[o]);
        }


    }

    public void magic()
    {
        if (mp >= 5)
        {
            mp = mp - 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp +"。");

        }
        else {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
        

    }

}

public class Test : MonoBehaviour
{

    int[] array = new int[5];


    // Start is called before the first frame update
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        //新しく作った関数kadaiを呼び出す
        lastboss.kadai();
        //magic関数を11回呼び出す
        for (int i = 0; i < 11; i++)
        {
            lastboss.magic();
        }
    }





    // Update is called once per frame
    void Update()
    {

    }
}
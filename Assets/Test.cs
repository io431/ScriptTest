using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int[] array = new int[5];
    private int mp = 53;
    private int hp = 100;          // �̗�
    private int power = 25; // �U����

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
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
            Debug.Log("���@�U���������B�c��MP��" + mp +"�B");

        }
        else {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
        

    }

}

public class Test : MonoBehaviour
{

    int[] array = new int[5];


    // Start is called before the first frame update
    void Start()
    {
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);
        //�V����������֐�kadai���Ăяo��
        lastboss.kadai();
        //magic�֐���11��Ăяo��
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
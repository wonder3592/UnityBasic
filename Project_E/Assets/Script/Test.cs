
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int playerLevel = 10;
    bool test = true;
    private void Start()
    {
        name += "�����̸���";
        name += "���뿬";
        name += "�Դϴ�.";
        Debug.Log(name);
        Debug.Log($"���Ƿ�����{playerLevel}�Դϴ�.");
    }
    /* void OnEnable()
     {
         Random.InitState(1); //�õ尪���� ����������
         Debug.Log(Random.Range(1, 100));
         // 1 �̻� 100 �̸��� ������ ���� ����ڴ�.
     }

     /*�ּ��ޱ�*/
    /* public int gold = 0;
     public int name = 0;
    void Awake()
     {
         Debug.Log("���� �ѹ��� ����˴ϴ�.");
     }

     void OnEnable()
     {
         Debug.Log("Ȱ��ȭ �� �� ����˴ϴ�.");
     }
     void Start()
     {
         int playerLevel = 1;
         gold = 1;
         Debug.Log("�ѹ��� ����˴ϴ�.");
     }

     void Update()
     {
         gold = 1;
         Debug.Log("�� �����Ӹ��� ������ ����˴ϴ�.");
     }
 }
 //--------------------------------------------------
 public class Monster
 {
     Test test;

     void Attack()
     {
         test.gold = 0;
     }
 }
 public class Player
 {
     private int playerLevel = 10;

     public int Level()
     {
         return playerLevel;
     }
 }

 public class monster
 {
     private int monsterLevel;

     public void SetLevel(int _playerLevel)
     {
         monsterLevel = _playerLevel;
     }
 }

 public class Game
 {
     Player A;
     Monster B;

     void MonsterSpawn() // ����
     {
         B.SetLevel(A.Level());
     }*/
}
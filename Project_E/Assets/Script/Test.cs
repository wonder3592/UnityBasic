
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int playerLevel = 10;
    bool test = true;
    private void Start()
    {
        name += "나의이름은";
        name += "원대연";
        name += "입니다.";
        Debug.Log(name);
        Debug.Log($"나의레벨은{playerLevel}입니다.");
    }
    /* void OnEnable()
     {
         Random.InitState(1); //시드값설정 같은값나옴
         Debug.Log(Random.Range(1, 100));
         // 1 이상 100 미만의 랜덤한 값을 만들겠다.
     }

     /*주석달기*/
    /* public int gold = 0;
     public int name = 0;
    void Awake()
     {
         Debug.Log("최초 한번만 실행됩니다.");
     }

     void OnEnable()
     {
         Debug.Log("활성화 될 때 실행됩니다.");
     }
     void Start()
     {
         int playerLevel = 1;
         gold = 1;
         Debug.Log("한번만 실행됩니다.");
     }

     void Update()
     {
         gold = 1;
         Debug.Log("매 프레임마다 여러번 실행됩니다.");
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

     void MonsterSpawn() // 몬스터
     {
         B.SetLevel(A.Level());
     }*/
}
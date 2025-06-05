using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Study : MonoBehaviour
{
        private string myname = "원대연";
        private int age = 27;
        private float height = 200.9f;
        private string mbti = "INTP";
        private bool isStudent = true;
        private string  gender = "남자";
        private string hobby = "게임";
        private double weight = 60.5;
        private string favoriteColor = "파랑";
        private string hometown = "충청남도 당진";

    void Start()
        {
                SelfIntroduction();
        }
    public void SelfIntroduction()
    {
            Debug.Log($"저의 이름은 {myname}입니다.");
            Debug.Log($"저의 나이는 {age}살 입니다.");
            Debug.Log($"저의 MBTI는 {mbti}입니다.");
            Debug.Log($"저의 키는 {height}cm입니다.");
            Debug.Log($"저는 학생인가요? {isStudent}");
            Debug.Log($"저의 성별은 {gender}입니다.");
            Debug.Log($"저의 취미는 {hobby}입니다.");
            Debug.Log($"저의 몸무게는 {weight}kg입니다.");
            Debug.Log($"저의 좋아하는 색깔은 {favoriteColor}입니다.");
            Debug.Log($"저의 고향은 {hometown}입니다.");
    }
}


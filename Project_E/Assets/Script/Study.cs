using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Study : MonoBehaviour
{
        private string myname = "���뿬";
        private int age = 27;
        private float height = 200.9f;
        private string mbti = "INTP";
        private bool isStudent = true;
        private string  gender = "����";
        private string hobby = "����";
        private double weight = 60.5;
        private string favoriteColor = "�Ķ�";
        private string hometown = "��û���� ����";

    void Start()
        {
                SelfIntroduction();
        }
    public void SelfIntroduction()
    {
            Debug.Log($"���� �̸��� {myname}�Դϴ�.");
            Debug.Log($"���� ���̴� {age}�� �Դϴ�.");
            Debug.Log($"���� MBTI�� {mbti}�Դϴ�.");
            Debug.Log($"���� Ű�� {height}cm�Դϴ�.");
            Debug.Log($"���� �л��ΰ���? {isStudent}");
            Debug.Log($"���� ������ {gender}�Դϴ�.");
            Debug.Log($"���� ��̴� {hobby}�Դϴ�.");
            Debug.Log($"���� �����Դ� {weight}kg�Դϴ�.");
            Debug.Log($"���� �����ϴ� ������ {favoriteColor}�Դϴ�.");
            Debug.Log($"���� ������ {hometown}�Դϴ�.");
    }
}


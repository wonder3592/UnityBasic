using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArrayList : MonoBehaviour
{


    public TextMeshProUGUI Txt_Bumin;

    string[] character = { "������", "���ѳ�", "�ռ���", "����ȣ", "������", "������", "������", "������" };
    List<string> characterList = new List<string>();

    public void ArrayGacha() // character.Length
    {
        int randomValue = Random.Range(0, character.Length); // 8 , 0 ~ 7 �迭�� ũ��

        Debug.Log("������? " + character[randomValue] + "�� �����ϴ�.");
        Txt_Bumin.text = "������? " + character[randomValue] + "�� �����ϴ�.";
    }
    
    void Start()
    {
        characterList.Add("������");
        characterList.Add("���ѳ�");
        characterList.Add("�ռ���");
        characterList.Add("����ȣ");
        characterList.Add("������");
        characterList.Add("��ä��");
        characterList.Add("������");
        characterList.Add("������");
    }
    public void ListGacha() // characterList.Count
    {
        int randomValue = Random.Range(0, characterList.Count);  // 8 , 0 ~ 7
        Txt_Bumin.text = "������? " + characterList[randomValue] + "�� �����ϴ�.";
    }

    public void AddList()
    {
        // character �迭���� ��� �̸��� �ֽ��ϴ�.
        // characterList���� �ƹ� �����͵� �����ϴ�.

        // character �迭�� �����͸� charcterList���ٰ� �־��ִ� ���� �����ô�.
        // �츮�� ��� �ݺ����� ����ؼ� ����� ���ô�.

        for (int i = 0; i < character.Length; i++) // i < 8 -> 0 ~ 7
        {
            characterList.Add(character[i]);
        }

        for (int i = 0; i < characterList.Count; i++)
        {
            Debug.Log(characterList[i]);
        }
    }


    int[] numbers = new int[3];
    List<int> numberList = new List<int>();

}

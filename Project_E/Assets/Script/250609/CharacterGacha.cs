using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class CharacterGacha : MonoBehaviour
{
    public TextMeshProUGUI Txt_Gacha;

    public List<string> characterList = new List<string>();

    private string[] colorCharacters = { "�����Ӹ�", "�Ķ��Ӹ�", "��ȫ�Ӹ�" };

    public int selectNumbe = 0;

    private int count = 0; // ��ü ���� ī��Ʈ

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

    public void GachaTenPull()
    {
        string resultText = "=== 10���� ��� ===\n";

        for (int i = 0; i < 10; i++)
        {
            count++; // ���� ī��Ʈ ����

            if (count % 30 == 0)
            {
                string guaranteedCharacter = GetColorCharacter();
                resultText += $"[{count}ȸ��] [Ȯ��] {guaranteedCharacter}�� �̾Ҵ�!\n";
            }
            else
            {
                int randomValue = Random.Range(1, 101);
                string selectedCharacter = "";

                if (randomValue <= 5) // 5% Ȯ���� ����Ӹ�
                {
                    selectedCharacter = GetColorCharacter();
                }
                else
                {
                    selectedCharacter = GetNormalCharacter();
                }

                resultText += $"[{count}ȸ��] {selectedCharacter}�� �̾Ҵ�!\n";
            }
        }

        // ���� ���
        Txt_Gacha.text = resultText;
    }

    private string GetColorCharacter()
    {
        if (selectNumbe >= 0 && selectNumbe < colorCharacters.Length)
        {
            return colorCharacters[selectNumbe];
        }
        else
        {
            return "����Ӹ�";
        }
    }

    private string GetNormalCharacter()
    {
        int randomIndex = Random.Range(0, characterList.Count);
        return characterList[randomIndex];
    }
}
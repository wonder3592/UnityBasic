using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class CharacterGacha : MonoBehaviour
{
    public TextMeshProUGUI Txt_Gacha;

    public List<string> characterList = new List<string>();

    private string[] colorCharacters = { "<color=#FFFF00>안중재 강사님</color>", "<color=#FFFF00>양현석 강사님</color>", "<color=#FFFF00>김선민 강사님</color>" };

    public int selectNumbe = -1;

    private int count = 0; // 전체 누적 카운트

    void Start()
    {
        characterList.Add("정은교");
        characterList.Add("김한나");
        characterList.Add("손석현");
        characterList.Add("이윤호");
        characterList.Add("엄지성");
        characterList.Add("신채현");
        characterList.Add("차정훈");
        characterList.Add("최현석");
    }

    public void SelectSilver()
    {
        selectNumbe = 0;
        Txt_Gacha.text = "중재 티쳐 선택!";
        count = 0;
    }

    public void SelectBlue()
    {
        selectNumbe = 1;
        Txt_Gacha.text = "현석 티쳐 선택!";
        count = 0;
    }

    public void SelectPink()
    {
        selectNumbe = 2;
        Txt_Gacha.text = "선민 티쳐 선택!";
        count = 0;
    }


    public void GachaTenPull()
    {
        if (selectNumbe == -1)
        {
            Txt_Gacha.text = "원하는 강사님을 먼저 선택해주세요!";
            return;
        }
        string resultText = "=== 10연차 결과 ===\n";

        for (int i = 0; i < 10; i++)
        {
            count++; // 누적 카운트 증가

            if (count % 30 == 0)
            {
                string guaranteedCharacter = GetColorCharacter();
                resultText += $"[{count}회차] [확정] {guaranteedCharacter}를 뽑았다!\n";
            }
            else
            {
                int randomValue = Random.Range(1, 101);
                string selectedCharacter = "";

                if (randomValue <= 5) // 5% 확률로 색깔머리
                {
                    selectedCharacter = GetColorCharacter();
                }
                else
                {
                    selectedCharacter = GetNormalCharacter();
                }

                resultText += $"[{count}회차] {selectedCharacter}를 뽑았다!\n";
            }
        }

        // 최종 출력
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
            return "색깔머리";
        }
    }

    private string GetNormalCharacter()
    {
        int randomIndex = Random.Range(0, characterList.Count);
        return characterList[randomIndex];
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{
    public static InfoPanel Instance { get; private set; } = null;

    Text hungerText, costText;

    private void Start()
    {
        if (Instance != null)
        {
            Debug.LogError("InfoPanel already exists.");
            return;
        }
        Instance = this;
        hungerText = this.transform.GetChild(0).GetComponent<Text>();
        costText = this.transform.GetChild(1).GetComponent<Text>();
    }

    public void UpdateHungerAndCost()
    {
        hungerText.text ="����ֵ��" + PlayerInfo.Instance.resources.ToString();
        costText.text = "�����ջ����ļ���ֵ��" + PlayerInfo.Instance.currentRoundCostResources.ToString();
    }
}

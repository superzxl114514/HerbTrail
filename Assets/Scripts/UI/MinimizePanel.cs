using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

public class MinimizePanel : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    private bool _isPointerInside = false;   //ά��һ������ֵ ���жϵ�ǰ������ڲ�������ķ�Χ

    [SerializeField]
    AnimationCurve hideCurve;

    [SerializeField]
    Tile df;

    [SerializeField]
    float animationSpeed;

    public void OnPointerEnter(PointerEventData eventData)
    {
        _isPointerInside = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _isPointerInside = false;
    }
    IEnumerator HidePanel()
    {
        float timer = 0;
        while (timer <= 1)
        {
            Debug.Log(1);
            this.transform.localScale = Vector3.one * hideCurve.Evaluate(timer);
            timer += Time.deltaTime * animationSpeed * 2;
            yield return null;
        }

        Destroy(this.gameObject);
    }
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            Debug.Log(2);
            if (_isPointerInside == false && this.transform.localScale.x > 0.9 )
            {
                StartCoroutine(HidePanel());
            }
            //else
            //{
            //    gameObject.SetActive(false);    //��������������
            //                                    //Destroy(gameObject);    //��Ҳ����ɾ��
            //}
        }

    }
}

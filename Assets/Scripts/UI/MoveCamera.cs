using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public float speed = 5.0f;
    void Update()
    {

        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed; //�����ƶ�
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;   //ǰ���ƶ�
        transform.Translate(x, y,0);   //����ƶ�
    }
}

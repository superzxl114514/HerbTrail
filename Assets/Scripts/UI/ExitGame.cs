using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void OnExitGame()//����һ���˳���Ϸ�ķ���
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();//�����ڴ���ļ���
#endif
    }
}

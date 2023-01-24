using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance = null;
    public AudioSource efxSource;
    public float lowPitchRange = 0.95f;
    public float highPitchRange = 1.05f;

    [SerializeField]
    List<AudioClip> clips;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    //����ָ��������clip
    public void PlaySingle(ClipsType index)
    {
        efxSource.clip = clips[(int)index];
        efxSource.Play();
    }

    //��ָ���������б���clips�������������һ���������
    public void RandomizeSfx(params AudioClip[] clips)
    {
        int randomIndex = Random.Range(0, clips.Length);
        float randomPitch = Random.Range(lowPitchRange, highPitchRange);
        efxSource.clip = clips[randomIndex];
        efxSource.pitch = randomPitch;
        efxSource.Play();
    }
}

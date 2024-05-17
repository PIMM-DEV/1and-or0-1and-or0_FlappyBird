using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class bgMusic : MonoBehaviour
{
    [SerializeField] List<AudioClip> audioClips;
    [SerializeField] GameObject player;
    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        PlayRandomBgMusic();
    }
        
    void PlayRandomBgMusic()
    {
        int joker = Random.Range(0, 2);
        if (joker == 0)
        {
            audioSource.Play();
        }

        int index = Random.Range(0, 10);

        audioSource.PlayOneShot(audioClips[index]);
    }

    void Update()
    {
        KeepBgMusic();
    }

    void KeepBgMusic()
    {
        if (player.GetComponent<SkillCat>().skillOn)
        {
            return;
        }

        if (audioSource.isPlaying)
        {
            return;
        }

        PlayRandomBgMusic();
    }

    public void NormalToCatMusic()
    {
        player.transform.GetChild(0).transform.position = player.transform.GetChild(1).transform.position;
        audioSource.Pause();
        player.transform.GetChild(0).gameObject.GetComponent<AudioSource>().Play();
    }

    public void CatToNormalMusic()
    {
        player.transform.GetChild(1).transform.position = player.transform.GetChild(0).transform.position;
        audioSource.Play();
    }

    public void OnNaynCat()
    {
        if (player.GetComponent<SkillCat>().skillOn)
        {
            player.transform.GetChild(2).transform.position = player.transform.GetChild(1).transform.position;
        }
        else
        {
            player.transform.GetChild(2).transform.position = player.transform.GetChild(0).transform.position;
        }
        audioSource.mute = true;
        player.transform.GetChild(2).gameObject.GetComponent<AudioSource>().Play();
    }

    public void OffNaynCat()
    {
        player.transform.GetChild(0).transform.position = player.transform.GetChild(2).transform.position;
        player.transform.GetChild(1).transform.position = player.transform.GetChild(2).transform.position;
        audioSource.mute = false;
    }
}

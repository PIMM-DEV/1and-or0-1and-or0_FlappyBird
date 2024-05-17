using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillNyan : MonoBehaviour
{
    public bool skillOn, skillPossible;
    public float timer, cooltime, activeTime;

    [SerializeField] GameObject bgMusicObj, cat, bird, Nyan, pillarM, bgNyan, groundNayn, bgBird, groundBird;
    [SerializeField] Button NyanBtn;
    void Awake()
    {
        skillOn = false;
        skillPossible = true;
    }
    
    void Update()
    {
        if (!skillPossible)
        {
            timer += Time.deltaTime;
            
            //TODO: 버튼 채우기 쿨타임
            NyanBtn.gameObject.GetComponent<Image>().fillAmount = timer/cooltime;

            if (timer > activeTime && skillOn)
            {
                skillOn = false;

                // TODO: 음악 바꾸기
                bgMusicObj.GetComponent<bgMusic>().OffNaynCat();

                bird.SetActive(true);
                Nyan.SetActive(false);

                // 배경 바닥 바꾸기
                bgBird.SetActive(true);
                groundBird.SetActive(true);
                bgNyan.SetActive(false);
                groundNayn.SetActive(false);

                foreach (var pillar in pillarM.GetComponent<pillarManager>().pillars)
                {
                    pillar.GetComponent<Pillar>().speed /= 30; 
                    pillar.GetComponent<Pillar>().StreetlampToNormal();
                }
            }

            if (timer >= cooltime)
            {
                timer = 0;
                NyanBtn.interactable = true;
                skillPossible = true;
            }
        }   
    }

    public void NyanSkillBtn()
    {
        foreach (var pillar in pillarM.GetComponent<pillarManager>().pillars)
        {
            pillar.GetComponent<Pillar>().speed *= 30; 
            pillar.GetComponent<Pillar>().NormalToStreetlamp();
        }

        skillOn = true;
        skillPossible = false;

        // 배경 바닥 바꾸기
        bgBird.SetActive(false);
        groundBird.SetActive(false);
        bgNyan.SetActive(true);
        groundNayn.SetActive(true);

        // TODO: 캐릭터 바꾸기
        cat.SetActive(false);
        bird.SetActive(false);
        Nyan.SetActive(true);

        // TODO: 음악 바꾸기
        bgMusicObj.GetComponent<bgMusic>().OnNaynCat();

        // TODO: 버튼 쿨타임 처리
        NyanBtn.interactable = false;
    }
}

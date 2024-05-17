using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SkillCat : MonoBehaviour
{
    GameObject Cat, Bird;
    [SerializeField] float timer, cooltime, activeTime;
    public bool skillOn, skillPossible;
    [SerializeField] GameObject bgMusicObj, pillarManager;
    [SerializeField] Button catBtn;
    [SerializeField] GameObject bgBird, bgCat, GroudBird, GroundCat;
    
    void Awake()
    {
        skillOn = false;
        skillPossible = true;
        Cat = transform.GetChild(0).GameObject();
        Bird = transform.GetChild(1).GameObject();
    }
    
    void Update()
    {
        if (!skillPossible)
        {
            timer += Time.deltaTime;
            
            //TODO: 버튼 채우기 쿨타임
            catBtn.gameObject.GetComponent<Image>().fillAmount = timer/cooltime;

            if (timer > activeTime && skillOn)
            {
                foreach (var pillar in pillarManager.GetComponent<pillarManager>().pillars)
                {
                    pillar.GetComponent<Pillar>().IceToNormal();
                }

                bgBird.SetActive(true);
                bgCat.SetActive(false);
                GroudBird.SetActive(true);
                GroundCat.SetActive(false);
                skillOn = false;

                // TODO: 음악 바꾸기
                bgMusicObj.GetComponent<bgMusic>().CatToNormalMusic();

                Cat.SetActive(false);
                Bird.SetActive(true);
            }

            if (timer >= cooltime)
            {
                timer = 0;
                catBtn.interactable = true;
                skillPossible = true;
            }
        }   
    }

    public void CatBtn()
    {
        foreach (var pillar in pillarManager.GetComponent<pillarManager>().pillars)
        {
            pillar.GetComponent<Pillar>().normalToIce();
        }
        

        bgBird.SetActive(false);
        bgCat.SetActive(true);
        GroudBird.SetActive(false);
        GroundCat.SetActive(true);

        skillOn = true;
        skillPossible = false;

        // TODO: 캐릭터 바꾸기
        Cat.SetActive(true);
        Bird.SetActive(false);

        // TODO: 음악 바꾸기
        bgMusicObj.GetComponent<bgMusic>().NormalToCatMusic();

        // TODO: 버튼 쿨타임 처리
        catBtn.interactable = false;
    }
}

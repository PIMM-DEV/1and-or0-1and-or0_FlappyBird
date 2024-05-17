using System.Collections.Generic;
using UnityEngine;

public class pillarManager : MonoBehaviour
{
    [SerializeField] int index;
    [SerializeField] float respawnTimeMin, respawnTimeMax, time, term;
    [SerializeField] GameObject pillerObj;
    public List<GameObject> pillars;

    void Awake()
    {
        PreSpawnPillars();
    }

    void PreSpawnPillars()
    {
        for (int i = 0; i<20; i++)
        {
            GameObject temp = Instantiate(pillerObj, transform, true);
            pillars.Add(temp);
            temp.SetActive(false);
        }
    }

    void Update()
    {   
        if (time == 0)
        {
            reset_term();
        }
        time += Time.deltaTime;
        
        if (time >= term)
        {
            vaildIndex();
            pillars[index++].SetActive(true);
            time = 0;
            reset_term(); 
        }
    }

    void vaildIndex()
    {
        if (index == pillars.Count)
        {
            index = 0;
        }
    }

    void reset_term()
    {
        term = Random.Range(respawnTimeMin, respawnTimeMax);
    }
}

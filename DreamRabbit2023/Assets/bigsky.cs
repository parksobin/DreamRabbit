using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigsky : MonoBehaviour
{
    public GameObject sky1;
    public GameObject heart;
    public GameObject skyOutZone;
    float randomnum;
    float HeartYrandomNum;

    public float timeleaf;
    float Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > timeleaf)
        {
            randomnum = Random.Range(-8, 4);
            HeartYrandomNum = Random.Range(1.5f, 4);

            GameObject newheart = Instantiate(heart);
            GameObject newsky1 = Instantiate(sky1);
            GameObject newskyOutZone = Instantiate(skyOutZone);

            newsky1.transform.position = new Vector3(11, randomnum , 0);
            newskyOutZone.transform.position = new Vector3(11, randomnum, 0);
            newheart.transform.position = 
            new Vector3(Random.Range(7.2f, 13), randomnum + HeartYrandomNum, 0);
            
            Timer = 0;
            Destroy(newsky1, 8);
            Destroy(newskyOutZone, 8);
            Destroy(newheart, 8);


            newheart.SetActive(true);
        }
        
    }

    
}

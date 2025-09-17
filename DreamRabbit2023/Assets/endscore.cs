using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endscore : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<Text>().text = score1.score2.ToString();
    }
}

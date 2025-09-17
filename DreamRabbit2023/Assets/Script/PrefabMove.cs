using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMove : MonoBehaviour
{
    public GameObject prefab;
    public GameObject prefab_rock;

    void Start()
    {
        InvokeRepeating("makeMonPrefab", 2f, 2.3f);
        InvokeRepeating("makeRock", 2f, 2.3f);
    }

    void Update()
    {
        
    }

    void makeRock()
    {
        prefab_rock.transform.position = new Vector2(10f, -2.0f);
        Instantiate(prefab_rock, prefab_rock.transform.position, prefab_rock.transform.rotation);
    }

    void makeMonPrefab()
    {
        prefab.transform.position = new Vector2(10f, -2.0f);
        Instantiate(prefab, prefab.transform.position, prefab.transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V1 : MonoBehaviour
{
    [System.NonSerialized] public GameObject v2;
    // Start is called before the first frame update
    void Start()
    {
        v2?.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

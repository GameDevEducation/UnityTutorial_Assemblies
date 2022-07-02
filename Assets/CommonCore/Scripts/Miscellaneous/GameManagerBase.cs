using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerBase : MonoBehaviour
{
    // Start is called before the first frame update
    protected virtual void Start()
    {
#if UNITYVER_2022
        Debug.Log("I Ran!");
#endif // UNITYVER_2022

    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicScript : MonoBehaviour
{
    private BackgroundMusicScript instance;
    private BackgroundMusicScript() { }
    // Start is called before the first frame update

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}

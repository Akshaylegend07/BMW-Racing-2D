using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
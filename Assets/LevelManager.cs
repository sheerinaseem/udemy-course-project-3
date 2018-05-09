using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name)
    {
        Debug.Log("Level load requested for " + name);
        #pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(name);
        #pragma warning restore CS0618 // Type or member is obsolete
    }

    public void QuitRequest()
    {
        Debug.Log("I wanna quit.");
        Application.Quit();
    }
}

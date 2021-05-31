using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{

    public enum Scene
    {
        FirstScene, Scene2, Scene3, Scene4,
        Loading = 100
    }

    public static void Load(Scene scene)
    {
        //SceneManager.LoadScene(Scene.Loading.ToString());

        SceneManager.LoadScene(scene.ToString());
    }
}

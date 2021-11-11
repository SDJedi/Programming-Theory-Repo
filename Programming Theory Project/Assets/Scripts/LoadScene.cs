using UnityEngine;
using UnityEngine.SceneManagement;

//simple class to load a scene at runtime
public class LoadScene : MonoBehaviour
{
    //call via btn click; hook up in inspector
    public void LoadGameScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
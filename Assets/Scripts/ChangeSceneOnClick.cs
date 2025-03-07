using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnClick : MonoBehaviour
{
    
  public string sceneName;

    public void ChangeScene()
    {
      SceneManager.LoadScene(sceneName);    
    }

    // Tee samanlainen scripti, mikä vaihtaa sceneä triggeristä.
}

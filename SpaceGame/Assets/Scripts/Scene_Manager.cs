using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
   public string Mercury;
   public string Venus;
   public string Mars;
   public string Earth;

    public void LoadMercury()
    {
        SceneManager.LoadScene(Mercury);
    }

    public void LoadVenus()
    {
        SceneManager.LoadScene(Venus);
    }

    public void LoadEarth()
    {
        SceneManager.LoadScene(Earth);
    }

    public void LoadMars()
    {
        SceneManager.LoadScene(Mars);
    }
}

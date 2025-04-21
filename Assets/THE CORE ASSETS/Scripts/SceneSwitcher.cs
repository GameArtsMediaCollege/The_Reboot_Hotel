using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string nextlevel;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(nextlevel, LoadSceneMode.Single);
    }
}

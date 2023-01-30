using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    public Button switchButton;

    private void Start()
    {
        switchButton.onClick.AddListener(SwitchScene);
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene(0);
    }
}

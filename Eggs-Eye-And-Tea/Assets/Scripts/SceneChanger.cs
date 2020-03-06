using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

    public Animator animator;

    public int sceneToLoad;

    // Update is called once per frame
    void Update ()
    {
		if (GameObject.Find("Character Designn").GetComponent<MainCharacter>().trigger == true)
        {
            FadeToLevel(sceneToLoad);
        }
	}

    public void FadeToLevel (int NextScene)
    {
        sceneToLoad = NextScene;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete ()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAnimation : MonoBehaviour
{
    public GameObject defaultAnim1;
    public GameObject runAnim1;
    public GameObject dieAnim1;
    public GameObject eatAnim1;
    public AudioSource audioSource1;
    public Button audioButton1;
    public GameObject defaultAnim2;
    public GameObject runAnim2;
    public GameObject dieAnim2;
    public GameObject eatAnim2;
    public AudioSource audioSource2;
    public Button audioButton2;
    public GameObject defaultAnim3;
    public GameObject runAnim3;
    public GameObject dieAnim3;
    public GameObject eatAnim3;
    public AudioSource audioSource3;
    public Button audioButton3;
    public GameObject defaultAnim4;
    public GameObject runAnim4;
    public GameObject dieAnim4;
    public GameObject eatAnim4;
    public AudioSource audioSource4;
    public Button audioButton4;
    public GameObject defaultAnim5;
    public GameObject runAnim5;
    public GameObject dieAnim5;
    public GameObject eatAnim5;
    public AudioSource audioSource5;
    public Button audioButton5;
    public GameObject defaultAnim6;
    public GameObject runAnim6;
    public GameObject dieAnim6;
    public GameObject eatAnim6;
    public AudioSource audioSource6;
    public Button audioButton6;
    public GameObject defaultAnim7;
    public GameObject runAnim7;
    public GameObject dieAnim7;
    public GameObject eatAnim7;
    public AudioSource audioSource7;
    public Button audioButton7;
    private bool isAudioPlaying = false;

    private void Start()
    {
        audioButton1.onClick.AddListener(ToggleAudio1);
        audioButton2.onClick.AddListener(ToggleAudio2);
        audioButton3.onClick.AddListener(ToggleAudio3);
        audioButton4.onClick.AddListener(ToggleAudio4);
        audioButton5.onClick.AddListener(ToggleAudio5);
        audioButton6.onClick.AddListener(ToggleAudio6);
        audioButton7.onClick.AddListener(ToggleAudio7);
    }

    public void OpenRun1()
    {
        SetActiveAnimation1(runAnim1);
    }

    public void OpenDie1()
    {
        SetActiveAnimation1(dieAnim1);
    }

    public void OpenEat1()
    {
        SetActiveAnimation1(eatAnim1);
    }

    public void DefaultAnimation1()
    {
        SetActiveAnimation1(defaultAnim1);
    }

    private void SetActiveAnimation1(GameObject animationObject)
    {
        defaultAnim1.SetActive(false);
        runAnim1.SetActive(false);
        dieAnim1.SetActive(false);
        eatAnim1.SetActive(false);

        animationObject.SetActive(true);
    }
 private void ToggleAudio1()
    {
        if (isAudioPlaying)
        {
            audioSource1.Stop();
        }
        else
        {
            audioSource1.Play();
        }
        isAudioPlaying = !isAudioPlaying;
    }


// -------------------------2-------------------------------
    public void OpenRun2()
    {
        SetActiveAnimation2(runAnim2);
    }

    public void OpenDie2()
    {
        SetActiveAnimation2(dieAnim2);
    }

    public void OpenEat2()
    {
        SetActiveAnimation2(eatAnim2);
    }

    public void DefaultAnimation2()
    {
        SetActiveAnimation2(defaultAnim2);
    }

    private void SetActiveAnimation2(GameObject animationObject)
    {
        defaultAnim2.SetActive(false);
        runAnim2.SetActive(false);
        dieAnim2.SetActive(false);
        eatAnim2.SetActive(false);

        animationObject.SetActive(true);
    }


 private void ToggleAudio2()
    {
        if (isAudioPlaying)
        {
            audioSource2.Stop();
        }
        else
        {
            audioSource2.Play();
        }
        isAudioPlaying = !isAudioPlaying;
    }

//------------------------------3----------------------------
      public void OpenRun3()
    {
        SetActiveAnimation3(runAnim3);
    }

    public void OpenDie3()
    {
        SetActiveAnimation3(dieAnim3);
    }

    public void OpenEat3()
    {
        SetActiveAnimation3(eatAnim3);
    }

    public void DefaultAnimation3()
    {
        SetActiveAnimation3(defaultAnim3);
    }

    private void SetActiveAnimation3(GameObject animationObject)
    {
        defaultAnim3.SetActive(false);
        runAnim3.SetActive(false);
        dieAnim3.SetActive(false);
        eatAnim3.SetActive(false);

        animationObject.SetActive(true);
    }


 private void ToggleAudio3()
    {
        if (isAudioPlaying)
        {
            audioSource3.Stop();
        }
        else
        {
            audioSource3.Play();
        }
        isAudioPlaying = !isAudioPlaying;
    }
//------------------------------4----------------------------
      public void OpenRun4()
    {
        SetActiveAnimation4(runAnim4);
    }

    public void OpenDie4()
    {
        SetActiveAnimation4(dieAnim4);
    }

    public void OpenEat4()
    {
        SetActiveAnimation4(eatAnim4);
    }

    public void DefaultAnimation4()
    {
        SetActiveAnimation4(defaultAnim4);
    }

    private void SetActiveAnimation4(GameObject animationObject)
    {
        defaultAnim4.SetActive(false);
        runAnim4.SetActive(false);
        dieAnim4.SetActive(false);
        eatAnim4.SetActive(false);

        animationObject.SetActive(true);
    }


 private void ToggleAudio4()
    {
        if (isAudioPlaying)
        {
            audioSource4.Stop();
        }
        else
        {
            audioSource4.Play();
        }
        isAudioPlaying = !isAudioPlaying;
    }
 
   

//------------------------------5----------------------------
      public void OpenRun5()
    {
        SetActiveAnimation5(runAnim5);
    }

    public void OpenDie5()
    {
        SetActiveAnimation5(dieAnim5);
    }

    public void OpenEat5()
    {
        SetActiveAnimation5(eatAnim5);
    }

    public void DefaultAnimation5()
    {
        SetActiveAnimation5(defaultAnim5);
    }

    private void SetActiveAnimation5(GameObject animationObject)
    {
        defaultAnim5.SetActive(false);
        runAnim5.SetActive(false);
        dieAnim5.SetActive(false);
        eatAnim5.SetActive(false);

        animationObject.SetActive(true);
    }


 private void ToggleAudio5()
    {
        if (isAudioPlaying)
        {
            audioSource5.Stop();
        }
        else
        {
            audioSource5.Play();
        }
        isAudioPlaying = !isAudioPlaying;
    }
 
//------------------------------6----------------------------
      public void OpenRun6()
    {
        SetActiveAnimation6(runAnim6);
    }

    public void OpenDie6()
    {
        SetActiveAnimation6(dieAnim6);
    }

    public void OpenEat6()
    {
        SetActiveAnimation6(eatAnim6);
    }

    public void DefaultAnimation6()
    {
        SetActiveAnimation6(defaultAnim6);
    }

    private void SetActiveAnimation6(GameObject animationObject)
    {
        defaultAnim6.SetActive(false);
        runAnim6.SetActive(false);
        dieAnim6.SetActive(false);
        eatAnim6.SetActive(false);

        animationObject.SetActive(true);
    }


 private void ToggleAudio6()
    {
        if (isAudioPlaying)
        {
            audioSource6.Stop();
        }
        else
        {
            audioSource6.Play();
        }
        isAudioPlaying = !isAudioPlaying;
    }
//------------------------------7----------------------------
      public void OpenRun7()
    {
        SetActiveAnimation7(runAnim7);
    }

    public void OpenDie7()
    {
        SetActiveAnimation7(dieAnim7);
    }

    public void OpenEat7()
    {
        SetActiveAnimation7(eatAnim7);
    }

    public void DefaultAnimation7()
    {
        SetActiveAnimation7(defaultAnim7);
    }

    private void SetActiveAnimation7(GameObject animationObject)
    {
        defaultAnim7.SetActive(false);
        runAnim7.SetActive(false);
        dieAnim7.SetActive(false);
        eatAnim7.SetActive(false);

        animationObject.SetActive(true);
    }


 private void ToggleAudio7()
    {
        if (isAudioPlaying)
        {
            audioSource7.Stop();
        }
        else
        {
            audioSource7.Play();
        }
        isAudioPlaying = !isAudioPlaying;
    }
}

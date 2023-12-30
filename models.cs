using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject model1;
    public GameObject model2;
    public GameObject model3;
    public GameObject model4;
    public GameObject model5;
    public GameObject model6;

    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public GameObject image6;

    // Function to handle button click
    public void OnButtonClick(int index)
    {
        // Deactivate all models and images
        DeactivateAll();

        // Activate the selected model and image
        switch (index)
        {
            case 0:
                model1.SetActive(true);
                image1.SetActive(true);
                break;

            case 1:
                model2.SetActive(true);
                image2.SetActive(true);
                break;

            case 2:
                model3.SetActive(true);
                image3.SetActive(true);
                break;
            case 3:
                model4.SetActive(true);
                image4.SetActive(true);
                break;
            case 4:
                model5.SetActive(true);
                image5.SetActive(true);
                break;
            case 5:
                model6.SetActive(true);
                image6.SetActive(true);
                break;

            default:
                Debug.LogError("Invalid button index");
                break;
        }
    }

    private void DeactivateAll()
    {
        model1.SetActive(false);
        model2.SetActive(false);
        model3.SetActive(false);
        model4.SetActive(false);
        model5.SetActive(false);
        model6.SetActive(false);



        image1.SetActive(false);
        image2.SetActive(false);
        image3.SetActive(false);
        image4.SetActive(false);
        image5.SetActive(false);
        image6.SetActive(false);
    }
}

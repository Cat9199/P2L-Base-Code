using UnityEngine;
using UnityEngine.Android;

public class ScreenshotButton : MonoBehaviour
{
    public void TakeScreenshot()
    {
        string timeStamp = System.DateTime.Now.ToString("yyyyMMddHHmmss");
        string fileName = "AR_Screenshot_" + timeStamp + ".png";
        string filePath = Application.persistentDataPath + "/" + fileName;

        if (Permission.HasUserAuthorizedPermission(Permission.ExternalStorageWrite))
        {
            // You have permission to write to external storage.
            ScreenCapture.CaptureScreenshot(filePath);
            Debug.Log("Screenshot saved to: " + filePath);
        }
        else
        {
            // Request permission from the user.
            Permission.RequestUserPermission(Permission.ExternalStorageWrite);
        }
    }
}

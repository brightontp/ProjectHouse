using UnityEngine;
using UnityEngine.UI;
public class InterTextTesting : MonoBehaviour
{
    int n;
    public Text myText;
    public void OnButtonPress()
    {
        n++;
        myText.text = "Button clicked " + n + " times.";
    }
}
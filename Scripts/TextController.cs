using UnityEngine;

public class TextController : MonoBehaviour {
    public TMPro.TMP_Text txt;

    public void SetText(string str) {
        txt.text = str;
    }
}

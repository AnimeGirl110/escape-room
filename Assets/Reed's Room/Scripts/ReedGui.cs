
using UnityEngine;
using UnityEngine.UI;

namespace Reed
{
  public class ReedGui : MonoBehaviour
  {
    Text m_Text;
    private ReedPlayerBehavior playerScript;
    public GameObject player;


    void Start()
    {
      m_Text = GetComponent<Text>();
      playerScript = player.GetComponent<ReedPlayerBehavior>();
      m_Text.alignment = TextAnchor.LowerCenter;
    }

    //This is a legacy function used for an instant demonstration. See the UI Tutorials pages  and UI Section of the manual for more information on creating your own buttons etc.
    void OnGUI()
    {
      m_Text.text = "";
      if (playerScript.isShowingGui)
      {
        m_Text.text = playerScript.guiText;
        m_Text.color = Color.white;
      }
    }
  }
}
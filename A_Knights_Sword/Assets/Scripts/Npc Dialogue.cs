using UnityEngine;
using TMPro;

public class NpcDialogue : MonoBehaviour
{
    public GameObject d_template;
    public GameObject canva;
   // bool player_detection = false;


    // Update is called once per frame
    void Update()
    {
       // if(player_detection && Input.GetKeyDown(KeyCode.E) && !Player.dialogue)
        {
            canva.SetActive(true);
            //Player.dialogue = true;
            NewDialogue("Hi");
            NewDialogue("How are you?");
            NewDialogue("Is there anything I can do for you?");
            canva.transform.GetChild(1).gameObject.SetActive(true);
        }
    }

    void NewDialogue(string text)
    {
        GameObject template_clone = Instantiate(d_template, canva.transform);
        template_clone.transform.parent = canva.transform;
        template_clone.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = text;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
         //   player_detection = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
           // player_detection = false;
        }
    }
}

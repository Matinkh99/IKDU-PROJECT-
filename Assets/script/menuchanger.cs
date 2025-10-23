using UnityEngine;

public class menuchanger : MonoBehaviour
{
    public GameObject foodpanel;
    public GameObject videopanel;
    public GameObject mathpanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void changethat(string nameofpanel)
    {
        videopanel.SetActive(nameofpanel == "videoPanel");
        mathpanel.SetActive(nameofpanel == "mathPanel");
        foodpanel.SetActive(nameofpanel == "foodPanel");

    }
}

using UnityEngine;
using TMPro;
public class math : MonoBehaviour
{
    public TextMeshProUGUI ourtext;
    private int startingNumber = 0;
    private int currentNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ourtext.text = startingNumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void addNumber(int numberToAdd)
    {

        currentNumber = currentNumber + numberToAdd;
        ourtext.text = currentNumber.ToString();

    }
    public void minusNumber(int numberToMinus)
    {
        currentNumber = currentNumber - numberToMinus;
        ourtext.text = currentNumber.ToString();
    }
}

using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 30f; // Default rotation speed.
    public Button increaseButton; // Reference to the UI Button for increasing speed.
    public Button decreaseButton; // Reference to the UI Button for decreasing speed.
    public Button Aupbutton;
    public Button Bdownbutton;
    private float rspeed = 11f;
    void Start()
    {
        // Add click listeners to the buttons.
        increaseButton.onClick.AddListener(IncreaseSpeed);
        decreaseButton.onClick.AddListener(DecreaseSpeed);
        Aupbutton.onClick.AddListener(Aup);
        Bdownbutton.onClick.AddListener(Bdown);
    }

    void Update()
    {
        // Rotate the object around its own local Y-axis constantly.
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right,rspeed);
        rspeed = 0f;
    }

    void IncreaseSpeed()
    {
        rotationSpeed += 10f; // Increase rotation speed by 10 units.
    }

    void DecreaseSpeed()
    {
        rotationSpeed -= 10f; // Decrease rotation speed by 10 units.
        if (rotationSpeed < 0f) rotationSpeed = 0f; // Make sure the speed doesn't go negative.
    }
    void Aup()
    {
        rspeed = 11f;
    }
    void Bdown()
    {
        rspeed = -11f;
    }
}

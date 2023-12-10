
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    // Update is called once per frame
    public Transform player;
    public TextMeshProUGUI scoreText;
    void Update()
    {
        scoreText.text=player.position.z.ToString("0");
    }
}

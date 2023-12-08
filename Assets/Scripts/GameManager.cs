using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text firstPlayerScore;
    public Text secondPlayerScore;
    public Ball ballMovement;

    private int m_first_player_score;
    private int m_second_player_score;

    public void IncreaseFirstPlayerScore()
    {
        m_first_player_score++;
        firstPlayerScore.text = m_first_player_score.ToString();
        ballMovement.ResetPosition(); 
    }

    public void IncreaseSecondPlayerScore()
    {
        m_second_player_score++;
        secondPlayerScore.text = m_second_player_score.ToString();
        ballMovement.ResetPosition(); 
    }
}

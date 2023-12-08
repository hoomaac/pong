using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text firstPlayerScore;
    public Text secondPlayerScore;
    public Ball ballMovement;

    private int _first_player_score;
    private int _second_player_score;

    public void IncreaseFirstPlayerScore()
    {
        _first_player_score++;
        firstPlayerScore.text = _first_player_score.ToString();
        ballMovement.ResetPosition();
    }

    public void IncreaseSecondPlayerScore()
    {
        _second_player_score++;
        secondPlayerScore.text = _second_player_score.ToString();
        ballMovement.ResetPosition();
    }
}

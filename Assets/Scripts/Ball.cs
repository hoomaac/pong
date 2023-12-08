using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed = 100.0f;
    private Rigidbody2D m_rigidbody;
    private AudioSource m_audioSource;

    [SerializeField] private float m_count;
    [SerializeField] private Text m_countDownText;
    [SerializeField] private GameObject m_countDownCanvas;


    private void Awake()
    {
        m_rigidbody = GetComponent<Rigidbody2D>();        
        m_audioSource = GetComponent<AudioSource>();

        m_countDownCanvas.SetActive(true);
    }

    void Start()
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        while (m_count > 0)
        {
            m_countDownText.text = m_count.ToString();
            yield return new WaitForSeconds(1);
            m_count--;
        }
        
        m_countDownCanvas.SetActive(false);
        ResetPosition();
    }

    private void AddInitForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        Vector2 position = new Vector2(x, y);
        m_rigidbody.AddForce(position * speed);
    }
    
    public void AddForce(Vector2 force)
    {
        m_rigidbody.AddForce(force);
    }

    public void ResetPosition()
    {
        m_rigidbody.position = Vector3.zero; 
        m_rigidbody.velocity = Vector3.zero;
        AddInitForce();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        m_audioSource.Play();
    }
}

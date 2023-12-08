using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed = 100.0f;
    private Rigidbody2D _rigidbody;
    private AudioSource _audioSource;

    [SerializeField] private float _count;
    [SerializeField] private Text _countDownText;
    [SerializeField] private GameObject _countDownCanvas;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();

        _countDownCanvas.SetActive(true);
    }

    private void Start()
    {
        StartCoroutine(CountDown());
    }

    private IEnumerator CountDown()
    {
        while (_count > 0)
        {
            _countDownText.text = _count.ToString();
            yield return new WaitForSeconds(1);
            _count--;
        }

        _countDownCanvas.SetActive(false);
        ResetPosition();
    }

    private void AddInitForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        Vector2 position = new(x, y);
        _rigidbody.AddForce(position * speed);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }

    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
        AddInitForce();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _audioSource.Play();
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class SimplePlayer : MonoBehaviour
{
    public int moeda = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            transform.position += Vector3.up;
        }

        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            transform.position += Vector3.right;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
            {
                if (other.CompareTag("Coin"))
                {
                    moeda++;
                    Destroy(other.gameObject);
                }
            }
        }
    



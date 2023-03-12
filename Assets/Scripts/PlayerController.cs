using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float speed;
    public GameObject respawnPoint;
    public GameObject respawnUI;
    public GameObject pauseUI;
    public GameObject result;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !result.activeInHierarchy)
        {
            Debug.Log("pause");
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pauseUI.SetActive(true);
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                pauseUI.SetActive(false);
            }
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movementX = Camera.main.transform.right * moveHorizontal;
        Vector3 movementZ = Camera.main.transform.forward * moveVertical;
        Vector3 movement = movementX + movementZ;

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("cube"))
        {
            SoundManager.PlaySound("HitTheCube");
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("water"))
        {
            Debug.Log("oops");
            StartCoroutine(RespawnPlayer());
        }
    }

    IEnumerator RespawnPlayer()
    {
        respawnUI.SetActive(true);
        yield return new WaitForSeconds(3);
        transform.position = respawnPoint.transform.position;
        rb.angularVelocity = Vector3.zero;
        rb.Sleep();
        respawnUI.SetActive(false);
    }
}

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 10000f;
    public float NOS = 5000f;
    public float slow = -2000f;
    public int Score = 0;
    public Text scoreText;
    public Text gameOverScoreText;
    public Text nextLevelScoreText;
    public GameObject gameOverPanel;
    public GameObject nextLevelPanel;
    private Vector3 mOffset;
    private float mZCoord;

    public GameObject bombparticle;
    public AudioSource bombSound;


    // Start is called before the first frame update
    void Start()
    {
        nextLevelPanel.SetActive(false);
        gameOverPanel.SetActive(false); 
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Score.ToString();
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Score < 0)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
            Score = 0;
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, sidewaysForce * Time.deltaTime, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -sidewaysForce * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(0,0, NOS * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            rb.AddForce(0, 0, slow * Time.deltaTime);
        }


    }
    /*
    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToViewportPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }
    */
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("blue") ){
            Score++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("red"))
        {
            Score--;
            GameObject temp = Instantiate(bombparticle);
            temp.transform.position = collision.gameObject.transform.position;
            Destroy(temp.gameObject, 3);
            Destroy(collision.gameObject);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("finish"))
        {
            nextLevelScoreText.text = Score.ToString();
            nextLevelPanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("gameover"))
        {
            gameOverScoreText.text = Score.ToString();
            Time.timeScale = 0;

            gameOverPanel.SetActive(true);
        }
    }
}

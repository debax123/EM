using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TiltBall : MonoBehaviour
{
    public ParticleSystem dust;
    public Button pauseB;
    //public Animator anim1;
    //public ParticleSystem dust;
    float speed = 1f;
    //public AudioSource BallRollSounds;
    public AudioSource soundTrack;

    public AudioSource ballHit;
    private float timer;
    public float moveSpeedModifier = 0.5f;
    private float dirX, dirY;
    private Vector3 PreviousPosition;
    [SerializeField] private Animator anim;
    [SerializeField] private Animator animVictory;
    public Rigidbody2D rb; 
    [Range(0.2f, 2f)]
    static bool BallLife;
    public static bool isPaused;

    private void Start()
    {
        isPaused = false;
    }


    void Update()
    {
        dirX = Input.acceleration.x * moveSpeedModifier;
        dirY = Input.acceleration.y * moveSpeedModifier;
    }

    void FixedUpdate()
    {
        if (isPaused == false)
        {
            rb.velocity = new Vector2(rb.velocity.x + dirX, rb.velocity.y + dirY);
            //BallRollSounds.volume = rb.velocity.magnitude / speed;
            /*if (PreviousPosition == transform.position && BallRollSounds.isPlaying == false)
            {
                BallRollSounds.Play();
            }*/
            PreviousPosition = transform.position;
        }
        if (isPaused)
        {
            //BallRollSounds.Stop();
            rb.velocity = new Vector2(0, 0);
        }
    }

    ///////////////   COLLISION   ///////////////
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hole"))
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            dust.Stop();
            pauseB.enabled = false;
            //BallRollSounds.volume = 0;
            ballHit.volume = 0;
            anim.SetBool("BallLives", true);
            animVictory.SetBool("Victory", true);
            rb.velocity = new Vector2(0, 0);
            rb.angularVelocity = 0;
            soundTrack.Stop();
            WinSound.PlayWinSound();
            rb.isKinematic = true;
        }
        if (collision.CompareTag("NotHole"))
        {
            anim.SetBool("BallLives", true);
            rb.velocity = new Vector2(0, 0);
            StartCoroutine(replay());
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(BallHittingSound());
    }
    //////////////////////////////////////////////////////


    ///////////////   ENUMERATORS   ///////////////
    public IEnumerator BallHittingSound()
    {
        ballHit.Play();
        //BallRollSounds.Pause();
        yield return new WaitForSeconds(0.1f);
        //BallRollSounds.UnPause();
    }
    public IEnumerator replay()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level4");
    }
    //////////////////////////////////////////////////////


    ///////////////   PAUSE&RESUME   ///////////////
    public void Pause()
    {
        isPaused = true;
    }
    public void Resume()
    {
        isPaused = false;
    }
}
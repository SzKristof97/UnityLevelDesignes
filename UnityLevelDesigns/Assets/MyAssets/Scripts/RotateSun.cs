using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSun : MonoBehaviour
{
    enum TIME
    {
        DAY,
        AFTERNOON,
        MORNING,
        NIGHT
    }

    public float rotateSpeed = 1f;

    [Header("Day/Night time settings")]
    public float DayTimeStart = 0f;
    public float AfterNoonTimeStart = 0f;
    public float MorningTimeStart = 0f;
    public float NightTimeStart = 0f;

    [Header("Fog settings")]
    public float DayFog = 3000f;
    public float AfterNoonFog = 500f;
    public float NightFog = 350f;

    [Header("Fog Colors")]
    public Color DayTimeFogColor = Color.white;
    public Color AfterNoonFogColor = Color.gray;
    public Color NightFogColor = Color.black;

    [SerializeField]
    private TIME _currentTime = TIME.AFTERNOON;
    private float _currentFog = 5000f;

    void Update()
    {
        transform.Rotate(Vector3.left * rotateSpeed * Time.deltaTime);

        CheckTime();
    }

    private void CheckTime()
    {
        Debug.Log("Rotation: " + transform.eulerAngles);
        if (transform.eulerAngles.x <= AfterNoonTimeStart)
        {
            _currentTime = TIME.AFTERNOON;
        }
        else if(transform.eulerAngles.x <= DayTimeStart)
        {
            _currentTime = TIME.DAY;
        }
        else if (transform.eulerAngles.x <= MorningTimeStart)
        {
            _currentTime = TIME.MORNING;
        }else if (transform.eulerAngles.x <= NightTimeStart)
        {
            _currentTime = TIME.NIGHT;
        }
        else
        {
            //Nothing happend
        }
    }
}

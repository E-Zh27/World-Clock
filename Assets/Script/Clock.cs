using System;
using UnityEngine;

public class Clock : MonoBehaviour {
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;
    public int timeZoneOffset = 0;
    
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;
    

    void Awake () {
        UpdateClock();
    }

    void Update(){
        UpdateClock();
    }

    void UpdateClock() {
        DateTime time = DateTime.UtcNow.AddHours(timeZoneOffset);

        float hours = time.Hour % 12 + time.Minute / 60f; 
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hours * hoursToDegrees);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, time.Minute * minutesToDegrees);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, time.Second * secondsToDegrees);

    }
}

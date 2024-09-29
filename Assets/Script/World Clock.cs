using UnityEngine;
using System;
public class WorldClockManager : MonoBehaviour {
    // Reference to your clock prefab
    public GameObject clockPrefab;


    void Start() {
        // Instantiate the New York clock
        GameObject newYorkClock = Instantiate(clockPrefab, new Vector3((float)7.5, 0, 0), Quaternion.identity);
        Clock newYorkClockScript = newYorkClock.GetComponent<Clock>();
        if (newYorkClockScript != null)
        {
            newYorkClockScript.timeZoneOffset = -4; // New York is UTC-4 (adjust for DST if necessary)
        }


        // Instantiate the San Francisco clock
        
        GameObject sanFranciscoClock = Instantiate(clockPrefab, new Vector3((float)-7.5, 0, 0), Quaternion.identity);
        Clock sanFranciscoClockScript = sanFranciscoClock.GetComponent<Clock>();
        if (sanFranciscoClockScript != null)
        {
            sanFranciscoClockScript.timeZoneOffset = -7; // San Francisco is UTC-7 (adjust for DST if necessary)
        }

        GameObject chinaClock = Instantiate(clockPrefab, new Vector3((float)-7.5, 15, 0), Quaternion.identity);
        Clock chinaClockScript = chinaClock.GetComponent<Clock>();
        if (chinaClockScript != null)
        {
            chinaClockScript.timeZoneOffset = 8; // China o is UTC+8 (adjust for DST if necessary)
        }

        GameObject franceClock = Instantiate(clockPrefab, new Vector3((float)7.5, 15, 0), Quaternion.identity);
        Clock franceClockScript = franceClock.GetComponent<Clock>();
        if (franceClockScript != null)
        {
            franceClockScript.timeZoneOffset = 2; // San Francisco is UTC+2 (adjust for DST if necessary)
        }
    }
}
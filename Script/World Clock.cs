using UnityEngine;

public class WorldClockManager : MonoBehaviour {
    public GameObject clockPrefab; // Reference to your clock prefab

    void Start() {
        // Instantiate the New York clock
        GameObject newYorkClock = Instantiate(clockPrefab, new Vector3(7.5f, 0, 0), Quaternion.identity);
        SetupClock(newYorkClock, "New York", -4);

        // Instantiate the San Francisco clock
        GameObject sanFranciscoClock = Instantiate(clockPrefab, new Vector3(-7.5f, 0, 0), Quaternion.identity);
        SetupClock(sanFranciscoClock, "San Francisco", -7);

        // Instantiate the China clock
        GameObject chinaClock = Instantiate(clockPrefab, new Vector3(-7.5f, 15, 0), Quaternion.identity);
        SetupClock(chinaClock, "China", 8);

        // Instantiate the France clock
        GameObject franceClock = Instantiate(clockPrefab, new Vector3(7.5f, 15, 0), Quaternion.identity);
        SetupClock(franceClock, "France", 2);
    }

    // Helper method to set up each clock
    void SetupClock(GameObject clock, string cityName, int timeZoneOffset) {
        // Assign timezone to clock script
        Clock clockScript = clock.GetComponent<Clock>();
        if (clockScript != null) {
            clockScript.timeZoneOffset = timeZoneOffset;
        }

        // Create and setup the 3D Text (TextMesh) for the city name
        GameObject cityNameTextObject = new GameObject("CityNameText");  // Create a new empty GameObject for the text
        cityNameTextObject.transform.SetParent(clock.transform);         // Parent it to the clock object

        // Adjust the position to be below the clock
        cityNameTextObject.transform.localPosition = new Vector3(0, -7.5f, 0);  // Adjust position relative to the clock

        // Add TextMesh component for rendering 3D text
        TextMesh cityNameText = cityNameTextObject.AddComponent<TextMesh>();
        cityNameText.text = cityName;               // Set the city name text
        cityNameText.characterSize = 1.5f;          // Adjust size (you can tweak this to fit your scene)
        cityNameText.anchor = TextAnchor.MiddleCenter;  // Center the text under the clock
        cityNameText.alignment = TextAlignment.Center;  // Align the text
        cityNameText.color = Color.black;           // Set text color (change as needed)
    }
}

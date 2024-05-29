using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    [SerializeField] List<GameObject> vehicles;
    public static MainManager Instance { get; private set; }

    public int vehicleIndex 
    {
        get
        {
            return m_vehicleIndex;
        }
        set
        {
            if (value < 0)
            {
                Debug.Log("Negative vehicle index!");
                m_vehicleIndex = 0;
            }
            else
            { m_vehicleIndex = value; }
        }
    }

    private int m_vehicleIndex;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetupPlayer()
    {
        Instantiate(vehicles[vehicleIndex]);
    }

    private void OnLevelWasLoaded(int level)
    {
        if (level == 1)
        {
            SetupPlayer();
        }
    }
}

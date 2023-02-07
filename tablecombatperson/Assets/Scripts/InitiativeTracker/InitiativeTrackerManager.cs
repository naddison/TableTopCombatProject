using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiativeTrackerManager : MonoBehaviour
{

    private int _trackerCurrentActive;

    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject _player1;
    [SerializeField] private GameObject _player2;


    // Start is called before the first frame update
    void Start()
    {
        _trackerCurrentActive = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FinishTurnButton()
    {

    }

    private void StartOfTurn()
    {

    }
}

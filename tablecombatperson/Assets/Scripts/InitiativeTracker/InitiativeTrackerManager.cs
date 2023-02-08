using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine;

public class InitiativeTrackerManager : MonoBehaviour
{

    private int _trackerCurrentActiveTurn;
    
    [SerializeField] private int _totalActiveCharacters;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject _player1;
    [SerializeField] private GameObject _player2;


    // Start is called before the first frame update
    void Start()
    {
        _trackerCurrentActiveTurn = 1;
        Debug.Log($"Character" + _trackerCurrentActiveTurn + "'s Turn!");
    }

    public void FinishTurnButton()
    {
        _trackerCurrentActiveTurn += 1;
        if(_trackerCurrentActiveTurn > _totalActiveCharacters)
        {
            _trackerCurrentActiveTurn = 1;
        }

        Debug.Log($"Character"+ _trackerCurrentActiveTurn + "'s Turn!");
    }

}

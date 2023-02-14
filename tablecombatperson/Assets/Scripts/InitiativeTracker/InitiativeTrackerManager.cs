using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine;
using TMPro;

public class InitiativeTrackerManager : MonoBehaviour
{

    private int _trackerCurrentActiveTurn;
    private Vector4 _deselectedTextColor = new Vector4 (255,255,255,255);
    private Vector4 _selectedTextColor = new Vector4 (0, 255, 41,255);

    [SerializeField] private int _totalActiveCharacters;
    [SerializeField] private TextMeshProUGUI [] _initiativeTrackerTextObject;


    // Start is called before the first frame update
    void Start()
    {
        _trackerCurrentActiveTurn = 1;
        Debug.Log($"Character" + _trackerCurrentActiveTurn + "'s Turn!");
        TurningOnActiveElements(_trackerCurrentActiveTurn);

    }

    public void FinishTurnButton()
    {
        _trackerCurrentActiveTurn += 1;

        if(_trackerCurrentActiveTurn > _totalActiveCharacters)
        {
            _trackerCurrentActiveTurn = 1;
        }

        TurningOnActiveElements(_trackerCurrentActiveTurn);
        Debug.Log($"Character"+ _trackerCurrentActiveTurn + "'s Turn!");
    }

    private void TurningOnActiveElements(int activeTracker)
    {
        Debug.Log("Im at least in");

        if(_trackerCurrentActiveTurn == 1) //Player 1
        {
            Debug.Log("SETTING COLOR");
            _initiativeTrackerTextObject[0].color = _selectedTextColor;
            _initiativeTrackerTextObject[1].color = _deselectedTextColor;
            _initiativeTrackerTextObject[2].color = _deselectedTextColor;
        }
        if (_trackerCurrentActiveTurn == 2) //Player 1
        {
            Debug.Log("SETTING COLOR");
            _initiativeTrackerTextObject[1].color = _selectedTextColor;
            _initiativeTrackerTextObject[0].color = _deselectedTextColor;
            _initiativeTrackerTextObject[2].color = _deselectedTextColor;
        }
        if (_trackerCurrentActiveTurn == 3) //Player 1
        {
            Debug.Log("SETTING COLOR");
            _initiativeTrackerTextObject[2].color = _selectedTextColor;
            _initiativeTrackerTextObject[1].color = _deselectedTextColor;
            _initiativeTrackerTextObject[0].color = _deselectedTextColor;
        }

    }

}

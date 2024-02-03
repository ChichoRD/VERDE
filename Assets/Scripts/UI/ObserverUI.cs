using TMPro;
using UnityEngine;

public class ObserverUI : MonoBehaviour
{
    [SerializeField]
    private LinkStats _linkStats;

    [SerializeField]
    private bool _subscribeOnAwake = true;

    [SerializeField]
    private TMP_Text _bombAmountText;

    [SerializeField]
    private TMP_Text _keyAmountText;

    [SerializeField]
    private TMP_Text _rupeeAmountText;

    [SerializeField]
    private GameObject[] _hearts;

    [SerializeField]
    private GameObject _sword;

    private void Awake()
    {
        if (!_subscribeOnAwake)
            return;

        _linkStats.OnBombChange.AddListener(OnBombChanged);
        _linkStats.OnKeyChange.AddListener(OnKeyChanged);
        _linkStats.OnRupeeChange.AddListener(OnRuppeChanged);
        _linkStats.OnHealthChange.AddListener(OnHealthChanged);
        _linkStats.OnTakeSword.AddListener(OnTakeSword);
    }


    private void OnDestroy()
    {
        _linkStats.OnBombChange.RemoveListener(OnBombChanged);
        _linkStats.OnKeyChange.RemoveListener(OnKeyChanged);
        _linkStats.OnRupeeChange.RemoveListener(OnRuppeChanged);
        _linkStats.OnHealthChange.RemoveListener(OnHealthChanged);
        _linkStats.OnTakeSword.RemoveListener(OnTakeSword);
    }

    private void OnBombChanged(int arg0)
    {
        _bombAmountText.text = $"x{arg0}";
    }

    private void OnKeyChanged(int arg0)
    {
        _keyAmountText.text = $"x{arg0}";
    }

    private void OnRuppeChanged(int arg0)
    {
        _rupeeAmountText.text = $"x{arg0}";
    }

    private void OnHealthChanged(int arg0)
    {
        for (int i = 0; i < _hearts.Length; i++)
            _hearts[i].SetActive(i < arg0);
    }

    private void OnTakeSword()
    {
        _sword.SetActive(true);
    }
}

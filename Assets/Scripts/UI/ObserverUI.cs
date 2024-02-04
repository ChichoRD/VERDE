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
    private GameObject[] _heartContainers;

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
        _linkStats.OnCurrentHealthChange.AddListener(OnCurrentHealthChanged);
        _linkStats.OnMaxHealthChange.AddListener(OnMaxHealthChanged);
        _linkStats.OnHasSwordChange.AddListener(OnHasSwordChanged);
    }

    private void OnDestroy()
    {
        _linkStats.OnBombChange.RemoveListener(OnBombChanged);
        _linkStats.OnKeyChange.RemoveListener(OnKeyChanged);
        _linkStats.OnRupeeChange.RemoveListener(OnRuppeChanged);
        _linkStats.OnCurrentHealthChange.RemoveListener(OnCurrentHealthChanged);
        _linkStats.OnMaxHealthChange.RemoveListener(OnMaxHealthChanged);
        _linkStats.OnHasSwordChange.RemoveListener(OnHasSwordChanged);
    }

    private void Start() {
        _bombAmountText.text = $"x{_linkStats.bombCount}";
        _keyAmountText.text = $"x{_linkStats.keyCount}";
        _rupeeAmountText.text = $"x{_linkStats.rupeeCount}";
        _sword.SetActive(_linkStats.hasSword);

        for (int i = 0; i < _hearts.Length; i++)
            _hearts[i].SetActive(i < _linkStats.currentHealth);

        for (int i = 0; i < _heartContainers.Length; i++)
            _heartContainers[i].SetActive(i < _linkStats.maxHealth);
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

    private void OnCurrentHealthChanged(int arg0)
    {
        for (int i = 0; i < _hearts.Length; i++)
            _hearts[i].SetActive(i < arg0);
    }

    private void OnMaxHealthChanged(int arg0)
    {
        for (int i = 0; i < _heartContainers.Length; i++)
            _heartContainers[i].SetActive(i < arg0);
    }

    private void OnHasSwordChanged(bool arg0)
    {
        _sword.SetActive(arg0);
    }
}

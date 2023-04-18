using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class PlayerSwordMovement : MonoBehaviour
{
    [SerializeField] private Button _leftUpperButton, _rightUpperButton;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _leftUpperButton.onClick.AddListener(DoLeftUpperBlock);
        _rightUpperButton.onClick.AddListener(DoRightUpperBlock);
    }

    private void DoLeftUpperBlock()
    {
        _animator.SetTrigger("UpperLeftBlock");
    }

    private void DoRightUpperBlock()
    {
        _animator.SetTrigger("UpperRightBlock");
    }
}

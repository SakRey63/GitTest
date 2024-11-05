using System.Drawing;
using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class PlayerFollower : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _hero;
    
    private void Update()
    {
        var direction = (_player.position - transform.position).normalized;
        transform.Translate(direction * _speed);

        _player.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
    }
    
    
    
}

using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 nextDirection;
    private void Update()
    {
        nextDirection.z += _speed * Time.deltaTime;
        transform.Translate(nextDirection, Space.Self);
    }
}

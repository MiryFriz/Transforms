using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 speed = Vector3.one* _speed;
        transform.localScale += (Vector3.one + speed) * Time.deltaTime;
    }
}

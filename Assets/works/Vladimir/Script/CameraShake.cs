using Cinemachine;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private CinemachineImpulseSource impulseSource;

    //used with button
    public void Shake()
    {
        impulseSource.GenerateImpulse();
    }

    
}

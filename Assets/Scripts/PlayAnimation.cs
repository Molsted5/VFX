using UnityEngine;
using UnityEngine.InputSystem;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField] private GameObject mainProjectile;
    [SerializeField] private ParticleSystem mainParticleSystem;

    private void Awake() {
        mainProjectile.SetActive(false);
    }

    void Update()
    {
        if( Keyboard.current.spaceKey.wasPressedThisFrame ) {
            mainProjectile.SetActive( !mainParticleSystem.IsAlive() );
        }
        if ( !mainParticleSystem.IsAlive() ) {
            mainProjectile.SetActive( false );
        }

    }
}

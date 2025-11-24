using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ShootScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 100f;
    public float bulletLifeTime = 5f;

    public AudioClip clip;
    public AudioSource source;

    public InputActionReference triggerAction;

    private XRGrabInteractable grabInteractable;
    private bool isHeld = false;

    void Start()
    {
        source = GetComponent<AudioSource>();

        // Subscribe to grab events
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);

        triggerAction.action.performed += ctx => FireBullet();
    }

    void OnEnable() => triggerAction.action.Enable();
    void OnDisable() => triggerAction.action.Disable();

    private void OnGrab(SelectEnterEventArgs arg)
    {
        isHeld = true;
    }

    private void OnRelease(SelectExitEventArgs arg)
    {
        isHeld = false;
    }

    public void FireBullet()
    {
        if (!isHeld) return;   // <<< IMPORTANT — No shooting unless held

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        source.PlayOneShot(clip);

        if (rb != null)
            rb.velocity = firePoint.forward * bulletSpeed;

        Destroy(bullet, bulletLifeTime);
    }
}

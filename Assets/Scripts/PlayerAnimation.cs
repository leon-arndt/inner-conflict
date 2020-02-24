using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public static PlayerAnimation Instance;

    [SerializeField]
    AnimationCurve stretchCurve, squashCurve;

    float lastSquashTime = 0f;
    float squashCooldown = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    public void PlayStretch()
    {
        StartCoroutine(Async_Stretch(0.3f));
    }

    public IEnumerator Async_Stretch(float duration)
    {
        Transform target = CharacterController2D.Instance.transform;
        float normalYScale = 0.5f; //TODO set dynamically
        float normalXScale = 0.5f;

        for (float time = 0f; time <= duration; time += Time.deltaTime)
        {
            float ratio = 1.1f * time / duration;
            float val = stretchCurve.Evaluate(ratio);

            target.localScale = new Vector3(normalXScale / val, normalYScale * val, target.localScale.z);
            Debug.Log("ping");

            yield return null;
        }
    }

    public void PlaySquash()
    {
        //if (Time.time < lastSquashTime + squashCooldown) return;

        StartCoroutine(Async_Squash(0.3f));
        //lastSquashTime = Time.time;
    }

    public IEnumerator Async_Squash(float duration)
    {
        Transform target = CharacterController2D.Instance.transform;
        float normalYScale = 0.5f; //TODO set dynamically
        float normalXScale = 0.5f;

        for (float time = 0f; time <= duration; time += Time.deltaTime)
        {
            float ratio = 1.1f * time / duration;
            float val = squashCurve.Evaluate(ratio);

            target.localScale = new Vector3(normalXScale / val, normalYScale * val, target.localScale.z);
            Debug.Log("ping");

            yield return null;
        }
    }
}

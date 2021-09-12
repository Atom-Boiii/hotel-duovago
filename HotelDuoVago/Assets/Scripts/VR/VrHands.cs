using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrHands : MonoBehaviour
{
    private Animator anims;

    public GameObject hand;

    private HandPrescence prescence;

    // Start is called before the first frame update
    void Start()
    {
        anims = GetComponent<Animator>();
        prescence = GetComponent<HandPrescence>();
    }

    // Update is called once per frame
    void Update()
    {
        anims.SetBool("Grab", prescence.HasGripPressed());
    }

    public void SetHand(bool state)
    {
        hand.SetActive(state);
    }
}

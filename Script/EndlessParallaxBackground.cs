using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessParallaxBackground : MonoBehaviour
{
    [SerializeField] private GameObject layer1;
    [SerializeField] private GameObject layer2;

    [SerializeField] private float layer1ParallaxEffect;
    [SerializeField] private float layer2ParallaxEffect;
    [SerializeField] private float length;

    private float layer1XPosition;
    private float layer2XPosition;

    public bool isBackgroundMove;
    
    void Start()
    {
    }

    void Update()
    {
        if(!isBackgroundMove)
            return;

        layer1XPosition = layer1.transform.position.x;
        layer1XPosition += layer1ParallaxEffect * Time.deltaTime;
        layer1.transform.position = new Vector3(layer1XPosition, layer1.transform.position.y, layer1.transform.position.z);

        if (layer1XPosition > length)
        {
            layer1.transform.position = new Vector3(-length, layer1.transform.position.y, layer1.transform.position.z);
        }
        if (layer1XPosition < -length)
        {
            layer1.transform.position = new Vector3(length, layer1.transform.position.y, layer1.transform.position.z);
        }


        layer2XPosition = layer2.transform.position.x;
        layer2XPosition += layer2ParallaxEffect * Time.deltaTime;
        layer2.transform.position = new Vector3(layer2XPosition, layer2.transform.position.y, layer2.transform.position.z);

        if (layer2XPosition > length)
        {
            layer2.transform.position = new Vector3(-length, layer2.transform.position.y, layer2.transform.position.z);
        }
        if (layer2XPosition < -length)
        {
            layer2.transform.position = new Vector3(length, layer2.transform.position.y, layer2.transform.position.z);
        }
    }

}
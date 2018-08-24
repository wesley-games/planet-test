using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{

    public GameObject roundedCube;

    public void Generate()
    {
        GameObject newCube = Instantiate(roundedCube, new Vector3(0, 50, 0), Random.rotation);
        RoundedCubeGenerator generator = newCube.GetComponent<RoundedCubeGenerator>();
        generator.xSize = Random.Range(4, 10);
        generator.ySize = Random.Range(4, 10);
        generator.zSize = Random.Range(4, 10);
        generator.roundness = 2;
        generator.Generate();
    }
}

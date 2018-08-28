using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{

    public GameObject roundedCube;
    public GameObject spheredCube;

    public void GenerateRoundedCube()
    {
        GameObject newCube = Instantiate(roundedCube, new Vector3(0, 50, 0), Random.rotation);
        RoundedCubeGenerator generator = newCube.GetComponent<RoundedCubeGenerator>();
        generator.xSize = Random.Range(4, 10);
        generator.ySize = Random.Range(4, 10);
        generator.zSize = Random.Range(4, 10);
        generator.roundness = 2;
        generator.Generate();
    }

    public void GenerateSpheredCube()
    {
        GameObject newSphere = Instantiate(spheredCube, new Vector3(0, 50, 0), Random.rotation);
        SpheredCubeGenerator generator = newSphere.GetComponent<SpheredCubeGenerator>();
        generator.gridSize = 8;
        generator.Generate();
    }
}

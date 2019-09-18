using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushiGenerator : MonoBehaviour
{
    public GameObject mushi;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("GenMushi", 1, 1);
    }

    void GenMushi () {
		Instantiate (mushi, new Vector2 (-2.5f + 5 * Random.value, 0), Quaternion.identity);
	}
}

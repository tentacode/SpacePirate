using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    const int PIXEL_PER_UNIT = 16;

    public int pixelScaling = 6;

    protected Camera camera;

	void Start()
    {
        camera = GetComponent<Camera>();
        camera.orthographicSize = Screen.height * 0.5f / (pixelScaling * PIXEL_PER_UNIT);
	}
}

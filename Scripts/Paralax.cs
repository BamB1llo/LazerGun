using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class Paralax : MonoBehaviour
{
    [SerializeField] private float _speed;

    private RawImage _image;
    private float _imagePositionY;
    private float _imagePositionX = 0f;
    
    private void Start()
    {
        _image = GetComponent<RawImage>();
    }

    private void Update()
    {
        _imagePositionY += _speed * Time.deltaTime;

        _image.uvRect = new Rect(_imagePositionX, _imagePositionY, _image.uvRect.width, _image.uvRect.height);
    }
}

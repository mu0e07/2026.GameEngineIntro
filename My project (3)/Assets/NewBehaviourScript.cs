using UnityEngine;
using untiyEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        private Vector2 movelnput;
    public void Onmove(InputValue value)
    {
        movelnput = value.Get<vector2>();
    }
    // Update is called once per frame
    void Update()
    {
        if (movelnput.x > 0)
        {
            transform. IocalScale = new vector3(1, 1, 1);
        }
        else if (movelnput.x < 0)
        {
            transform.IocalScale = new vector3(1, 1, 1);
        }
        transform,Translate(vector3.right * moveSpeed * movelnput x * Time. deltaTime);
    }
}

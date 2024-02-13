public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20.0F;
    private Vector3 velocity = Vector3.up
    public float verticalInput1;

    private float forwardInput;

    private float VerticalInput { get => verticalInput; set => verticalInput = value; }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        //Move the plan forward
        verticalInput = Input.GetAxis("Vertical");
        forwardInput = Input.GetAxis("Horizontal");

        // Moves the plan forward on horizontal input
        transform.Translate(Vector3.forward * speed * forwardInput);

        // Tilt the plane up/down based on up/down arrow keys input 
        transform.Rotate(Vector3.up, turnSpeed * verticalInput * Time.deltaTime);
        if (forwardInput.KeyDown(KeyCode.Up)) transform.position += velocity * Time.delTime;
        if (forwardInput.KeyDown(Keycode.Down)) transform.position -= velocity * Time.delTime;
    }
}

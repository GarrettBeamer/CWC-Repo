public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20.0F;
    public Vector3 velocity = Vector3.up;
    private Vector3 offset = new Vector3(0, 5, -7);


    private float forwardInput;

    private float VerticalInput { get => VerticalInput; set => VerticalInput = value; }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        //Move the plan forward
        VerticalInput = Input.GetAxis("Vertical");
        forwardInput = Input.GetAxis("Horizontal");

        // Moves the plan forward on horizontal input
        transform.Translate(Vector3.forward * speed * forwardInput);

        // Tilt the plane up/down based on up/down arrow keys input 
        transform.Rotate(Vector3.up, turnSpeed * VerticalInput * Time.deltaTime);
        if (forwardInput.KeyDown(KeyCode.Up)) transform.position += Velocity * Time.delTime;
        if (forwardInput.KeyDown(Keycode.Down)) transform.position -= Velocity * Time.delTime;
    }
}

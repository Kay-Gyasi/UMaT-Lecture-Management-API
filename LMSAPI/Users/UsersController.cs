namespace LMSAPI.Users;

public class UsersController : Controller
{
    private readonly UserProcessor _processor;

    public UsersController(UserProcessor processor)
    {
        _processor = processor;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok(await _processor.GetAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> Login([FromBody] LoginCommand command)
    {
        return Ok(await _processor.LoginAsync(command));
    }

    [HttpPost]
    public async Task<IActionResult> Signup([FromBody] SignupCommand command)
    {
        var result = await _processor.Save(command);
        return CreatedAtRoute(nameof(Get), result);
    }
}
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using webapiinsvalores.Models;

namespace webapiinsvalores.Controllers;

[ApiController]
[Route("api/transactions")]
public class TransactionsController : ControllerBase
{
    private static readonly object objTranResult = new {
        cr = "00",
        mr = string.Empty,
        et = string.Empty
    };
    private readonly ILogger<TransactionsController> _logger;

    private static readonly string localTime = DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.fffZ");

    public TransactionsController(ILogger<TransactionsController> logger)
    {
        _logger = logger;
    }

    [HttpPut("ConsultarFechaValor")]
    public IActionResult GetFechaValor([FromBody] JsonStringRequest pJsonString)
    {
        _logger.LogInformation(pJsonString.pJsonString);

        var response = new {
            datos = new {
                ds = localTime,
                fv = localTime
            },
            respuesta = objTranResult
        };

        return Ok(new {
            ConsultarFechaValorResult = JsonSerializer.Serialize(response)
        });
    }

    [HttpPut("ConsultarFondosCuenta")]
    public IActionResult GetFondosCuenta([FromBody] JsonStringRequest pJsonString)
    {
        _logger.LogInformation(pJsonString.pJsonString);

        var response = new {
            datos = new []{
                new {
                    cf = 0,
                    fo = "test",
                    cm = "test",
                    fm = "test",
                    ms = 0
                },
                new {
                    cf = 0,
                    fo = "test",
                    cm = "test",
                    fm = "test",
                    ms = 0
                }
            },
            respuesta = objTranResult
        };

        return Ok(new {
            ConsultarFondosCuentaResult = JsonSerializer.Serialize(response)
        });
    }

    [HttpPut("ConsultarCorreosPersona")]
    public IActionResult GetCorreosPersona([FromBody] JsonStringRequest pJsonString)
    {
        _logger.LogInformation(pJsonString.pJsonString);

        var response = new {
            datos = new []{
                new {
                    v = "test1@gmail.com"
                },
                new {
                    v = "test2@gmail.com"
                }
            },
            respuesta = objTranResult
        };

        return Ok(new {
            ConsultarFondosCuentaResult = JsonSerializer.Serialize(response)
        });
    }

    [HttpPut("ConsultarSolicitudes")]
    public IActionResult GetSolicitudes([FromBody] JsonStringRequest pJsonString)
    {
        _logger.LogInformation(pJsonString.pJsonString);

        var date = localTime;

        var response = new {
            datos = new []{
                new {
                    ns = 1000,
                    fs = date,
                    fv = date,
                    cu = 0,
                    cs = 0,
                    nc = "test",
                    ts = "test",
                    ds = "test",
                    tr = "test",
                    dr = "test",
                    cf = 0,
                    fo = "test",
                    cm = "test",
                    mo = "test",
                    ms = 0,
                    np = 0,
                    vp = 0,
                    es = "tst",
                    cd = 0,
                    sd = 0,
                    fd = "test",
                    fn = "test",
                    cn = "test"
                },
                new {
                    ns = 1001,
                    fs = date,
                    fv = date,
                    cu = 0,
                    cs = 0,
                    nc = "test",
                    ts = "test",
                    ds = "test",
                    tr = "test",
                    dr = "test",
                    cf = 0,
                    fo = "test",
                    cm = "test",
                    mo = "test",
                    ms = 0,
                    np = 0,
                    vp = 0,
                    es = "tst",
                    cd = 0,
                    sd = 0,
                    fd = "test",
                    fn = "test",
                    cn = "test"
                }
            },
            respuesta = objTranResult
        };

        return Ok(new {
            ConsultarFondosCuentaResult = JsonSerializer.Serialize(response)
        });
    }
}
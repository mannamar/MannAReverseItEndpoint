// Amardeep Mann
// 10-27-22
// Reverse It - Endpoint
// Create a Reverse It WebAPI project that takes in a string variable via the URL
// Peer reviewed by

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MannAReverseItEndpoint.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ReverseItCOntroller : ControllerBase
  {
    [HttpGet]
    public string ReverseItDefault()
    {
      string words = "This is backwards.";
      char[] array = words.ToCharArray();
      Array.Reverse(array);
      return new String(array);
    }

    [HttpGet("{str}")]
    public string ReverseIt(string str)
    {
      char[] array = str.ToCharArray();
      Array.Reverse(array);
      return new String(array);
    }
  }
}
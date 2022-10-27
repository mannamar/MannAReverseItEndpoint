// Amardeep Mann
// 10-27-22
// Reverse It - Endpoint
// Create a Reverse It WebAPI project that takes in a string variable via the URL and outputs the reverse
// Peer reviewed by: Jovann Contreras: The program runs with no errors, code is understandable and clean, I really like how Amar found a way to input something without having to call the route I thought it was really cool. Another thing I liked was how he go the original word to display and also displayed the reversed word.

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
      return $"Original string:\n{words}\n\nReversed string:\n{String.Join("", array)}";
    }

    [HttpGet("{str}")]
    public string ReverseIt(string str)
    {
      char[] array = str.ToCharArray();
      Array.Reverse(array);
      return $"Original string:\n{str}\n\nReversed string:\n{String.Join("", array)}";
    }
  }
}
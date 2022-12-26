
using Microsoft.AspNetCore.Mvc;

public class NumberController : Controller
{
    public IActionResult MTable()       //  /number/greet
    {
        return View();
    }

    public IActionResult MultiplicationTable(int value)
    {
        return View(value);
    }

    public IActionResult MultiplicationTableFromTo(int from, int to)
    {
        return View((from, to));
    }
}

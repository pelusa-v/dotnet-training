using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleMovies.Data;
using SampleMovies.Models;

namespace SampleMovies;

public class MoviesController : Controller
{
    private readonly AppDbContext _context;

    public MoviesController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return RedirectToAction("List");
    }

    public IActionResult Create(Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();
        return RedirectToAction("List");
    }

    public async Task<IActionResult> Update(int id)
    {
        var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
        if(movie == null)
        {
            return NotFound();
        }
        return View(movie);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Update(int id, [Bind("Id,Title,ReleaseDate,Genre,Price")] Movie movie)
    {
        if (id != movie.Id)
        {
            return BadRequest();
        }

        if (!await _context.Movies.AnyAsync(m => m.Id == id))
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction("Get", new { id = movie.Id });
        }
        return View(movie);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
        if(movie == null)
        {
            return NotFound();
        }

        _context.Movies.Remove(movie);
        await _context.SaveChangesAsync();
        return RedirectToAction("List");
    }

    public async Task<IActionResult> Get(int id)
    {
        var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
        if(movie == null)
        {
            return NotFound();
        }
        return View(movie);
    }

    public async Task<IActionResult> List()
    {
        var movies = await _context.Movies.ToListAsync();
        return View(movies);
    }
}

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

    public IActionResult Update(int id)
    {
        // _context.Movies.Update(udpatedMovie);
        // _context.SaveChanges();
        // return View();
        return RedirectToAction("List");
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

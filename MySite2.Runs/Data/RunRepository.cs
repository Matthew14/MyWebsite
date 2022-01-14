using System;
using System.Collections.Generic;
using System.Linq;
using MySite2.Runs.Models;

namespace MySite2.Runs.Data;

public class RunRepository : IRunRepository
{
    private readonly AppDbContext _context;

    public RunRepository(AppDbContext context)
    {
        _context = context;
    }

    public void CreateRun(Run run)
    {
        if(run == null)
        {
            throw new ArgumentNullException(nameof(run));
        }

        _context.Runs.Add(run);
    }

    public IEnumerable<Run> GetAllRuns() => _context.Runs.ToList();

    public Run GetRunById(int id)
    {
        return _context.Runs.FirstOrDefault(p => p.Id == id);
    }

    public bool SaveChanges() => _context.SaveChanges() >= 0;
}
using System.Collections.Generic;
using MySite2.Runs.Models;

namespace MySite2.Runs.Data;

public interface IRunRepository
{
    bool SaveChanges();
    IEnumerable<Run> GetAllRuns();
    Run GetRunById(int id);
    void CreateRun(Run run);   
}
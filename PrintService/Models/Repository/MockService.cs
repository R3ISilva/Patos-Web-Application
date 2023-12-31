﻿using System.Security.Cryptography.X509Certificates;
using PrintService.Models.Print;

namespace PrintService.Models.Repository;

public class MockService : IRepositoryService
{
    private readonly List<IPrint> _prints = new List<IPrint>();

    public void AddPrint(IPrint print)
    {
        print.Id = _prints.Count + 1;
        _prints.Add(print);
    }
    
    public IEnumerable<IPrint> GetAllPrints()
    {
        return _prints;
    }

    public IPrint GetPrint(int id)
    {
        return _prints.FirstOrDefault(p => p.Id == id);
    }
        
    public IPrint UpdatePrint(IPrint print)
    {
        var index = _prints.FindIndex(p => p.Id == print.Id);
        
        if (index < 0)
        {
            return null;
        } 
        
        _prints[index] = print;
        
        return print;
    }

    public void DeletePrint(int id)
    {
        var index = _prints.FindIndex(p => p.Id == id);
        _prints.RemoveAt(index);
    }
}